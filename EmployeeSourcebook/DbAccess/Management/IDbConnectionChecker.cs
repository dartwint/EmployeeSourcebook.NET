using System.Data.Common;

namespace EmployeeSourcebook.DbAccess.Management
{
    public interface IDbConnectionChecker
    {
        Task<bool> TryConnectAsync(CancellationToken token);

        DbConnection? DbConnection { get; }
    }
}
