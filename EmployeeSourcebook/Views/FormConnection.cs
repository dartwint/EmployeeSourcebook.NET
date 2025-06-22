using EmployeeSourcebook.DbAccess;
using EmployeeSourcebook.DbAccess.Model;
using EmployeeSourcebook.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSourcebook.Views
{
    public partial class FormConnection : Form, IConnectionView
    {
        public enum DbProviders
        {
            SQLite, PosgreSQL
        }

        public IConnectionInfo? ConnectionInfo { get; private set; }
        public event Action<IConnectionInfo?>? ConnectionInfoChanged;
        public event Action<IConnectionInfo?>? ConnectionRequested;

        private bool _isDbProviderSet = false;
        private DbProviders _selectedDbProvider;
        private Dictionary<DbProviders, Control> _containersMap = new();

        public FormConnection()
        {
            InitializeComponent();

            var providers = Enum.GetValues(typeof(DbProviders));
            comboBoxDbProvider.DataSource = providers;
            comboBoxDbProvider.SelectedItem = null;

            panelSQLite.Hide();
            panelPostgreSQL.Hide();

            _containersMap.Add(DbProviders.SQLite, panelSQLite);
            _containersMap.Add(DbProviders.PosgreSQL, panelPostgreSQL);
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
            {
                if (_isDbProviderSet)
                {
                    tableLayoutPanelConnectionFieldsRoot.SetRow(_containersMap[_selectedDbProvider], 2);
                    _containersMap[_selectedDbProvider].Hide();
                }

                _selectedDbProvider = (DbProviders) comboBoxDbProvider.SelectedItem;
                tableLayoutPanelConnectionFieldsRoot.SetRow(_containersMap[_selectedDbProvider], 1);
                _containersMap[_selectedDbProvider].Show();
                _isDbProviderSet = true;
            }
        }

        private bool UpdateConnectionInfo()
        {
            IConnectionInfo? newConnectionInfo = null;

            switch (_selectedDbProvider)
            {
                case DbProviders.SQLite:
                    {
                        newConnectionInfo = new SQLiteConnectionBaseInfo(textBoxFileSource.Text);
                        break;
                    }
                case DbProviders.PosgreSQL:
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
            //Close();
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
