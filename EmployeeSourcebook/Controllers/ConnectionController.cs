using EmployeeSourcebook.DbConnection.Management;
using EmployeeSourcebook.DbConnection.Management.ConnectionChecker;
using EmployeeSourcebook.DbConnection.Model;
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
        private ConnectionMonitor? _connectionMonitor;

        private PosgreSQLConnectionBaseInfo _PostgreSQLConnectionDefaultInfo;
        private SQLiteConnectionBaseInfo _SQLiteConnectionDefaultInfo;

        public ConnectionController(FormConnection formConnection)
        {
            _formConnection = formConnection;

            _formConnection.ConnectionChanged += OnConnectionTestRequested;

            _SQLiteConnectionDefaultInfo = new SQLiteConnectionBaseInfo(
                dataSource: "SQLite/EmployeesSourcebook.db");

            _PostgreSQLConnectionDefaultInfo = new PosgreSQLConnectionBaseInfo(
                host: "localhost",
                port: "5432",
                username: "postgres",
                password: "masterkey",
                database: "postgres"
                );
        }

        private async void OnConnectionTestRequested(IConnectionInfo? connectionInfo)
        {
            if (connectionInfo == null)
                return;

            if (_connectionMonitor != null && _connectionMonitor.IsRunning)
            {
                _connectionMonitor.Stop();
                 await _connectionMonitor.CheckConnectionOnceAsync();
            }

            var connectionCheckerFactory = new DbConnectionCheckerFactory();
            _connectionMonitor = new ConnectionMonitor(
                connectionCheckerFactory.CreateConnectionChecker(connectionInfo));

            _connectionMonitor.ConnectionAttempt += OnConnectionAttempt;

            _connectionMonitor.Start(new TimeSpan(0, 0, 5));

            //MessageBox.Show(connectionInfo.GetConnectionString());
        }

        private void OnConnectionAttempt(ConnectionResult connectionResult)
        {

        }
    }
}
