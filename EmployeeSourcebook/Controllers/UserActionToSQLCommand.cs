using Microsoft.Data.Sqlite;
using Npgsql;
using System.Data.Common;

namespace EmployeeSourcebook.Controllers
{
    public static class UserActionToSQLCommand
    {
        public static List<string>? GetDataFromTable(SQLExecutor executor, 
            DbConnection dbConnection, string tableName)
        {
            string? commandText = null;

            if (dbConnection is SqliteConnection sqliteConnection)
            {
                commandText = $"SELECT * FROM {tableName}";
            }

            if (dbConnection is NpgsqlConnection npsqlConnection)
            {
                commandText = $"SELECT * FROM {tableName}";
            }

            if (commandText == null)
            {
                return null;
            }

            return executor.Execute(dbConnection, commandText);
        }
    }
}
