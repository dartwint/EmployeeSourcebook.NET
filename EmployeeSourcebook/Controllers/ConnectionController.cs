using EmployeeSourcebook.DbAccess.Connection;
using EmployeeSourcebook.DbAccess.Management;
using EmployeeSourcebook.DbAccess.Model;
using EmployeeSourcebook.Views;
using System.Data;

namespace EmployeeSourcebook.Controllers
{
    internal class ConnectionController
    {
        private FormConnection _formConnection;
        private FormMain _formMain;
        private ConnectionMonitor? _connectionMonitor;

        //private DbConnection? _dbConnection;

        public ConnectionController(FormConnection formConnection, FormMain formMain)
        {
            _formConnection = formConnection;
            _formMain = formMain;

            _formConnection.ConnectionRequested += OnConnectionTestRequested;
            _formConnection.FormClosed += OnFormConnectionClosed;
            _formConnection.Load += OnFormConnectionOpened;
        }

        private void OnFormConnectionClosed(object? sender, FormClosedEventArgs e)
        {
            if (_connectionMonitor != null)
            {
                _connectionMonitor.ConnectionAttempt += UpdateFormMain;
                _connectionMonitor.Start(new TimeSpan(0, 0, 2), 2);
            }
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

            //var connectionCheckerFactory = new DbConnectionCheckerFactory();
            //var connectionMonitor = connectionCheckerFactory.CreateConnectionChecker(connection);
            _connectionMonitor = new ConnectionMonitor(connection);
            //_connectionMonitor.ConnectionAttempt += UpdateFormConnection;
            bool connectionResult = _connectionMonitor.TryConnect();
            if (connectionResult)
            {
                UpdateFormConnection(ConnectionState.Open);
            }
            else
            {
                UpdateFormConnection(ConnectionState.Broken);
            }
            //_connectionMonitor.Start(new TimeSpan(0, 0, 5));
        }

        //private void SaveConnection(DbConnection dbConnection)
        //{
        //    _dbConnection = dbConnection;
        //}

        private void UpdateFormConnection(ConnectionState connectionState)
        {
            _formConnection.SetConnectionStatus(connectionState);
        }

        private void UpdateFormMain(ConnectionState connectionState)
        {
            _formMain.SetConnectionStateInfo(connectionState);
        }
    }
}
