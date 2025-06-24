using System.Data.Common;

namespace EmployeeSourcebook.Controllers
{
    public interface ISQLExecutor<TResult>
    {
        TResult? Execute(DbConnection dbConnection, string commandText);
        TResult? Execute(DbConnection dbConnection, string commandText, out Exception? exception);
    }
}