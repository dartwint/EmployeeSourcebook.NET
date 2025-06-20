using EmployeeSourcebook.Views;

namespace EmployeeSourcebook
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormConnection());
        }
    }
}