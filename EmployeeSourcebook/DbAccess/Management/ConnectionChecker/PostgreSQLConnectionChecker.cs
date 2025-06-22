using Npgsql;
using System.Data;
using System.Data.Common;

namespace EmployeeSourcebook.DbAccess.Management.ConnectionChecker
{
    //public class PostgreSQLConnectionChecker : IDbConnectionChecker
    //{
    //    private readonly string _connectionString;

    //    public PostgreSQLConnectionChecker(string connectionString)
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
    //            using var connection = new NpgsqlConnection(_connectionString);
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
    //        try
    //        {
    //            using var connection = new NpgsqlConnection(_connectionString);
    //            await connection.OpenAsync(token);
    //            if (connection.State == ConnectionState.Open)
    //            {
    //                await Task.CompletedTask;
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show($"{ex.Message}", "Connection error", 
    //                MessageBoxButtons.OK, MessageBoxIcon.Error);
    //        }
    //    }
    //}
}
