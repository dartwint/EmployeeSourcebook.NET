using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSourcebook.Views
{
    internal class CustomTabControl
    {
        private HashSet<TableTab> _tabs = new();
        private TableTab? _selectedTab;

        public void AddTab(TableTab tab)
        {
            _tabs.Add(tab);
        }

        public void SelectTab(TableTab tab)
        {
            _selectedTab = tab;
        }
    }
}
