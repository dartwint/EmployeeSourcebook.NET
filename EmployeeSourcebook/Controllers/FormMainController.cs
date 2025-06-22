using EmployeeSourcebook.DbConnection.Management;
using EmployeeSourcebook.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSourcebook.Controllers
{
    internal class FormMainController
    {
        private FormMain _formMain;
        private FormConnection _formConnection;
        private FormSettings _formSettings;

        private ConnectionController _connectionController;

        public FormMainController(FormMain formMain, FormConnection formConnection, 
            FormSettings formSettings, ConnectionController connectionController)
        {
            _formMain = formMain;
            _formConnection = formConnection;
            _formSettings = formSettings;
            _connectionController = connectionController;

            _formMain.ButtonConnectionSettingsClick += ShowFormConnection;
            _formMain.ButtonSettingsClick += ShowFormSettings;

            Test();
        }

        private void Test()
        {
            var dummyDbAdmin = new DummyDbAdminController();
            dummyDbAdmin.SQLiteTestExecute();
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
