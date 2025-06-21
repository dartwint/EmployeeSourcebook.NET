namespace EmployeeSourcebook.DbConnection
{
    public interface ISQLiteConnectionBaseInfo : IConnectionInfo
    {
        string DataSource { get; set; }
    }

    public class SQLiteConnectionBaseInfo : ISQLiteConnectionBaseInfo
    {
        public string DataSource { get; set; } = string.Empty;
        public virtual string ConnectionString { get; set; } = string.Empty;
    }
}
