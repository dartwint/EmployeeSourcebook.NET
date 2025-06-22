namespace EmployeeSourcebook.DbAccess.Model
{
    public interface ISQLiteConnectionBaseInfo : IConnectionInfo
    {
        string DataSource { get; set; }
    }
}
