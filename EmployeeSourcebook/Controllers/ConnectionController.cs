using EmployeeSourcebook.DbAccess.Connection;
using EmployeeSourcebook.DbAccess.Management;
using EmployeeSourcebook.DbAccess.Model;
using EmployeeSourcebook.Views;
using System.Data;
using System.Data.Common;

namespace EmployeeSourcebook.Controllers
{
    public class ConnectionController
    {
        private DbConnection? _dbConnection;

        public DbConnection? DbConnection
        {
            get
            {
                return _dbConnection;
            }
            private set
            {
                if (value == null && _dbConnection != null)
                {
                    _dbConnection.Close();
                    _dbConnection?.Dispose();
                    _dbConnection = null;

                    OnConnectionChanged();

                    return;
                }

                if (value != _dbConnection)
                {
                    _dbConnection = value;
                    OnConnectionChanged();

                    return;
                }
                //else if (value != null && _dbConnection != null && value.ConnectionString.Equals(_dbConnection.ConnectionString))
                //{

                //}

                _dbConnection = value;
                OnConnectionChanged();
            }
        }

        public event Action<DbConnection?>? ConnectionChanged;
        public event Action<ConnectionState>? ConnectionStateUpdated;

        private FormConnection _formConnection;
        private FormMain _formMain;
        private ConnectionMonitor _connectionMonitor;

        public ConnectionController(FormConnection formConnection, FormMain formMain)
        {
            _formConnection = formConnection;
            _formMain = formMain;
            _connectionMonitor = new ConnectionMonitor();

            _formConnection.FormClosed += OnFormConnectionClosed;
            _formConnection.Load += OnFormConnectionOpened;

            //DbConnection.StateChange += OnDbConnectionStateChanged;
        }

        private void OnFormConnectionClosed(object? sender, FormClosedEventArgs e)
        {
            if (DbConnection != null && DbConnection.State == ConnectionState.Open)
                _connectionMonitor.Start(new TimeSpan(0, 0, 2), 2);
        }

        private void OnFormConnectionOpened(object? sender, EventArgs e)
        {
            _connectionMonitor.Stop();
        }

        public void TryConfigureConnection(IConnectionInfo? connectionInfo)
        {
            if (connectionInfo == null)
                return;

            _formConnection.LockOnConnection();

            if (_connectionMonitor != null && _connectionMonitor.IsRunning)
            {
                _connectionMonitor.Stop();
            }

            _formConnection.UpdateConnectionStatus(ConnectionState.Connecting);
            _formConnection.Update();

            var connectionFactory = new DbConnectionFactory();
            Exception? exception;
            var connection = connectionFactory.Create(connectionInfo, out exception);
            if (connection == null)
            {
                _formConnection.UpdateConnectionStatus(ConnectionState.Broken);

                string message = "You entered incorrect data.\n" +
                    "Please, check your input and retry again.";
                if (exception != null)
                    message += $"\nError reason:\n{exception.Message}";

                MessageBox.Show(message, "Connection error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                DbConnection = null;
                
                return;
            }

            DbConnection = connection;
            DbConnection.Disposed += OnDbConnectionDisposed;
            DbConnection.StateChange += OnDbConnectionStateChanged;

            _connectionMonitor = new ConnectionMonitor(DbConnection);

            bool connectionResult = _connectionMonitor.TryConnect();
            if (connectionResult)
            {
                ConnectionStateUpdated?.Invoke(ConnectionState.Open);

                //if (_connectionMonitor.DbConnection != null)
                //    WriteDummyDataToDb(_connectionMonitor.DbConnection);
            }
            else
            {
                ConnectionStateUpdated?.Invoke(ConnectionState.Broken);
            }

            _formConnection.UnlockOnConnection();
        }

        private void OnConnectionChanged()
        {
            if (DbConnection != null)
                _connectionMonitor.UpdateConnection(DbConnection);

            ConnectionChanged?.Invoke(DbConnection);
        }

        private void OnDbConnectionDisposed(object? sender, EventArgs e)
        {
            _dbConnection = null;
        }

        private void OnDbConnectionStateChanged(object sender, StateChangeEventArgs e)
        {
            if (DbConnection == null)
            {
                ConnectionStateUpdated?.Invoke(ConnectionState.Closed);
            }
            else
            {
                ConnectionStateUpdated?.Invoke(DbConnection.State);
            }  
        }
    }
}
