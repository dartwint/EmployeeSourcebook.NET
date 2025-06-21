using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSourcebook.Controllers
{
    internal class CustomTabController
    {
        private List<TableTab> _tabs = new();

        private void AddTab(TableTab tab)
        {
            _tabs.Add(tab);
        }
    }

    internal class TableTab : Button
    {
        public event Action<TableTab>? TabSelected;

        private void OnTabSelected()
        {
            TabSelected?.Invoke(this);
        }
    }
}
