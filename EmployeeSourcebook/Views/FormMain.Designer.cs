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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
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
            flowLayoutPanelFooter.Location = new Point(0, 725);
            flowLayoutPanelFooter.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanelFooter.Name = "flowLayoutPanelFooter";
            flowLayoutPanelFooter.Size = new Size(1150, 25);
            flowLayoutPanelFooter.TabIndex = 0;
            // 
            // labelConnectionStatusHeader
            // 
            labelConnectionStatusHeader.AutoSize = true;
            labelConnectionStatusHeader.Location = new Point(4, 0);
            labelConnectionStatusHeader.Margin = new Padding(4, 0, 4, 0);
            labelConnectionStatusHeader.Name = "labelConnectionStatusHeader";
            labelConnectionStatusHeader.Size = new Size(158, 25);
            labelConnectionStatusHeader.TabIndex = 1;
            labelConnectionStatusHeader.Text = "Connection status:";
            // 
            // labelConnectionStatus
            // 
            labelConnectionStatus.AutoSize = true;
            labelConnectionStatus.Location = new Point(170, 0);
            labelConnectionStatus.Margin = new Padding(4, 0, 4, 0);
            labelConnectionStatus.Name = "labelConnectionStatus";
            labelConnectionStatus.Size = new Size(72, 25);
            labelConnectionStatus.TabIndex = 1;
            labelConnectionStatus.Text = "STATUS";
            // 
            // dataGridViewEmployees
            // 
            dataGridViewEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployees.Location = new Point(430, 325);
            dataGridViewEmployees.Margin = new Padding(4, 5, 4, 5);
            dataGridViewEmployees.Name = "dataGridViewEmployees";
            dataGridViewEmployees.RowHeadersWidth = 62;
            dataGridViewEmployees.Size = new Size(693, 390);
            dataGridViewEmployees.TabIndex = 1;
            // 
            // flowLayoutPanelMenuContainer
            // 
            flowLayoutPanelMenuContainer.AutoSize = true;
            flowLayoutPanelMenuContainer.BackColor = Color.PeachPuff;
            flowLayoutPanelMenuContainer.Controls.Add(menuStrip);
            flowLayoutPanelMenuContainer.Dock = DockStyle.Top;
            flowLayoutPanelMenuContainer.Location = new Point(0, 0);
            flowLayoutPanelMenuContainer.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanelMenuContainer.Name = "flowLayoutPanelMenuContainer";
            flowLayoutPanelMenuContainer.Size = new Size(1150, 35);
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
            menuStrip.Padding = new Padding(9, 3, 0, 3);
            menuStrip.ShowItemToolTips = true;
            menuStrip.Size = new Size(401, 35);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip";
            // 
            // connectionToolStripMenuItem
            // 
            connectionToolStripMenuItem.AutoToolTip = true;
            connectionToolStripMenuItem.BackColor = Color.Transparent;
            connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            connectionToolStripMenuItem.Size = new Size(118, 29);
            connectionToolStripMenuItem.Text = "Connection";
            connectionToolStripMenuItem.ToolTipText = "Open connection settings window";
            connectionToolStripMenuItem.Click += connectionToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(92, 29);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // buttonPrintEmployeesFromDepartment
            // 
            buttonPrintEmployeesFromDepartment.Location = new Point(36, 500);
            buttonPrintEmployeesFromDepartment.Margin = new Padding(4, 5, 4, 5);
            buttonPrintEmployeesFromDepartment.Name = "buttonPrintEmployeesFromDepartment";
            buttonPrintEmployeesFromDepartment.Size = new Size(153, 77);
            buttonPrintEmployeesFromDepartment.TabIndex = 3;
            buttonPrintEmployeesFromDepartment.Text = "Print emps from department";
            buttonPrintEmployeesFromDepartment.UseVisualStyleBackColor = true;
            // 
            // panelTablesTabsContainer
            // 
            panelTablesTabsContainer.Controls.Add(flowLayoutPanelDbTables);
            panelTablesTabsContainer.Dock = DockStyle.Fill;
            panelTablesTabsContainer.Location = new Point(4, 29);
            panelTablesTabsContainer.Margin = new Padding(4, 5, 4, 5);
            panelTablesTabsContainer.Name = "panelTablesTabsContainer";
            panelTablesTabsContainer.Size = new Size(1099, 59);
            panelTablesTabsContainer.TabIndex = 5;
            // 
            // flowLayoutPanelDbTables
            // 
            flowLayoutPanelDbTables.Location = new Point(0, 0);
            flowLayoutPanelDbTables.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanelDbTables.Name = "flowLayoutPanelDbTables";
            flowLayoutPanelDbTables.Size = new Size(1099, 59);
            flowLayoutPanelDbTables.TabIndex = 4;
            flowLayoutPanelDbTables.WrapContents = false;
            // 
            // groupBoxTabsTables
            // 
            groupBoxTabsTables.Controls.Add(panelTablesTabsContainer);
            groupBoxTabsTables.Dock = DockStyle.Fill;
            groupBoxTabsTables.Location = new Point(16, 5);
            groupBoxTabsTables.Margin = new Padding(4, 5, 4, 5);
            groupBoxTabsTables.Name = "groupBoxTabsTables";
            groupBoxTabsTables.Padding = new Padding(4, 5, 4, 5);
            groupBoxTabsTables.Size = new Size(1107, 93);
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
            tableLayoutPanelTablesTabs.Location = new Point(0, 57);
            tableLayoutPanelTablesTabs.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanelTablesTabs.Name = "tableLayoutPanelTablesTabs";
            tableLayoutPanelTablesTabs.RowCount = 1;
            tableLayoutPanelTablesTabs.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelTablesTabs.Size = new Size(1150, 103);
            tableLayoutPanelTablesTabs.TabIndex = 8;
            // 
            // panelRootContainer
            // 
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
            panelRootContainer.Name = "panelRootContainer";
            panelRootContainer.Size = new Size(1150, 750);
            panelRootContainer.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(933, 238);
            button1.Name = "button1";
            button1.Size = new Size(140, 44);
            button1.TabIndex = 9;
            button1.Text = "Refresh data";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(430, 243);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 10;
            button2.Text = "Create";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(201, 253);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 11;
            button3.Text = "Filter";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(200, 311);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 12;
            button4.Text = "Sort";
            button4.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(1150, 750);
            Controls.Add(panelRootContainer);
            Margin = new Padding(4, 5, 4, 5);
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
    }
}