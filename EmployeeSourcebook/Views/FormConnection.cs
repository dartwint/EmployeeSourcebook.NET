using EmployeeSourcebook.Controllers;
using EmployeeSourcebook.DbAccess.Model;
using EmployeeSourcebook.Domain;
using EmployeeSourcebook.Models;
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

        private DbProvider _selectedDbProvider = DbProvider.None;
        private Dictionary<DbProvider, Control> _containersMap = new();

        private Color _buttonSaveOrigColor;

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

            LoadData();
            ShowAvailableFields();
        }

        private ConnectionUserData? _userData;

        private void LoadData()
        {
            _userData = UserDataManager.LoadData<ConnectionUserData>(ConnectionUserData.dataPath);

            if (_userData.SelectedProvider != DbProvider.None)
                comboBoxDbProvider.SelectedItem = _userData.SelectedProvider;
            _selectedDbProvider = _userData.SelectedProvider;
            textBoxFileSource.Text = _userData.SQLiteConnectionInfo.DataSource;
            textBoxHost.Text = _userData.PosgreSQLConnectionInfo.Host;
            textBoxPort.Text = _userData.PosgreSQLConnectionInfo.Port;
            textBoxUsername.Text = _userData.PosgreSQLConnectionInfo.Username;
            textBoxPassword.Text = _userData.PosgreSQLConnectionInfo.Password;
            textBoxDatabase.Text = _userData.PosgreSQLConnectionInfo.Database;
        }

        private void SaveData()
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

            UserDataManager.SaveData(_userData, ConnectionUserData.dataPath);
        }

        public void SetConnectionStatus(ConnectionState connectionState)
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

        private void comboBoxcomboBoxDbProvider_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxDbProvider.SelectedItem != null)
                _selectedDbProvider = (DbProvider) comboBoxDbProvider.SelectedItem;

            ShowAvailableFields();
        }

        private void ShowAvailableFields()
        {
            foreach (var control in _containersMap.Values)
            {
                control.Hide();
            }

            tableLayoutPanelConnectionFieldsRoot.SetRow(_containersMap[_selectedDbProvider], 1);
            _containersMap[_selectedDbProvider].Show();
        }

        private bool UpdateConnectionInfo()
        {
            IConnectionInfo? newConnectionInfo = null;

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
                    OnConnectionInfoChanged(ConnectionInfo);
                    return true;
                }
            }
            else if (ConnectionInfo != null)
            {
                ConnectionInfo = newConnectionInfo;
                OnConnectionInfoChanged(ConnectionInfo);
                return true;
            }

            return false;
        }

        private void buttonTestConnection_Click(object sender, EventArgs e)
        {
            if (comboBoxDbProvider.SelectedItem == null)
            {
                return;
            }

            if (UpdateConnectionInfo())
            {
                //ConnectionRequested?.Invoke(ConnectionInfo);
            }
            ConnectionRequested?.Invoke(ConnectionInfo);
        }

        private void OnConnectionInfoChanged(IConnectionInfo? connectionInfo)
        {
            ConnectionInfoChanged?.Invoke(ConnectionInfo);
        }

        private void buttonSaveAndClose_Click(object sender, EventArgs e)
        {
            SaveData();

            Close();
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
