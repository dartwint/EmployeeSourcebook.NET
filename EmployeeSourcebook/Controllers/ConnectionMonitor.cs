using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSourcebook.Controllers
{
    internal class ConnectionMonitor
    {
        private CancellationTokenSource? _cancellationToken;

        public async Task StartMonitorAsync(TimeSpan interval, CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                //bool isAlive = await IsConnectionAliveAsync(token);
                bool isAlive = true;
                if (!isAlive)
                {
                    await TryReconnectAsync(token);
                }

                await Task.Delay(interval, token);
            }
        }

        //public async Task<bool> IsConnectionAliveAsync(CancellationToken token)
        //{
            
        //}

        public async Task TryReconnectAsync(CancellationToken token)
        {

        }
    }
}
