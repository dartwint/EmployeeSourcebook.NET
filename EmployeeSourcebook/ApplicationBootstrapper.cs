using EmployeeSourcebook.Controllers;
using EmployeeSourcebook.DbAccess.Management;
using EmployeeSourcebook.Domain;
using EmployeeSourcebook.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSourcebook
{
    internal class ApplicationBootstrapper
    {
        private FormMain _mainForm;

        public ApplicationBootstrapper()
        {
            _mainForm = new FormBaseFactory<FormMain>().Create();
            var formConnection = new FormBaseFactory<FormConnection>().Create();
            var formSettings = new FormBaseFactory<FormSettings>().Create();

            var connectionController = new ConnectionController(formConnection, _mainForm);

            var mainController = new FormMainController(
                _mainForm,
                formConnection,
                formSettings,
                connectionController
                );
        }

        public Form Initialize()
        {
            return _mainForm;
        }
    }
}
