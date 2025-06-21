namespace EmployeeSourcebook
{
    internal static class EntryPoint
    {
        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new ApplicationBootstrapper().Initialize());
        }
    }
}