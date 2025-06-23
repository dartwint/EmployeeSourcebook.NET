using EmployeeSourcebook.DbAccess.Connection;
using EmployeeSourcebook.DbAccess.Management;
using EmployeeSourcebook.DbAccess.Model;
using EmployeeSourcebook.Properties;
using EmployeeSourcebook.Views;
using Microsoft.Data.Sqlite;
using Npgsql;
using System.ComponentModel;
using System.Data;
using System.Data.Common;

namespace EmployeeSourcebook.Controllers
{
    internal class ConnectionController
    {
        private FormConnection _formConnection;
        private FormMain _formMain;
        private ConnectionMonitor? _connectionMonitor;

        public ConnectionController(FormConnection formConnection, FormMain formMain)
        {
            _formConnection = formConnection;
            _formMain = formMain;

            _formConnection.ConnectionRequested += OnConnectionTestRequested;
            _formConnection.FormClosed += OnFormConnectionClosed;
            _formConnection.Load += OnFormConnectionOpened;
            _formMain.TableTabSelected += OnTableTabSelected;
        }

        private void SetDataToGridView(DataGridView dataGridView, object? data)
        {
            //dataGridView.DataSource = new BindingList<>();
            dataGridView.DataSource = data;
        }

        private void OnTableTabSelected(TableTab tableTab)
        {
            if (_connectionMonitor == null || _connectionMonitor.DbConnection.State != ConnectionState.Open)
            {
                return;
            }

            string tableName = tableTab.Text;
            var data = UserActionToSQLCommand.GetDataFromTable(new SQLExecutor(), 
                _connectionMonitor.DbConnection, tableName);

            
            if (_formMain.InvokeRequired)
            {
                _formMain.Invoke(() => SetDataToGridView(_formMain.DataGridView, data));
            }
            else
            {
                SetDataToGridView(_formMain.DataGridView, data);
            }
        }

        private void OnFormConnectionClosed(object? sender, FormClosedEventArgs e)
        {
            if (_connectionMonitor != null)
            {
                _connectionMonitor.ConnectionAttempt += UpdateFormMain;
                _connectionMonitor.Start(new TimeSpan(0, 0, 2), 2);

                
                _formMain.SetTablesTabs(CreateTabs());
            }
        }

        private List<TableTab>? CreateTabs()
        {
            if (_connectionMonitor == null || _connectionMonitor.DbConnection.State != ConnectionState.Open)
                return null;

            string? commandFile = GetListTablesCommandFileFromRepository(_connectionMonitor.DbConnection.GetType());
            if (commandFile != null)
            {
                DbCommand command = _connectionMonitor.DbConnection.CreateCommand();
                command.CommandText = File.ReadAllText(commandFile);

                var executor = new SQLExecutor();
                var listExecResult = executor.Execute(_connectionMonitor.DbConnection, command.CommandText);
                List<TableTab> tabs = new();
                foreach (var item in listExecResult)
                {
                    tabs.Add(new TableTab(item));
                }

                return tabs;
            }

            return null;
        }

        private string? GetListTablesCommandFileFromRepository(Type type) 
        {
            if (!type.IsAssignableTo(typeof(DbConnection)))
                return null;

            if (type.IsAssignableFrom(typeof(SqliteConnection)))
            {
                return Resources.SQLiteListTablesCommand;
            }

            if (type.IsAssignableFrom(typeof(NpgsqlConnection)))
            {
                return Resources.PostgreSQLListTablesCommand;
            }

            return null;
        }

        private void OnFormConnectionOpened(object? sender, EventArgs e)
        {
            if (_connectionMonitor != null)
            {
                _connectionMonitor.ConnectionAttempt -= UpdateFormMain;
                _connectionMonitor.Stop();
            }
        }

        private void OnConnectionTestRequested(IConnectionInfo? connectionInfo)
        {
            if (connectionInfo == null)
                return;

            _formConnection.LockOnConnection();

            if (_connectionMonitor != null && _connectionMonitor.IsRunning)
            {
                _connectionMonitor.Stop();
            }

            _formConnection.SetConnectionStatus(ConnectionState.Connecting);

            var connectionFactory = new DbConnectionFactory();
            Exception? exception;
            var connection = connectionFactory.Create(connectionInfo, out exception);
            if (connection == null)
            {
                _formConnection.SetConnectionStatus(ConnectionState.Broken);

                string message = "You entered incorrect data.\n" +
                    "Please, check your input and retry again.";
                if (exception != null)
                    message += $"\nError reason:\n{exception.Message}";

                MessageBox.Show(message, "Connection error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;
            }

            _connectionMonitor = new ConnectionMonitor(connection);

            bool connectionResult = _connectionMonitor.TryConnect();
            if (connectionResult)
            {
                UpdateFormConnection(ConnectionState.Open);
            }
            else
            {
                UpdateFormConnection(ConnectionState.Broken);
            }

            _formConnection.UnlockOnConnection();
        }

        private void UpdateFormConnection(ConnectionState connectionState)
        {
            if (_formConnection.InvokeRequired)
            {
                _formConnection.Invoke(() => _formConnection.SetConnectionStatus(connectionState));
            }
            else
            {
                _formConnection.SetConnectionStatus(connectionState);
            }
        }

        private void UpdateFormMain(ConnectionState connectionState)
        {
            if (_formMain.InvokeRequired)
            {
                _formMain.Invoke(() => _formMain.SetConnectionStateInfo(connectionState));
            }
            else
            {
                _formMain.SetConnectionStateInfo(connectionState);
            }
        }
    }
}
