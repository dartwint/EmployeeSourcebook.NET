using EmployeeSourcebook.DbAccess.Model;
using EmployeeSourcebook.Properties;
using static EmployeeSourcebook.Views.FormConnection;

namespace EmployeeSourcebook.Models
{
    public class ConnectionUserData
    {
        private static ConnectionUserData? _default;

        public static ConnectionUserData Default
        {
            get
            {
                if (_default == null) _default = new ConnectionUserData();

                return _default;
            }
        }

        public static readonly string dataPath = Resources.ConnectionUserDataXMLPath;

        public DbProvider SelectedProvider { get; set; }
        public PosgreSQLConnectionBaseInfo PosgreSQLConnectionInfo { get; set; }
        public SQLiteConnectionBaseInfo SQLiteConnectionInfo { get; set; }

        public ConnectionUserData()
        {
            SelectedProvider = DbProvider.None;

            PosgreSQLConnectionInfo = new PosgreSQLConnectionBaseInfo(
                host: "localhost",
                port: "5432",
                username: "postgres",
                password: "masterkey",
                database: "postgres"
                );

            SQLiteConnectionInfo = new SQLiteConnectionBaseInfo(
                dataSource: Resources.SQLiteDbPath);
        }
    }
}
