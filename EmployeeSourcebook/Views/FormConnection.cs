using EmployeeSourcebook.DbConnection;
using EmployeeSourcebook.DbConnection.Model;
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

        public IConnectionInfo? ConnectionInfo { get; set; }
        public event Action<IConnectionInfo?>? ConnectionChanged;

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

        private void buttonTestConnection_Click(object sender, EventArgs e)
        {
            switch (_selectedDbProvider)
            {
                case DbProviders.SQLite:
                    {
                        ConnectionInfo = new SQLiteConnectionBaseInfo(textBoxFileSource.Text);
                        break;
                    }
                case DbProviders.PosgreSQL:
                    {
                        ConnectionInfo = new PosgreSQLConnectionBaseInfo(
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
                        MessageBox.Show($"Database provider {_selectedDbProvider} is not implemented");
                        break;
                    }
            }

            if (comboBoxDbProvider.SelectedItem != null)
            {
                ConnectionChanged?.Invoke(ConnectionInfo);
            }
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
