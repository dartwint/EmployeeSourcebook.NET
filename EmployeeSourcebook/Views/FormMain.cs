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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmployeeSourcebook.Views
{
    public partial class FormMain : Form, IMainView
    {
        public event Action? ButtonConnectionSettingsClick;
        public event Action? ButtonSettingsClick;
        public event Action<TableTab>? TableTabSelected;

        public DataGridView DataGridView => dataGridViewEmployees;

        //public event Action<Button>? ButtonNextTableClick;
        //public event Action<Button>? ButtonPreviousTableClick;

        private TableTab? _selectedTableTab = null;

        private int _originalTabPanelHeight;

        public FormMain()
        {
            InitializeComponent();

            _originalTabPanelHeight = flowLayoutPanelDbTables.Height;

            labelConnectionStatus.Text = "Not connected";
            labelLastConnectionStatusUpdateAt.Text = string.Empty;
            labelLastConnectionStatusUpdateTime.Text = string.Empty;
        }

        public void SetTablesTabs(List<TableTab>? tabs)
        {
            if (tabs == null || tabs.Count == 0)
            {
                var controlsToRemove = flowLayoutPanelDbTables.Controls
                    .OfType<TableTab>()
                    .ToArray();

                foreach (var tableTab in controlsToRemove)
                {
                    flowLayoutPanelDbTables.Controls.Remove(tableTab);
                    tableTab.Dispose();
                }
                return;
            }

            var decorator = new TabButtonDecorator<TableTab>();

            flowLayoutPanelDbTables.WrapContents = false;
            flowLayoutPanelDbTables.AutoScroll = true;
            flowLayoutPanelDbTables.HorizontalScroll.Visible = true;
            flowLayoutPanelDbTables.VerticalScroll.Enabled = false;

            foreach (var tab in tabs)
            {
                var size = TextRenderer.MeasureText(tab.Text, tab.Font);
                tab.Width = size.Width + 15;
                tab.Height = Math.Max(size.Height,
                    _originalTabPanelHeight - SystemInformation.HorizontalScrollBarHeight);

                decorator.DecorateAsNotSelected(tab);
                tab.Click += OnButtonTabClicked;

                flowLayoutPanelDbTables.Controls.Add(tab);
            }

            flowLayoutPanelDbTables.HorizontalScroll.SmallChange = tabs[0].Width;
        }

        public void SetConnectionStateInfo(ConnectionState connectionState)
        {
            labelLastConnectionStatusUpdateAt.Text = "Updated at: ";
            labelLastConnectionStatusUpdateTime.Text = DateTime.Now.ToString("HH:mm:ss");


            switch (connectionState)
            {
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
                case ConnectionState.Connecting:
                    {
                        labelConnectionStatus.Text = "Connecting";
                        labelConnectionStatus.ForeColor = Color.Blue;
                        break;
                    }
                case ConnectionState.Closed:
                    {
                        labelConnectionStatus.Text = "Disconnected";
                        labelConnectionStatus.ForeColor = Color.Black;
                        break;
                    }
                case ConnectionState.Executing:
                    {
                        labelConnectionStatus.Text = "Executing command";
                        labelConnectionStatus.ForeColor = Color.Blue;
                        break;
                    }
                case ConnectionState.Fetching:
                    {
                        labelConnectionStatus.Text = "Fetching data";
                        labelConnectionStatus.ForeColor = Color.Blue;
                        break;
                    }
                default:
                    {
                        labelConnectionStatus.Text = "Unknown";
                        labelConnectionStatus.ForeColor = Color.Black;
                        break;
                    }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

        private void OnTableTabSelected(TableTab tab)
        {
            TableTabSelected?.Invoke(tab);
        }

        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ButtonConnectionSettingsClick?.Invoke();
        }

        private void OnButtonTabClicked(object? sender, EventArgs e)
        {
            if (sender is TableTab tableTab)
            {
                if (_selectedTableTab == tableTab)
                    return;

                var decorator = new TabButtonDecorator<TableTab>();

                if (_selectedTableTab != null)
                    decorator.DecorateAsNotSelected(_selectedTableTab);

                _selectedTableTab = tableTab;
                decorator.DecorateAsSelected(_selectedTableTab);

                OnTableTabSelected(tableTab);
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ButtonSettingsClick?.Invoke();
        }
    }
}
