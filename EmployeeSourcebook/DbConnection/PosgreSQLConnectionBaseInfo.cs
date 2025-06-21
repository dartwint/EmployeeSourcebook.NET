namespace EmployeeSourcebook.DbConnection
{
    internal class PosgreSQLConnectionBaseInfo : IPostgreSQLConnectionBaseInfo
    {
        public string Host { get; set; } = string.Empty;
        public string Port { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public virtual string ConnectionString { get; set; } = string.Empty;

        public PosgreSQLConnectionBaseInfo(string host, string port, string username, string password)
        {
            Host = host;
            Port = port;
            Username = username;
            Password = password;

            ConnectionString = string.Concat(host, port, username, password);
        }
    }
}
