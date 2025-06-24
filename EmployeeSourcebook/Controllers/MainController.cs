using EmployeeSourcebook.DbAccess.Model.CommandRepository;
using EmployeeSourcebook.Properties;
using EmployeeSourcebook.Views;
using Microsoft.Data.Sqlite;
using Npgsql;
using System.Data.Common;

namespace EmployeeSourcebook.Controllers
{
    public class MainController
    {
        private FormMain _formMain;
        private FormConnection _formConnection;
        private FormSettings _formSettings;

        private FormMainController _formMainController;
        private FormConnectionController _formConnectionController;
        private readonly ConnectionController _connectionController;

        //private readonly HashSet<SQLCommandKey> _commandKeys;
        public static readonly SQLCommandsRegistry sqlCommandsRegistry = new();
        public static readonly SQLCommandKey createTablesKey = 
            new SQLCommandKey(TypeOfCommand.Create, "Create tables");
        public static readonly SQLCommandKey insertDummyRecordsKey = 
            new SQLCommandKey(TypeOfCommand.Insert, "Insert dummy data");
        public static readonly SQLCommandKey selectTablesKey =
            new SQLCommandKey(TypeOfCommand.Select, "Select tables list");

        public MainController(FormMain formMain, FormConnection formConnection, FormSettings formSettings)
        {
            _formMain = formMain;
            _formConnection = formConnection;
            _formSettings = formSettings;

            _connectionController = new ConnectionController(_formConnection, formMain);
            _formConnectionController = new FormConnectionController(_formConnection, _connectionController);

            ConstructSQLCommands<SqliteConnection>();
            ConstructSQLCommands<NpgsqlConnection>();

            _formMainController = new FormMainController(_formMain, _formConnection, _formSettings, _connectionController);
        }

        private void ConstructSQLCommands<TDbConnection>() where TDbConnection : DbConnection
        {
            SQLCommandWrapper? 
                createTablesCommand = null, 
                insertDummyCommand = null, 
                selectTablesListCommand = null;

            var type = typeof(TDbConnection);
            if (type.IsAssignableFrom(typeof(SqliteConnection)))
            {
                createTablesCommand = new SQLCommandWrapper(
                    File.ReadAllText(Resources.SqliteDbCreationCmdFile));
                
                insertDummyCommand = new SQLCommandWrapper(
                    File.ReadAllText(Resources.SqliteInsertDummyRecordsCmdFile));

                selectTablesListCommand = new SQLCommandWrapper(
                    "SELECT name FROM sqlite_master WHERE type='table' AND name NOT LIKE 'sqlite_%';");
            }
            else if (type.IsAssignableFrom(typeof(NpgsqlConnection)))
            {
                createTablesCommand = new SQLCommandWrapper(
                    File.ReadAllText(Resources.NpsqlDbCreationCmdFile));

                insertDummyCommand = new SQLCommandWrapper(
                    File.ReadAllText(Resources.NpsqlInsertDummyRecordsCmdFile));

                selectTablesListCommand = new SQLCommandWrapper(
                    "SELECT table_name FROM information_schema.tables WHERE table_schema = 'public' AND table_type = 'BASE TABLE';");
            }

            if (createTablesCommand != null)
            {
                sqlCommandsRegistry.AddCommand<TDbConnection>(createTablesKey, createTablesCommand);
            }

            if (insertDummyCommand != null)
            {
                sqlCommandsRegistry.AddCommand<TDbConnection>(insertDummyRecordsKey, insertDummyCommand);
            }

            if (selectTablesListCommand != null)
            {
                sqlCommandsRegistry.AddCommand<TDbConnection>(selectTablesKey, selectTablesListCommand);
            }
        }
    }
}
