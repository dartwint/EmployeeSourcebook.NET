using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSourcebook.Domain
{
    public interface IMainView
    {
        event Action? ButtonConnectionSettingsClick;
        //event Action<Button>? ButtonNextTableClick;
        //event Action<Button>? ButtonPreviousTableClick;
    }
}
