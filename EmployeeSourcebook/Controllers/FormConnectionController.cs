using EmployeeSourcebook.DbAccess.Model;
using EmployeeSourcebook.UserData;
using EmployeeSourcebook.Views;
using System.Data;

namespace EmployeeSourcebook.Controllers
{
    public class FormConnectionController
    {
        private FormConnection _formConnection;
        private ConnectionController _connectionController;

        public FormConnectionController(FormConnection formConnection, ConnectionController connectionController)
        {
            _formConnection = formConnection;
            _connectionController = connectionController;

            _formConnection.ConnectionRequested += OnConnectionTestRequested;
            _formConnection.CloseRequested += OnFormCloseRequest;
            //_formConnection.Load += OnFormLoad;
            _formConnection.UserDataSaveRequested += OnUserDataSaveRequested;

            _connectionController.ConnectionStateUpdated += UpdateStatusUI;

            OnUserDataLoad();
        }

        private void OnUserDataSaveRequested()
        {
            if (_formConnection.UserData == null)
                return;

            UserDataManager.SaveData(_formConnection.UserData, ConnectionUserData.dataPath);
        }

        private void OnUserDataLoad()
        {
            _formConnection.UserData = UserDataManager.LoadData<ConnectionUserData>(ConnectionUserData.dataPath);
        }

        private void OnConnectionTestRequested(IConnectionInfo? connectionInfo)
        {
            _formConnection.UpdateConnectionStatus(ConnectionState.Connecting);

            _connectionController.TryConfigureConnection(connectionInfo);
        }

        //private void OnFormLoad(object? sender, EventArgs e)
        //{

        //}

        private void UpdateStatusUI(ConnectionState connectionState)
        {
            if (_formConnection.InvokeRequired)
                _formConnection.BeginInvoke(() => _formConnection.UpdateConnectionStatus(connectionState));
            else
                _formConnection.UpdateConnectionStatus(connectionState);
        }

        private void OnFormCloseRequest()
        {
            _formConnection.Close();
        }
    }
}
