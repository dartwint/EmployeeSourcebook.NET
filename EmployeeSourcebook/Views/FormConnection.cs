using EmployeeSourcebook.DbAccess.Model;
using EmployeeSourcebook.Domain;
using EmployeeSourcebook.UserData;
using System.Data;

namespace EmployeeSourcebook.Views
{
    public partial class FormConnection : Form, IConnectionView
    {
        public enum DbProvider
        {
            SQLite, PosgreSQL, None
        }

        public IConnectionInfo? ConnectionInfo { get; private set; }
        public event Action<IConnectionInfo?>? ConnectionInfoChanged;
        public event Action<IConnectionInfo?>? ConnectionRequested;

        public event Action? UserDataSaveRequested;
        public event Action? CloseRequested;

        public ConnectionUserData? UserData
        {
            get
            {
                return _userData;
            }
            set
            {
                _userData = value;
                OnUserDataLoaded();
            }
        }

        private DbProvider _selectedDbProvider = DbProvider.None;
        private Dictionary<DbProvider, Control> _containersMap = new();

        private Color _buttonSaveOrigColor;

        private ConnectionUserData? _userData;

        public FormConnection()
        {
            InitializeComponent();

            //var providers = Enum.GetValues(typeof(DbProvider));
            comboBoxDbProvider.Items.Add(DbProvider.SQLite);
            comboBoxDbProvider.Items.Add(DbProvider.PosgreSQL);
            comboBoxDbProvider.SelectedItem = null;

            _containersMap.Add(DbProvider.SQLite, panelSQLite);
            _containersMap.Add(DbProvider.PosgreSQL, panelPostgreSQL);

            _buttonSaveOrigColor = buttonSaveAndClose.BackColor;
            buttonSaveAndClose.Enabled = false;
            buttonSaveAndClose.BackColor = Color.DarkGray;
        }

        public void LockOnConnection()
        {
            buttonTestConnection.Enabled = false;
            Cursor = Cursors.WaitCursor;
        }

        public void UnlockOnConnection()
        {
            buttonTestConnection.Enabled = true;
            Cursor = Cursors.Default;
        }

        public void UpdateConnectionStatus(ConnectionState connectionState)
        {
            switch (connectionState)
            {
                case ConnectionState.Closed:
                    {
                        labelConnectionStatus.Text = "none";
                        labelConnectionStatus.ForeColor = Color.Black;
                        break;
                    }
                case ConnectionState.Connecting:
                    {
                        labelConnectionStatus.Text = "Connecting";
                        labelConnectionStatus.ForeColor = Color.Blue;
                        break;
                    }
                case ConnectionState.Open:
                    {
                        labelConnectionStatus.Text = "Connected";
                        labelConnectionStatus.ForeColor = Color.Green;

                        buttonSaveAndClose.Enabled = true;
                        buttonSaveAndClose.BackColor = _buttonSaveOrigColor;
                        break;
                    }
                case ConnectionState.Broken:
                    {
                        labelConnectionStatus.Text = "Error";
                        labelConnectionStatus.ForeColor = Color.Red;
                        break;
                    }
            }
        }

        private void OnUserDataLoaded()
        {
            if (_userData == null)
                _userData = new();

            _selectedDbProvider = _userData.SelectedProvider;
            if (_selectedDbProvider != DbProvider.None)
                comboBoxDbProvider.SelectedItem = _userData.SelectedProvider;
            _selectedDbProvider = _userData.SelectedProvider;
            textBoxFileSource.Text = _userData.SQLiteConnectionInfo.DataSource;
            textBoxHost.Text = _userData.PosgreSQLConnectionInfo.Host;
            textBoxPort.Text = _userData.PosgreSQLConnectionInfo.Port;
            textBoxUsername.Text = _userData.PosgreSQLConnectionInfo.Username;
            textBoxPassword.Text = _userData.PosgreSQLConnectionInfo.Password;
            textBoxDatabase.Text = _userData.PosgreSQLConnectionInfo.Database;

            ShowAvailableFields();
        }

        private void OnUserDataSaveRequest()
        {
            if (_userData == null)
                _userData = new();

            _userData.SelectedProvider = _selectedDbProvider;
            _userData.SQLiteConnectionInfo = new SQLiteConnectionBaseInfo(textBoxFileSource.Text);
            _userData.PosgreSQLConnectionInfo = new PosgreSQLConnectionBaseInfo(
                host: textBoxHost.Text,
                port: textBoxPort.Text,
                username: textBoxUsername.Text,
                password: textBoxPassword.Text,
                database: textBoxDatabase.Text
                );

            UserDataSaveRequested?.Invoke();
        }

        private void comboBoxcomboBoxDbProvider_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxDbProvider.SelectedItem != null)
            {
                _selectedDbProvider = (DbProvider) comboBoxDbProvider.SelectedItem;
                buttonTestConnection.Enabled = true;
            }
            else
            {
                buttonTestConnection.Enabled = false;
            }

            ShowAvailableFields();
        }

        private void ShowAvailableFields()
        {
            foreach (var control in _containersMap.Values)
            {
                control.Hide();
            }

            if (_selectedDbProvider != DbProvider.None)
            {
                tableLayoutPanelConnectionFieldsRoot.SetRow(_containersMap[_selectedDbProvider], 1);
                _containersMap[_selectedDbProvider].Show();

                buttonTestConnection.Enabled = true;
            }
        }

        private void UpdateConnectionInfo(out bool connectionChanged)
        {
            IConnectionInfo? newConnectionInfo = null;
            connectionChanged = false;

            switch (_selectedDbProvider)
            {
                case DbProvider.SQLite:
                    {
                        newConnectionInfo = new SQLiteConnectionBaseInfo(textBoxFileSource.Text);
                        break;
                    }
                case DbProvider.PosgreSQL:
                    {
                        newConnectionInfo = new PosgreSQLConnectionBaseInfo(
                            host: textBoxHost.Text,
                            port: textBoxPort.Text,
                            username: textBoxUsername.Text,
                            password: textBoxPassword.Text,
                            database: textBoxDatabase.Text
                            );
                        break;
                    }
                default:
                    {
                        MessageBox.Show($"Database provider {_selectedDbProvider} " +
                            $"is not implemented");
                        break;
                    }
            }

            if (newConnectionInfo != null)
            {
                if (ConnectionInfo == null || newConnectionInfo.GetConnectionString() !=
                    ConnectionInfo.GetConnectionString())
                {
                    ConnectionInfo = newConnectionInfo;
                    connectionChanged = true;
                }
            }
            else if (ConnectionInfo != null)
            {
                ConnectionInfo = newConnectionInfo;
                connectionChanged = true;
            }
        }

        private void buttonTestConnection_Click(object sender, EventArgs e)
        {
            if (comboBoxDbProvider.SelectedItem == null)
            {
                return;
            }

            UpdateConnectionInfo(out bool connectionChanged);
            if (connectionChanged)
                OnConnectionInfoChanged();

            ConnectionRequested?.Invoke(ConnectionInfo);
        }

        private void OnConnectionInfoChanged()
        {
            ConnectionInfoChanged?.Invoke(ConnectionInfo);
        }

        private void buttonSaveAndClose_Click(object sender, EventArgs e)
        {
            OnUserDataSaveRequest();

            CloseRequested?.Invoke();
        }

        private void buttonSelectFileSource_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog();
            fileDialog.Filter = "SQLite database file|*.db";
            var dialogResult = fileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                textBoxFileSource.Text = fileDialog.FileName;
            }
        }
    }
}
