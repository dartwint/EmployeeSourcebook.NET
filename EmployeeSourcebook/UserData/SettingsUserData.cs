using EmployeeSourcebook.Properties;

namespace EmployeeSourcebook.UserData
{
    public class SettingsUserData
    {
        private static SettingsUserData? _default;

        public static SettingsUserData Default
        {
            get
            {
                if (_default == null) _default = new SettingsUserData();

                return _default;
            }
        }

        public static readonly string dataPath = Resources.SettingsUserDataXMLFile;

        public bool EnableConnectionPing { get; set; }
        public int ConnectionRetriesCount { get; set; }
        public TimeSpan ConnectionPingInterval { get; set; }

        public SettingsUserData()
        {
            EnableConnectionPing = true;
            ConnectionRetriesCount = 2;
            ConnectionPingInterval = new TimeSpan(0, 0, 3);
        }
    }
}
