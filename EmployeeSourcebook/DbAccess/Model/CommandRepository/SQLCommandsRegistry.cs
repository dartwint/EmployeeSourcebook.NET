using System.Data.Common;

namespace EmployeeSourcebook.DbAccess.Model.CommandRepository
{
    public class SQLCommandsRegistry
    {
        private readonly Dictionary<Type, ISQLCommandsRepository> _repositories = new();

        public void RegisterRepository<TDbConnection>(SQLCommandsRepository<TDbConnection> repo)
            where TDbConnection : DbConnection
        {
            _repositories[typeof(TDbConnection)] = repo;
        }

        public bool AddCommand<TDbConnection>(SQLCommandKey key, SQLCommandWrapper commandWrapper) 
            where TDbConnection : DbConnection
        {
            var connType = typeof(TDbConnection);
            if (!_repositories.ContainsKey(connType))
            {
                _repositories.Add(connType, new SQLCommandsRepository<TDbConnection>());
            }

            return _repositories[connType].AddCommand(key, commandWrapper);
        }

        public bool TryGetCommand(DbConnection connection, SQLCommandKey key, 
            out SQLCommandWrapper? commandWrapper)
        {
            var connType = connection.GetType();
            if (_repositories.TryGetValue(connType, out var repository))
            {
                return repository.TryGetCommand(key, out commandWrapper);
            }

            commandWrapper = null;
            return false;
        }
    }
}
