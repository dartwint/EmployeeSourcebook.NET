namespace EmployeeSourcebook.DbConnection
{
    public interface ISQLiteConnectionBaseInfo : IConnectionInfo
    {
        string DataSource { get; set; }
    }
}
