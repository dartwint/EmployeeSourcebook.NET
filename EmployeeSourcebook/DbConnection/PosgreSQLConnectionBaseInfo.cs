namespace EmployeeSourcebook.DbConnection
{
    public class PosgreSQLConnectionBaseInfo : IPostgreSQLConnectionBaseInfo
    {
        public string Host { get; set; } = string.Empty;
        public string Port { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public virtual string GetConnectionString()
        {
            return string.Concat($"Host={Host};",
                $"Port={Port};", $"Username={Username};", $"Password={Password};");
        }

        public PosgreSQLConnectionBaseInfo(string host, string port, string username, string password)
        {
            Host = host;
            Port = port;
            Username = username;
            Password = password;
        }
    }
}
