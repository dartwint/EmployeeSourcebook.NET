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
        public event Action<Button>? ButtonNextTableClick;
        public event Action<Button>? ButtonPreviousTableClick;

        public FormMain()
        {
            InitializeComponent();
            
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
            var buttons = new List<Button>();
            for (int i = 0; i < 16; i++)
            {
                buttons.Add(new Button()
                {
                    AutoSize = false,
                    Text = $"Button{i}",
                    Margin = Padding.Empty,
                    Padding = Padding.Empty,
                    Height = flowLayoutPanelDbTables.Height -
                        flowLayoutPanelDbTables.Margin.All - flowLayoutPanelDbTables.Padding.All,
                    Anchor = AnchorStyles.Left
                });
                var size = TextRenderer.MeasureText(buttons[i].Text, buttons[i].Font);
                size.Width += 15;
                buttons[i].Width = size.Width;
                flowLayoutPanelDbTables.Controls.Add(buttons[i]);
            }

            TryHideScroll(flowLayoutPanelDbTables);
        }

        private void TryHideScroll(ScrollableControl control, int pixels = 100)
        {
            while (flowLayoutPanelDbTables.VerticalScroll.Visible && pixels > 0)
            {
                flowLayoutPanelDbTables.Height += 1;
                pixels--;
            }
        }

        private void buttonNextTable_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                ButtonNextTableClick?.Invoke(button);
            }
        }

        private void buttonPreviousTable_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                ButtonPreviousTableClick?.Invoke(button);
            }
        }
    }
}
