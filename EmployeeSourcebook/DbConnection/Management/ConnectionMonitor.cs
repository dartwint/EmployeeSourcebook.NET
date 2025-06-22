using EmployeeSourcebook.DbConnection.Management.ConnectionChecker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSourcebook.DbConnection.Management
{
    public partial class ConnectionMonitor
    {
        public bool IsRunning { get; private set; }

        public event Action<ConnectionResult>? ConnectionAttempt;

        private ConnectionStatusStateMachine? _stateMachine;
        private IDbConnectionChecker _connectionChecker;
        private CancellationTokenSource? _cts;
        private Task? _monitoringTask;
        private readonly object _lock = new();

        public ConnectionMonitor(IDbConnectionChecker connectionChecker)
        {
            _connectionChecker = connectionChecker;
        }

        public void AttachStateMachine(ConnectionStatusStateMachine stateMachine)
        {
            _stateMachine = stateMachine;
        }

        public void Start(TimeSpan interval)
        {
            lock (_lock)
            {
                if (IsRunning)
                    throw new InvalidOperationException("Monitoring already started.");

                IsRunning = true;
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

        public void ChangeChecker(IDbConnectionChecker newChecker)
        {
            lock (_lock)
            {
                _connectionChecker = newChecker;
            }
        }

        public async Task<bool> CheckConnectionOnceAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                return await _connectionChecker.IsConnectionAliveAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection check error: {ex.Message}");
                return false;
            }
        }

        private async Task MonitorAsync(TimeSpan interval, CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                try
                {
                    bool isAlive = await _connectionChecker.IsConnectionAliveAsync(token);
                    if (!isAlive)
                        await _connectionChecker.TryReconnectAsync(token);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Monitor Error: {ex.Message}");
                }

                try
                {
                    await Task.Delay(interval, token);
                }
                catch (TaskCanceledException)
                {
                    break;
                }
            }
        }

        private void OnConnectionAttempt(ConnectionResult connectionResult)
        {
            ConnectionAttempt?.Invoke(connectionResult);
        }
    }
}
