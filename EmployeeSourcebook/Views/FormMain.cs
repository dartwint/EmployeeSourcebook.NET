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
    public partial class FormMain : Form, IMainView
    {
        public event Action? ButtonConnectionSettingsClick;
        public event Action? ButtonSettingsClick;
        public event Action<Button>? ButtonNextTableClick;
        public event Action<Button>? ButtonPreviousTableClick;

        private TableTab? _selectedTableTab = null;
        private CustomTabControl _tabControl;

        private int _originalTabPanelHeight;

        public FormMain()
        {
            InitializeComponent();
            _tabControl = new CustomTabControl();

            _originalTabPanelHeight = flowLayoutPanelDbTables.Height;

            labelConnectionStatus.Text = "Not connected";
            labelLastConnectionStatusUpdateAt.Text = string.Empty;
            labelLastConnectionStatusUpdateTime.Text = string.Empty;
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
            AddDummyTabsForDbTables();
        }

        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ButtonConnectionSettingsClick?.Invoke();
        }

        private void AddDummyTabsForDbTables()
        {
            var buttons = new List<TableTab>();
            var decorator = new TabButtonDecorator<TableTab>();

            flowLayoutPanelDbTables.WrapContents = false;
            flowLayoutPanelDbTables.AutoScroll = true;
            flowLayoutPanelDbTables.HorizontalScroll.Visible = true;
            flowLayoutPanelDbTables.VerticalScroll.Enabled = false;

            for (int i = 0; i < 16; i++)
            {
                var button = new TableTab
                {
                    AutoSize = false,
                    Text = $"Button{i}",
                    Margin = Padding.Empty,
                    Padding = Padding.Empty,
                    FlatStyle = FlatStyle.Flat,
                    Anchor = AnchorStyles.Left | AnchorStyles.Top,
                    //Height = _originalTabPanelHeight - SystemInformation.HorizontalScrollBarHeight
                };

                var size = TextRenderer.MeasureText(button.Text, button.Font);
                button.Width = size.Width + 15;
                button.Height = Math.Max(size.Height,
                    _originalTabPanelHeight - SystemInformation.HorizontalScrollBarHeight);

                decorator.DecorateAsNotSelected(button);
                button.Click += OnButtonTabClicked;
                buttons.Add(button);

                flowLayoutPanelDbTables.Controls.Add(button);
            }

            flowLayoutPanelDbTables.HorizontalScroll.SmallChange = buttons[0].Width;
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

                _tabControl.SelectTab(tableTab);
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ButtonSettingsClick?.Invoke();
        }
    }
}
