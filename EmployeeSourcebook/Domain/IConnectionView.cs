﻿using EmployeeSourcebook.DbAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSourcebook.Domain
{
    internal interface IConnectionView
    {
        IConnectionInfo? ConnectionInfo { get; }
    }
}
