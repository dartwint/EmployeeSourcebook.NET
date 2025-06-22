using EmployeeSourcebook.DbAccess.Management.ConnectionChecker;
using System.Data;
using System.Data.Common;

namespace EmployeeSourcebook.DbAccess.Management
{
    public partial class ConnectionMonitor : IDbConnectionChecker
    {
        public bool IsRunning { get; private set; }

        public DbConnection DbConnection => _connection;

        public event Action<ConnectionState>? ConnectionAttempt;

        private DbConnection _connection;
        private CancellationTokenSource? _cts;
        private Task? _monitoringTask;
        private readonly object _lock = new();
        private int _retriesCount, _retriesCountLeft;

        public ConnectionMonitor(DbConnection connection)
        {
            _connection = connection;
        }

        public void Start(TimeSpan interval, int retriesCount = 0)
        {
            lock (_lock)
            {
                if (IsRunning)
                    throw new InvalidOperationException("Monitoring already started.");

                IsRunning = true;
                _retriesCount = retriesCount;
                _retriesCountLeft = retriesCount;
                
                _cts = new CancellationTokenSource();
                _monitoringTask = Task.Run(() => MonitorAsync(interval, _cts.Token));
            }
        }

        public void Stop()
        {
            lock (_lock)
            {
                _cts?.Cancel();
                _monitoringTask?.Wait();
                _cts?.Dispose();
                _cts = null;
                _monitoringTask = null;

                IsRunning = false;
            }
        }

        public void ChangeConnection(DbConnection connection)
        {
            Stop();

            _connection = connection;
        }

        public async Task<bool> TryConnectAsync(CancellationToken token = default)
        {
            try
            {
                await _connection.OpenAsync(token);
                return _connection.State == ConnectionState.Open;
            }
            catch
            {
                return false;
            }
        }

        public bool TryConnect()
        {
            try
            {
                _connection.Open();
                return _connection.State == ConnectionState.Open;
            }
            catch
            {
                return false;
            }
        }

        private async Task MonitorAsync(TimeSpan interval, CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                try
                {
                    bool isAlive = await TryConnectAsync(token);
                    if (!isAlive)
                        _retriesCountLeft--;
                    else
                        _retriesCountLeft = _retriesCount;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Monitor Error: {ex.Message}");
                }

                OnConnectionAttempt(DbConnection.State);

                try
                {
                    await Task.Delay(interval, token);
                }
                catch (TaskCanceledException)
                {
                    break;
                }

                if (_retriesCountLeft < 0)
                    break;
            }
        }

        private void OnConnectionAttempt(ConnectionState connectionState)
        {
            ConnectionAttempt?.Invoke(connectionState);
        }
    }
}
