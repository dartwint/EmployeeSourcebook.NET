using EmployeeSourcebook.Controllers;
using EmployeeSourcebook.Domain;
using EmployeeSourcebook.Views;

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

            var mainController = new MainController(_mainForm, formConnection, formSettings);
        }

        public Form Initialize()
        {
            return _mainForm;
        }
    }
}
