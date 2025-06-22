using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSourcebook.DbAccess.Management
{
    public class DummyDbAdminController
    {
        private const string _testSQLCommandPath = "SQL queries/SQLite/Test.sql";
        private const string _SQLiteDbPath = "SQLite/EmployeesSourcebook.db";

        //private ConnectionMonitor _connectionMonitor;

        public DummyDbAdminController()
        {
            //_connectionMonitor = new ConnectionMonitor();

            if (!File.Exists(_testSQLCommandPath))
            {
                throw new Exception($"No file at path: {_testSQLCommandPath}");
            }

            var dir = Path.GetDirectoryName(_SQLiteDbPath);
            if (dir == null)
            {
                throw new Exception("Aboba");
            }

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }

        public void SQLiteTestExecute()
        {
            using var connection = new SqliteConnection($"Data Source={_SQLiteDbPath}");
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = File.ReadAllText(_testSQLCommandPath);
            command.ExecuteNonQuery();
        }

        public void PostgreSQLTestExecute()
        {

        }
    }
}
