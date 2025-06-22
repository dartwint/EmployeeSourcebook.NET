namespace EmployeeSourcebook.DbConnection.Model
{
    public class SQLiteConnectionBaseInfo : ISQLiteConnectionBaseInfo
    {
        public string DataSource { get; set; } = string.Empty;

        public virtual string GetConnectionString()
        {
            return $"Data Source={DataSource}";
        }

        public SQLiteConnectionBaseInfo(string dataSource)
        {
            DataSource = dataSource;
        }
    }
}
