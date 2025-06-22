using EmployeeSourcebook.DbAccess.Model;

namespace EmployeeSourcebook.DbAccess.Management
{
    public enum ConnectionStatus
    {
        Connected, LostConnection, Disconnected, Reconnected, None
    }

    public class ConnectionStatusStateMachine
    {
        public ConnectionStatus ConnectionStatus { get; private set; }

        private IConnectionInfo _connectionInfo;
        private Dictionary<ConnectionStatus, Dictionary<ConnectionStatus, List<Func<bool>>>>
            _transitionsMap = new();

        public ConnectionStatusStateMachine(IConnectionInfo connectionInfo)
        {
            _connectionInfo = connectionInfo;
            ConnectionStatus = ConnectionStatus.None;
        }

        public void AddTransition(ConnectionStatus connectionStatusFrom,
            ConnectionStatus connectionStatusTo, Func<bool> condition)
        {
            if (_transitionsMap == null)
                _transitionsMap = new();

            if (!_transitionsMap.ContainsKey(connectionStatusFrom))
            {
                _transitionsMap.Add(connectionStatusFrom, new());
                _transitionsMap[connectionStatusFrom].Add(connectionStatusTo, new());
            }

            _transitionsMap[connectionStatusFrom][connectionStatusTo].Add(condition);
        }

        public void Reset(IConnectionInfo connectionInfo)
        {
            _connectionInfo = connectionInfo;
            ConnectionStatus = ConnectionStatus.None;
        }

        public void Update()
        {
            if (!_transitionsMap.ContainsKey(ConnectionStatus) || _transitionsMap[ConnectionStatus].Count == 0)
            {
                throw new InvalidOperationException($"Next connection status is undefined");
            }

            foreach (var kvp in _transitionsMap[ConnectionStatus])
            {
                if (kvp.Key == ConnectionStatus)
                    continue;

                if (kvp.Value.Count == 0)
                {
                    throw new InvalidOperationException($"Inappropriate connection status " +
                        $"transitions setup. Developer should " +
                        $"use {nameof(AddTransition)} method to add transitions.");
                }

                foreach (var condition in kvp.Value)
                {
                    if (condition.Invoke()) ConnectionStatus = kvp.Key;
                }
            }
        }
    }
}
