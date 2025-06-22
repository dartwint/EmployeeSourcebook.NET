namespace EmployeeSourcebook.Views
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanelFooter = new FlowLayoutPanel();
            labelConnectionStatusHeader = new Label();
            labelConnectionStatus = new Label();
            labelLastConnectionStatusUpdateAt = new Label();
            labelLastConnectionStatusUpdateTime = new Label();
            dataGridViewEmployees = new DataGridView();
            flowLayoutPanelMenuContainer = new FlowLayoutPanel();
            menuStrip = new MenuStrip();
            connectionToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            buttonPrintEmployeesFromDepartment = new Button();
            panelTablesTabsContainer = new Panel();
            flowLayoutPanelDbTables = new FlowLayoutPanel();
            groupBoxTabsTables = new GroupBox();
            tableLayoutPanelTablesTabs = new TableLayoutPanel();
            panelRootContainer = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            flowLayoutPanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) dataGridViewEmployees).BeginInit();
            flowLayoutPanelMenuContainer.SuspendLayout();
            menuStrip.SuspendLayout();
            panelTablesTabsContainer.SuspendLayout();
            groupBoxTabsTables.SuspendLayout();
            tableLayoutPanelTablesTabs.SuspendLayout();
            panelRootContainer.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelFooter
            // 
            flowLayoutPanelFooter.Anchor =  AnchorStyles.Bottom | AnchorStyles.Left;
            flowLayoutPanelFooter.AutoSize = true;
            flowLayoutPanelFooter.Controls.Add(labelConnectionStatusHeader);
            flowLayoutPanelFooter.Controls.Add(labelConnectionStatus);
            flowLayoutPanelFooter.Controls.Add(labelLastConnectionStatusUpdateAt);
            flowLayoutPanelFooter.Controls.Add(labelLastConnectionStatusUpdateTime);
            flowLayoutPanelFooter.Location = new Point(0, 435);
            flowLayoutPanelFooter.Name = "flowLayoutPanelFooter";
            flowLayoutPanelFooter.Size = new Size(805, 15);
            flowLayoutPanelFooter.TabIndex = 0;
            // 
            // labelConnectionStatusHeader
            // 
            labelConnectionStatusHeader.AutoSize = true;
            labelConnectionStatusHeader.Location = new Point(3, 0);
            labelConnectionStatusHeader.Name = "labelConnectionStatusHeader";
            labelConnectionStatusHeader.Size = new Size(106, 15);
            labelConnectionStatusHeader.TabIndex = 1;
            labelConnectionStatusHeader.Text = "Connection status:";
            labelConnectionStatusHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelConnectionStatus
            // 
            labelConnectionStatus.AutoSize = true;
            labelConnectionStatus.Location = new Point(115, 0);
            labelConnectionStatus.Name = "labelConnectionStatus";
            labelConnectionStatus.Size = new Size(45, 15);
            labelConnectionStatus.TabIndex = 1;
            labelConnectionStatus.Text = "STATUS";
            labelConnectionStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelLastConnectionStatusUpdateAt
            // 
            labelLastConnectionStatusUpdateAt.AutoSize = true;
            labelLastConnectionStatusUpdateAt.Location = new Point(166, 0);
            labelLastConnectionStatusUpdateAt.Name = "labelLastConnectionStatusUpdateAt";
            labelLastConnectionStatusUpdateAt.Size = new Size(65, 15);
            labelLastConnectionStatusUpdateAt.TabIndex = 2;
            labelLastConnectionStatusUpdateAt.Text = "Updatet at:";
            labelLastConnectionStatusUpdateAt.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelLastConnectionStatusUpdateTime
            // 
            labelLastConnectionStatusUpdateTime.AutoSize = true;
            labelLastConnectionStatusUpdateTime.Location = new Point(237, 0);
            labelLastConnectionStatusUpdateTime.Name = "labelLastConnectionStatusUpdateTime";
            labelLastConnectionStatusUpdateTime.Size = new Size(33, 15);
            labelLastConnectionStatusUpdateTime.TabIndex = 3;
            labelLastConnectionStatusUpdateTime.Text = "TIME";
            // 
            // dataGridViewEmployees
            // 
            dataGridViewEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployees.Location = new Point(301, 195);
            dataGridViewEmployees.Name = "dataGridViewEmployees";
            dataGridViewEmployees.RowHeadersWidth = 62;
            dataGridViewEmployees.Size = new Size(485, 234);
            dataGridViewEmployees.TabIndex = 1;
            // 
            // flowLayoutPanelMenuContainer
            // 
            flowLayoutPanelMenuContainer.AutoSize = true;
            flowLayoutPanelMenuContainer.BackColor = Color.PeachPuff;
            flowLayoutPanelMenuContainer.Controls.Add(menuStrip);
            flowLayoutPanelMenuContainer.Dock = DockStyle.Top;
            flowLayoutPanelMenuContainer.Location = new Point(0, 0);
            flowLayoutPanelMenuContainer.Name = "flowLayoutPanelMenuContainer";
            flowLayoutPanelMenuContainer.Size = new Size(805, 24);
            flowLayoutPanelMenuContainer.TabIndex = 2;
            // 
            // menuStrip
            // 
            menuStrip.BackColor = Color.NavajoWhite;
            menuStrip.Dock = DockStyle.Fill;
            menuStrip.ImageScalingSize = new Size(24, 24);
            menuStrip.Items.AddRange(new ToolStripItem[] { connectionToolStripMenuItem, settingsToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.ShowItemToolTips = true;
            menuStrip.Size = new Size(150, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip";
            // 
            // connectionToolStripMenuItem
            // 
            connectionToolStripMenuItem.AutoToolTip = true;
            connectionToolStripMenuItem.BackColor = Color.Transparent;
            connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            connectionToolStripMenuItem.Size = new Size(81, 20);
            connectionToolStripMenuItem.Text = "Connection";
            connectionToolStripMenuItem.ToolTipText = "Open connection settings window";
            connectionToolStripMenuItem.Click += connectionToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(61, 20);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // buttonPrintEmployeesFromDepartment
            // 
            buttonPrintEmployeesFromDepartment.Location = new Point(25, 300);
            buttonPrintEmployeesFromDepartment.Name = "buttonPrintEmployeesFromDepartment";
            buttonPrintEmployeesFromDepartment.Size = new Size(107, 46);
            buttonPrintEmployeesFromDepartment.TabIndex = 3;
            buttonPrintEmployeesFromDepartment.Text = "Print emps from department";
            buttonPrintEmployeesFromDepartment.UseVisualStyleBackColor = true;
            // 
            // panelTablesTabsContainer
            // 
            panelTablesTabsContainer.Controls.Add(flowLayoutPanelDbTables);
            panelTablesTabsContainer.Dock = DockStyle.Fill;
            panelTablesTabsContainer.Location = new Point(3, 19);
            panelTablesTabsContainer.Name = "panelTablesTabsContainer";
            panelTablesTabsContainer.Size = new Size(769, 45);
            panelTablesTabsContainer.TabIndex = 5;
            // 
            // flowLayoutPanelDbTables
            // 
            flowLayoutPanelDbTables.Location = new Point(0, 0);
            flowLayoutPanelDbTables.Name = "flowLayoutPanelDbTables";
            flowLayoutPanelDbTables.Size = new Size(769, 42);
            flowLayoutPanelDbTables.TabIndex = 4;
            flowLayoutPanelDbTables.WrapContents = false;
            // 
            // groupBoxTabsTables
            // 
            groupBoxTabsTables.Controls.Add(panelTablesTabsContainer);
            groupBoxTabsTables.Dock = DockStyle.Fill;
            groupBoxTabsTables.Location = new Point(12, 3);
            groupBoxTabsTables.Name = "groupBoxTabsTables";
            groupBoxTabsTables.Size = new Size(775, 67);
            groupBoxTabsTables.TabIndex = 6;
            groupBoxTabsTables.TabStop = false;
            groupBoxTabsTables.Text = "Tables List";
            // 
            // tableLayoutPanelTablesTabs
            // 
            tableLayoutPanelTablesTabs.ColumnCount = 3;
            tableLayoutPanelTablesTabs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.11801243F));
            tableLayoutPanelTablesTabs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 97.01863F));
            tableLayoutPanelTablesTabs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.86335409F));
            tableLayoutPanelTablesTabs.Controls.Add(groupBoxTabsTables, 1, 0);
            tableLayoutPanelTablesTabs.Location = new Point(0, 34);
            tableLayoutPanelTablesTabs.Name = "tableLayoutPanelTablesTabs";
            tableLayoutPanelTablesTabs.RowCount = 1;
            tableLayoutPanelTablesTabs.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelTablesTabs.Size = new Size(805, 73);
            tableLayoutPanelTablesTabs.TabIndex = 8;
            // 
            // panelRootContainer
            // 
            panelRootContainer.AutoScroll = true;
            panelRootContainer.Controls.Add(button4);
            panelRootContainer.Controls.Add(button3);
            panelRootContainer.Controls.Add(button2);
            panelRootContainer.Controls.Add(button1);
            panelRootContainer.Controls.Add(flowLayoutPanelMenuContainer);
            panelRootContainer.Controls.Add(dataGridViewEmployees);
            panelRootContainer.Controls.Add(tableLayoutPanelTablesTabs);
            panelRootContainer.Controls.Add(buttonPrintEmployeesFromDepartment);
            panelRootContainer.Controls.Add(flowLayoutPanelFooter);
            panelRootContainer.Dock = DockStyle.Fill;
            panelRootContainer.Location = new Point(0, 0);
            panelRootContainer.Margin = new Padding(2);
            panelRootContainer.Name = "panelRootContainer";
            panelRootContainer.Size = new Size(805, 450);
            panelRootContainer.TabIndex = 9;
            // 
            // button4
            // 
            button4.Location = new Point(140, 187);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(78, 20);
            button4.TabIndex = 12;
            button4.Text = "Sort";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(141, 152);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(78, 20);
            button3.TabIndex = 11;
            button3.Text = "Filter";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(301, 146);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(78, 20);
            button2.TabIndex = 10;
            button2.Text = "Create";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(653, 143);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(98, 26);
            button1.TabIndex = 9;
            button1.Text = "Refresh data";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(805, 450);
            Controls.Add(panelRootContainer);
            Name = "FormMain";
            Text = "Employees sourcebook";
            Load += FormMain_Load;
            flowLayoutPanelFooter.ResumeLayout(false);
            flowLayoutPanelFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) dataGridViewEmployees).EndInit();
            flowLayoutPanelMenuContainer.ResumeLayout(false);
            flowLayoutPanelMenuContainer.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            panelTablesTabsContainer.ResumeLayout(false);
            groupBoxTabsTables.ResumeLayout(false);
            tableLayoutPanelTablesTabs.ResumeLayout(false);
            panelRootContainer.ResumeLayout(false);
            panelRootContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelFooter;
        private Label labelConnectionStatusHeader;
        private Label labelConnectionStatus;
        private DataGridView dataGridViewEmployees;
        private FlowLayoutPanel flowLayoutPanelMenuContainer;
        private MenuStrip menuStrip;
        private ToolStripMenuItem connectionToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private Button buttonPrintEmployeesFromDepartment;
        private Panel panelTablesTabsContainer;
        private GroupBox groupBoxTabsTables;
        private TableLayoutPanel tableLayoutPanelTablesTabs;
        private FlowLayoutPanel flowLayoutPanelDbTables;
        private Panel panelRootContainer;
        private Button button2;
        private Button button1;
        private Button button4;
        private Button button3;
        private Label labelLastConnectionStatusUpdateAt;
        private Label labelLastConnectionStatusUpdateTime;
    }
}