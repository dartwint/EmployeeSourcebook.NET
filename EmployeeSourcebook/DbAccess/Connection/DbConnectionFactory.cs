using EmployeeSourcebook.DbAccess.Model;
using Microsoft.Data.Sqlite;
using Npgsql;
using System.Data.Common;

namespace EmployeeSourcebook.DbAccess.Connection
{
    public class DbConnectionFactory : IDbConnectionFactory
    {
        public DbConnection? Create(IConnectionInfo connectionInfo, out Exception? exception)
        {
            exception = null;

            try
            {
                if (connectionInfo is SQLiteConnectionBaseInfo sqliteConnection)
                {
                    //if (!File.Exists(sqliteConnection.DataSource))
                    //{
                    //    exception = new FileNotFoundException(
                    //        $"Incorrect SQLite connection string:\n" +
                    //        $"{connectionInfo.GetConnectionString()}");
                    //    return null;
                    //}

                    return new SqliteConnection(sqliteConnection.GetConnectionString());
                }

                if (connectionInfo is PosgreSQLConnectionBaseInfo npgsqlConnection)
                {
                    return new NpgsqlConnection(npgsqlConnection.GetConnectionString());
                }

                exception = new NotSupportedException(
                    $"Can not provide checker with given connection string:\n " +
                    $"{connectionInfo.GetConnectionString()}");
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            return null;
        }
    }
}
