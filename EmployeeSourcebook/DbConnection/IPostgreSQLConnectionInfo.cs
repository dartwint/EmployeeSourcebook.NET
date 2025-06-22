namespace EmployeeSourcebook.DbConnection
{
    public interface IPostgreSQLConnectionInfo : IPostgreSQLConnectionBaseInfo
    {
        string Database { get; set; }
    }

    public class PosgreSQLConnectionInfo : PosgreSQLConnectionBaseInfo
    {
        public string Database { get; set; } = string.Empty;

        public override string GetConnectionString()
        {
            return string.Concat($"Host={Host};", 
                $"Port={Port};", $"Username={Username};", $"Password={Password};", $"Database={Database};");
        }

        public PosgreSQLConnectionInfo(string host, string port, 
            string username, string password, string database) : base(host, port, username, password)
        {
            Database = database;
        }
    }
}
