using EmployeeSourcebook.Properties;

namespace EmployeeSourcebook.DbAccess.Model
{
    public static class SQLCommandsSingletonRepository
    {
        public static readonly string SQLiteCommandTextCreateTables = Resources.SQLiteDatabaseCreationCommandFile;
        public static readonly string SQLiteCommandTextListTables = Resources.SQLiteListTablesCommand;

        public static readonly string PostgreSQLTextCreateTables = Resources.PostgreSQLDatabaseCreationCommandFile;
        public static readonly string PostgreSQLTextListTables = Resources.PostgreSQLListTablesCommand;
    }
}
