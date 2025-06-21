using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSourcebook.DbConnection
{
    internal class PosgreSQLConnectionBaseInfo : IPostgreSQLConnectionBaseInfo
    {
        public string Host { get; set; } = string.Empty;
        public string Port { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public virtual string ConnectionString { get; set; } = string.Empty;
    }
}
