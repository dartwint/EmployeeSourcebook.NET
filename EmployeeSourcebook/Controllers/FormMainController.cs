using EmployeeSourcebook.DbAccess.Model.CommandRepository;
using EmployeeSourcebook.Views;
using System.Data;

namespace EmployeeSourcebook.Controllers
{
    internal class FormMainController
    {
        private FormMain _formMain;
        private FormConnection _formConnection;
        private FormSettings _formSettings;

        private ConnectionController _connectionController;

        public FormMainController(FormMain formMain, FormConnection formConnection, 
            FormSettings formSettings, ConnectionController connectionController)
        {
            _formMain = formMain;
            _formConnection = formConnection;
            _formSettings = formSettings;
            _connectionController = connectionController;

            _formMain.ButtonConnectionSettingsClick += ShowFormConnection;
            _formMain.ButtonSettingsClick += ShowFormSettings;
            _formConnection.FormClosed += OnFormConnectionClosed;
            _connectionController.ConnectionStateUpdated += UpdateStatusUI;

            _formMain.TableTabSelected += OnTableTabSelected;
        }

        private void UpdateStatusUI(ConnectionState connectionState)
        {
            if (_formMain.InvokeRequired)
                _formMain.BeginInvoke(() => _formMain.SetConnectionStateInfo(connectionState));
            else
                _formMain.SetConnectionStateInfo(connectionState);
        }

        private void OnFormConnectionClosed(object? sender, EventArgs e)
        {
            if (_connectionController.DbConnection == null)
                return;

            if (_connectionController.DbConnection.State == ConnectionState.Open)
            {
                _formMain.UpdateTablesTabs(CreateTabs());
            }
        }

        private void OnTableTabSelected(TableTab tab)
        {
            if (_connectionController.DbConnection == null || 
                _connectionController.DbConnection.State != ConnectionState.Open)
                return;

            string tableName = tab.Text;
            var data = UserActionToSQLCommand.GetDataFromTable(new SQLExecutor(),
                _connectionController.DbConnection, tableName);

            if (_formMain.InvokeRequired)
            {
                _formMain.Invoke(() => SetDataToGridView(_formMain.DataGridView, data));
            }
            else
            {
                SetDataToGridView(_formMain.DataGridView, data);
            }
        }

        private void SetDataToGridView(DataGridView dataGridView, object? data)
        {
            //dataGridView.DataSource = new BindingList<>();
            dataGridView.DataSource = data;
        }

        private void ShowFormSettings()
        {
            _formSettings.Show();
        }

        private void ShowFormConnection()
        {
            _formConnection.ShowDialog();
        }

        private void CreateTables()
        {
            if (_connectionController.DbConnection == null || 
                _connectionController.DbConnection.State != ConnectionState.Open)
                return;

            SQLCommandWrapper? cmdWrapper;
            if (MainController.sqlCommandsRegistry.TryGetCommand(
                _connectionController.DbConnection, MainController.createTablesKey, out cmdWrapper)
                && cmdWrapper != null)
            {
                string cmdText = cmdWrapper.CommandText;
                if (!string.IsNullOrEmpty(cmdText))
                {
                    var executor = new SQLExecutor();
                    executor.Execute(_connectionController.DbConnection, cmdText);
                }
            }
        }

        private List<TableTab>? CreateTabs()
        {
            if (_connectionController.DbConnection == null || 
                _connectionController.DbConnection.State != ConnectionState.Open)
                return null;

            SQLCommandWrapper? cmdWrapper;
            if (MainController.sqlCommandsRegistry.TryGetCommand(
                _connectionController.DbConnection, MainController.selectTablesKey, out cmdWrapper)
                && cmdWrapper != null)
            {
                string cmdText = cmdWrapper.CommandText;
                if (!string.IsNullOrEmpty(cmdText))
                {
                    var executor = new SQLExecutor();
                    var listExecResult = executor.Execute(_connectionController.DbConnection, cmdText);
                    List<TableTab> tabs = new();
                    foreach (var item in listExecResult)
                    {
                        tabs.Add(new TableTab(item));
                    }

                    return tabs;
                }
            }

            return null;
        }
    }
}
