using EmployeeSourcebook.DbAccess.Model.CommandRepository;
using Microsoft.Data.Sqlite;
using Npgsql;
using System.Data;
using System.Data.Common;

namespace EmployeeSourcebook.Controllers
{
    public static class DbAdminManager
    {
        public static List<string>? GetDataFromTable(SQLExecutor executor, 
            DbConnection dbConnection, string tableName, out Exception? exception)
        {
            exception = null;
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

        public static List<string>? ExecuteCommandByKey(SQLExecutor executor,
            DbConnection dbConnection, SQLCommandKey commandKey, out Exception? ex)
        {
            ex = null;
            if (dbConnection == null || dbConnection.State != ConnectionState.Open)
                return null;

            try
            {
                SQLCommandWrapper? cmdWrapper;
                if (MainController.sqlCommandsRegistry.TryGetCommand(
                    dbConnection, commandKey, out cmdWrapper)
                    && cmdWrapper != null)
                {
                    string cmdText = cmdWrapper.CommandText;
                    if (!string.IsNullOrEmpty(cmdText))
                    {
                        return executor.Execute(dbConnection, cmdText);
                    }
                }
            }
            catch (Exception exception)
            {
                ex = exception;
            }

            return null;
        }

        public static void WriteDummyData(SQLExecutor executor, DbConnection dbConnection,
            out Exception? ex)
        {
            ex = null;
            if (dbConnection == null || dbConnection.State != ConnectionState.Open)
                return;

            try
            {
                SQLCommandWrapper? cmdWrapper;
                if (MainController.sqlCommandsRegistry.TryGetCommand(
                    dbConnection, MainController.insertDummyRecordsKey, out cmdWrapper)
                    && cmdWrapper != null)
                {
                    string cmdText = cmdWrapper.CommandText;
                    if (!string.IsNullOrEmpty(cmdText))
                    {
                        executor.Execute(dbConnection, cmdText);
                    }
                }
            }
            catch (Exception exception)
            {
                ex = exception;
            }
        }

        public static void CreateTables(SQLExecutor executor, DbConnection dbConnection,
            out Exception? ex)
        {
            ex = null;
            if (dbConnection == null || dbConnection.State != ConnectionState.Open)
                return;

            try
            {
                SQLCommandWrapper? cmdWrapper;
                if (MainController.sqlCommandsRegistry.TryGetCommand(
                    dbConnection, MainController.createTablesKey, out cmdWrapper)
                    && cmdWrapper != null)
                {
                    string cmdText = cmdWrapper.CommandText;
                    if (!string.IsNullOrEmpty(cmdText))
                    {
                        executor.Execute(dbConnection, cmdText);
                    }
                }
            }
            catch (Exception exception)
            {
                ex = exception;
            }
        }
    }
}
