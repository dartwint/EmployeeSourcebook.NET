namespace EmployeeSourcebook.DbConnection
{
    public class SQLiteConnectionBaseInfo : ISQLiteConnectionBaseInfo
    {
        public string DataSource { get; set; } = string.Empty;
        public virtual string ConnectionString { get; set; } = string.Empty;

        public SQLiteConnectionBaseInfo(string dataSource)
        {
            DataSource = dataSource;

            ConnectionString = dataSource;
        }
    }
}
