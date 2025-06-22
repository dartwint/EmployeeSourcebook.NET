using EmployeeSourcebook.DbConnection.Model;

namespace EmployeeSourcebook.DbConnection.Management.ConnectionChecker
{
    public class DbConnectionCheckerFactory : IDbConnectionCheckerFactory
    {
        public IDbConnectionChecker CreateConnectionChecker(IConnectionInfo connectionInfo)
        {
            if (connectionInfo is SQLiteConnectionBaseInfo)
            {
                return new SqliteConnectionChecker(connectionInfo.GetConnectionString());
            }

            if (connectionInfo is PosgreSQLConnectionBaseInfo)
            {
                return new PostgreSQLConnectionChecker(connectionInfo.GetConnectionString());
            }

            throw new NotSupportedException(
                $"Can not provide checker with given {nameof(connectionInfo)}");
        }
    }
}
