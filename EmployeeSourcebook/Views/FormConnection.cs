using EmployeeSourcebook.DbConnection;
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
        private DbProviders _selectedDbProvider;
        private Dictionary<DbProviders, Control> _containersMap = new();

        public FormConnection()
        {
            InitializeComponent();

            var providers = Enum.GetValues(typeof(DbProviders));
            comboBoxProvider.DataSource = providers;
            comboBoxProvider.SelectedItem = null;


        }

        public enum DbProviders
        {
            SQLite, PosgreSQL
        }

        private void ShowCompatibleFields(DbProviders dbProvider)
        {
            switch (dbProvider)
            {
                case DbProviders.SQLite:
                    {
                        ShowFieldsCompatibleWithSQLite();
                        break;
                    }
                case DbProviders.PosgreSQL:
                    {
                        ShowFieldsCompatibleWithPostgreSQL();
                        break;
                    }
                default:
                    {
                        HideProviderSpecificFields();
                        break;
                    }
            }
        }

        private void HideProviderSpecificFields()
        {

        }

        private void ShowFieldsCompatibleWithSQLite()
        {

        }

        private void ShowFieldsCompatibleWithPostgreSQL()
        {

        }

        private void comboBoxProvider_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxProvider.SelectedValue != null)
            {
                _selectedDbProvider = (DbProviders) comboBoxProvider.SelectedValue;
            }
        }

        private void ShowAvailableFields<TConnectionInfo>() where TConnectionInfo : IConnectionInfo
        {
            Type connectionInfoType = typeof(TConnectionInfo);

            if (connectionInfoType.IsAssignableFrom(typeof(SQLiteConnectionBaseInfo)))
            {

            }

            if (connectionInfoType.IsAssignableFrom(typeof(PosgreSQLConnectionBaseInfo)))
            {

            }
        }
    }
}
