namespace EmployeeSourcebook.DbConnection.Management.ConnectionChecker
{
    public interface IDbConnectionChecker
    {
        Task<bool> IsConnectionAliveAsync(CancellationToken token);
        Task TryReconnectAsync(CancellationToken token);
    }
}
