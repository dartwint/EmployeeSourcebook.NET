using EmployeeSourcebook.Properties;
using Microsoft.Data.Sqlite;

namespace EmployeeSourcebook.DbAccess.Management
{
    public class DummyDbAdminController
    {
        private readonly string _testSQLCommandPath = Resources.SqliteDbCreationCmdFile;
        private readonly string _SQLiteDbPath = Resources.SqliteDbFile;

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
