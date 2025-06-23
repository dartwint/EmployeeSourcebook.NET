using System.Data.Common;

namespace EmployeeSourcebook.Controllers
{
    public interface ISQLExecutor<TResult>
    {
        TResult? Execute(DbConnection dbConnection, string commandText);
    }
}
