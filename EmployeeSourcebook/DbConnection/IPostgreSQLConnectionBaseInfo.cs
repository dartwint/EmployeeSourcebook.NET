namespace EmployeeSourcebook.DbConnection
{
    public interface IPostgreSQLConnectionBaseInfo : IConnectionInfo
    {
        string Host { get; set; }
        string Port { get; set; }
        string Username { get; set; }
        string Password { get; set; }
    }
}
