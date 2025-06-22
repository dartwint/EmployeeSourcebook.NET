namespace EmployeeSourcebook.DbConnection.Model
{
    public interface ISQLiteConnectionBaseInfo : IConnectionInfo
    {
        string DataSource { get; set; }
    }
}
