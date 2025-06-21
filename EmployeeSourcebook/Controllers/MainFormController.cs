using EmployeeSourcebook.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSourcebook.Controllers
{
    internal class MainFormController
    {
        private FormMain _formMain;
        private FormConnection _formConnection;
        private FormSettings _formSettings;

        public MainFormController(FormMain formMain, FormConnection formConnection, 
            FormSettings formSettings)
        {
            _formMain = formMain;
            _formConnection = formConnection;
            _formSettings = formSettings;

            _formMain.ButtonConnectionSettingsClick += ShowFormConnection;
            _formMain.ButtonSettingsClick += ShowFormSettings;
        }

        private void ShowFormSettings()
        {
            _formSettings.Show();
        }

        private void ShowFormConnection()
        {
            _formConnection.ShowDialog();
        }
    }
}
