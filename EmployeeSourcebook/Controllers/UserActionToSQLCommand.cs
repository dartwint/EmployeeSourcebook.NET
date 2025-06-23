using EmployeeSourcebook.Views;
using Microsoft.Data.Sqlite;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
