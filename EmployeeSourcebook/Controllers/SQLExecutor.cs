using System.Data.Common;

namespace EmployeeSourcebook.Controllers
{
    public class SQLExecutor : ISQLExecutor<List<string>>
    {
        public List<string> Execute(DbConnection dbConnection, string commandText)
        {
            if (dbConnection == null || dbConnection.State != System.Data.ConnectionState.Open)
            {
                throw new Exception("Provided db connection instance is not opened");
            }

            List<string> result = new();

            var command = dbConnection.CreateCommand();
            command.CommandText = commandText;
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                result.Add(reader.GetString(0));
            }

            return result;
        }
    }
}
