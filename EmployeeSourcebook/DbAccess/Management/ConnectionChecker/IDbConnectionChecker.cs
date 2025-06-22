using System.Data.Common;

namespace EmployeeSourcebook.DbAccess.Management.ConnectionChecker
{
    public interface IDbConnectionChecker
    {
        //Task<bool> IsConnectionAliveAsync(CancellationToken token);
        //Task TryReconnectAsync(CancellationToken token);
        Task<bool> TryConnectAsync(CancellationToken token);

        DbConnection DbConnection { get; }
    }
}
