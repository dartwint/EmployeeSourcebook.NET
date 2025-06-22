using EmployeeSourcebook.DbConnection.Model;

namespace EmployeeSourcebook.DbConnection.Management.ConnectionChecker
{
    public interface IDbConnectionCheckerFactory
    {
        IDbConnectionChecker CreateConnectionChecker(IConnectionInfo connectionInfo);
    }
}
