using EmployeeSourcebook.DbAccess.Model;
using System.Data.Common;

namespace EmployeeSourcebook.DbAccess.Connection
{
    public interface IDbConnectionFactory
    {
        DbConnection? Create(IConnectionInfo connectionInfo, out Exception? exception);
    }
}
