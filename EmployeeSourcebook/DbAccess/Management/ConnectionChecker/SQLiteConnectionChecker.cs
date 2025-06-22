using Microsoft.Data.Sqlite;
using System.Data;
using System.Data.Common;

namespace EmployeeSourcebook.DbAccess.Management.ConnectionChecker
{
    //public class SqliteConnectionChecker : IDbConnectionChecker
    //{
    //    private readonly string _connectionString;

    //    public SqliteConnectionChecker(string connectionString)
    //    {
    //        _connectionString = connectionString;
    //    }

    //    public DbConnection DbConnection 
    //    { 
    //        get => throw new NotImplementedException();
    //        set => throw new NotImplementedException();
    //    }

    //    public async Task<bool> IsConnectionAliveAsync(CancellationToken token)
    //    {
    //        try
    //        {
    //            using var connection = new SqliteConnection(_connectionString);
    //            await connection.OpenAsync(token);
    //            return connection.State == ConnectionState.Open;
    //        }
    //        catch
    //        {
    //            return false;
    //        }
    //    }

    //    public async Task TryReconnectAsync(CancellationToken token)
    //    {
    //        if (!File.Exists(new SqliteConnectionStringBuilder(_connectionString).DataSource))
    //        {
    //            MessageBox.Show("SQLite file not found.", "", 
    //                MessageBoxButtons.OK, MessageBoxIcon.Warning);
    //        }
    //        else
    //        {
    //            MessageBox.Show("SQLite file exists, reconnect not needed.", "", 
    //                MessageBoxButtons.OK, MessageBoxIcon.Information);
    //        }

    //        await Task.CompletedTask;
    //    }
    //}
}
