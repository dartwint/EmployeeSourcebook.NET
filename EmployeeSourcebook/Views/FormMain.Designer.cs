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
            flowLayoutPanelDbTables = new FlowLayoutPanel();
            panelTablesTabsContainer = new Panel();
            tableLayoutPanelTabsControls = new TableLayoutPanel();
            buttonNextTable = new Button();
            buttonPreviousTable = new Button();
            groupBoxTabsTables = new GroupBox();
            splitter1 = new Splitter();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) dataGridViewEmployees).BeginInit();
            flowLayoutPanelMenuContainer.SuspendLayout();
            menuStrip.SuspendLayout();
            panelTablesTabsContainer.SuspendLayout();
            tableLayoutPanelTabsControls.SuspendLayout();
            groupBoxTabsTables.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelFooter
            // 
            flowLayoutPanelFooter.AutoSize = true;
            flowLayoutPanelFooter.Controls.Add(labelConnectionStatusHeader);
            flowLayoutPanelFooter.Controls.Add(labelConnectionStatus);
            flowLayoutPanelFooter.Dock = DockStyle.Bottom;
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
            // 
            // labelConnectionStatus
            // 
            labelConnectionStatus.AutoSize = true;
            labelConnectionStatus.Location = new Point(115, 0);
            labelConnectionStatus.Name = "labelConnectionStatus";
            labelConnectionStatus.Size = new Size(45, 15);
            labelConnectionStatus.TabIndex = 1;
            labelConnectionStatus.Text = "STATUS";
            // 
            // dataGridViewEmployees
            // 
            dataGridViewEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployees.Location = new Point(223, 155);
            dataGridViewEmployees.Name = "dataGridViewEmployees";
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
            // flowLayoutPanelDbTables
            // 
            flowLayoutPanelDbTables.Dock = DockStyle.Top;
            flowLayoutPanelDbTables.Location = new Point(0, 0);
            flowLayoutPanelDbTables.Name = "flowLayoutPanelDbTables";
            flowLayoutPanelDbTables.Size = new Size(769, 37);
            flowLayoutPanelDbTables.TabIndex = 4;
            flowLayoutPanelDbTables.WrapContents = false;
            // 
            // panelTablesTabsContainer
            // 
            panelTablesTabsContainer.Controls.Add(tableLayoutPanelTabsControls);
            panelTablesTabsContainer.Controls.Add(flowLayoutPanelDbTables);
            panelTablesTabsContainer.Dock = DockStyle.Fill;
            panelTablesTabsContainer.Location = new Point(3, 19);
            panelTablesTabsContainer.Name = "panelTablesTabsContainer";
            panelTablesTabsContainer.Size = new Size(769, 59);
            panelTablesTabsContainer.TabIndex = 5;
            // 
            // tableLayoutPanelTabsControls
            // 
            tableLayoutPanelTabsControls.ColumnCount = 2;
            tableLayoutPanelTabsControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelTabsControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelTabsControls.Controls.Add(buttonNextTable, 1, 0);
            tableLayoutPanelTabsControls.Controls.Add(buttonPreviousTable, 0, 0);
            tableLayoutPanelTabsControls.Dock = DockStyle.Left;
            tableLayoutPanelTabsControls.Location = new Point(0, 37);
            tableLayoutPanelTabsControls.Margin = new Padding(0);
            tableLayoutPanelTabsControls.Name = "tableLayoutPanelTabsControls";
            tableLayoutPanelTabsControls.RowCount = 1;
            tableLayoutPanelTabsControls.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelTabsControls.Size = new Size(67, 22);
            tableLayoutPanelTabsControls.TabIndex = 5;
            // 
            // buttonNextTable
            // 
            buttonNextTable.Dock = DockStyle.Fill;
            buttonNextTable.Location = new Point(33, 0);
            buttonNextTable.Margin = new Padding(0);
            buttonNextTable.Name = "buttonNextTable";
            buttonNextTable.Size = new Size(34, 22);
            buttonNextTable.TabIndex = 1;
            buttonNextTable.Text = ">";
            buttonNextTable.UseVisualStyleBackColor = true;
            buttonNextTable.Click += buttonNextTable_Click;
            // 
            // buttonPreviousTable
            // 
            buttonPreviousTable.Dock = DockStyle.Fill;
            buttonPreviousTable.Location = new Point(0, 0);
            buttonPreviousTable.Margin = new Padding(0);
            buttonPreviousTable.Name = "buttonPreviousTable";
            buttonPreviousTable.Size = new Size(33, 22);
            buttonPreviousTable.TabIndex = 0;
            buttonPreviousTable.Text = "<";
            buttonPreviousTable.UseVisualStyleBackColor = true;
            buttonPreviousTable.Click += buttonPreviousTable_Click;
            // 
            // groupBoxTabsTables
            // 
            groupBoxTabsTables.Controls.Add(panelTablesTabsContainer);
            groupBoxTabsTables.Dock = DockStyle.Top;
            groupBoxTabsTables.Location = new Point(12, 3);
            groupBoxTabsTables.Name = "groupBoxTabsTables";
            groupBoxTabsTables.Size = new Size(775, 81);
            groupBoxTabsTables.TabIndex = 6;
            groupBoxTabsTables.TabStop = false;
            groupBoxTabsTables.Text = "Tables List";
            // 
            // splitter1
            // 
            splitter1.Dock = DockStyle.Top;
            splitter1.Location = new Point(0, 24);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(805, 12);
            splitter1.TabIndex = 7;
            splitter1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.11801243F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 97.01863F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.86335409F));
            tableLayoutPanel1.Controls.Add(groupBoxTabsTables, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 36);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(805, 87);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(805, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(buttonPrintEmployeesFromDepartment);
            Controls.Add(splitter1);
            Controls.Add(flowLayoutPanelMenuContainer);
            Controls.Add(dataGridViewEmployees);
            Controls.Add(flowLayoutPanelFooter);
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
            tableLayoutPanelTabsControls.ResumeLayout(false);
            groupBoxTabsTables.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private FlowLayoutPanel flowLayoutPanelDbTables;
        private Panel panelTablesTabsContainer;
        private TableLayoutPanel tableLayoutPanelTabsControls;
        private Button buttonNextTable;
        private Button buttonPreviousTable;
        private GroupBox groupBoxTabsTables;
        private Splitter splitter1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}