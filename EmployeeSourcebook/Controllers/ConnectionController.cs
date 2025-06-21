using EmployeeSourcebook.DbConnection;
using EmployeeSourcebook.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSourcebook.Controllers
{
    internal class ConnectionController
    {
        private FormConnection _formConnection;
        private ConnectionMonitor _connectionMonitor;

        public ConnectionController(ConnectionMonitor connectionMonitor, FormConnection formConnection)
        {
            _formConnection = formConnection;
            _connectionMonitor = connectionMonitor;

            _formConnection.ConnectionChanged += OnConnectionTestRequested;
        }

        private void OnConnectionTestRequested(IConnectionInfo? connectionInfo)
        {
            if (connectionInfo == null)
                return;

            MessageBox.Show(connectionInfo.ConnectionString);
        }
    }
}
