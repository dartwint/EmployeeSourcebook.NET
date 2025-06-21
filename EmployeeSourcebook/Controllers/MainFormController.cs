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

        public MainFormController(FormMain formMain, FormConnection formConnection)
        {
            _formMain = formMain;
            _formConnection = formConnection;
        }

        private void ShowFormConnection()
        {
            _formConnection.ShowDialog();
        }
    }
}
