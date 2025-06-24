using System.Data.Common;

namespace EmployeeSourcebook.DbAccess.Model.CommandRepository
{
    public class SQLCommandsRepository<TDbConnection> : ISQLCommandsRepository
        where TDbConnection : DbConnection
    {
        private readonly Dictionary<SQLCommandKey, SQLCommandWrapper> _commands = new();

        public bool AddCommand(SQLCommandKey key, SQLCommandWrapper commandWrapper)
        {
            if (_commands.ContainsKey(key))
                return false;

            _commands[key] = commandWrapper;
            return true;
        }

        public bool TryGetCommand(SQLCommandKey key, out SQLCommandWrapper? commandWrapper)
        {
            return _commands.TryGetValue(key, out commandWrapper);
        }
    }
}
