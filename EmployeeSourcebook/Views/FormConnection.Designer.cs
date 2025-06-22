namespace EmployeeSourcebook.Views
{
    partial class FormConnection
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
            buttonSaveAndClose = new Button();
            labelConnectionStatusTitle = new Label();
            labelConnectionStatus = new Label();
            buttonTestConnection = new Button();
            panelRoot = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanelRoot = new TableLayoutPanel();
            tableLayoutPanelConnectionFieldsRoot = new TableLayoutPanel();
            panelProvider = new Panel();
            tableLayoutPanelProviderChoose = new TableLayoutPanel();
            labelProviderChoose = new Label();
            comboBoxDbProvider = new ComboBox();
            panelSQLite = new Panel();
            tableLayoutPanelProviderSpecificSQLite = new TableLayoutPanel();
            labelDbSource = new Label();
            textBoxFileSource = new TextBox();
            buttonResetFileSource = new Button();
            buttonSelectFileSource = new Button();
            panelPostgreSQL = new Panel();
            tableLayoutPanelProviderSpecificPostgreSQL = new TableLayoutPanel();
            buttonResetPort = new Button();
            buttonResetHost = new Button();
            labelHost = new Label();
            labelPort = new Label();
            labelUsername = new Label();
            labelPassword = new Label();
            buttonResetUsername = new Button();
            buttonResetPassword = new Button();
            textBoxHost = new TextBox();
            textBoxPort = new TextBox();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            textBoxDatabase = new TextBox();
            labelDatabase = new Label();
            button1 = new Button();
            panelRoot.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanelRoot.SuspendLayout();
            tableLayoutPanelConnectionFieldsRoot.SuspendLayout();
            panelProvider.SuspendLayout();
            tableLayoutPanelProviderChoose.SuspendLayout();
            panelSQLite.SuspendLayout();
            tableLayoutPanelProviderSpecificSQLite.SuspendLayout();
            panelPostgreSQL.SuspendLayout();
            tableLayoutPanelProviderSpecificPostgreSQL.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSaveAndClose
            // 
            buttonSaveAndClose.Anchor = AnchorStyles.Right;
            buttonSaveAndClose.BackColor = SystemColors.GradientActiveCaption;
            buttonSaveAndClose.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point,  204);
            buttonSaveAndClose.Location = new Point(531, 3);
            buttonSaveAndClose.Name = "buttonSaveAndClose";
            buttonSaveAndClose.Size = new Size(192, 48);
            buttonSaveAndClose.TabIndex = 5;
            buttonSaveAndClose.Text = "Save and close";
            buttonSaveAndClose.UseVisualStyleBackColor = false;
            buttonSaveAndClose.Click += buttonSaveAndClose_Click;
            // 
            // labelConnectionStatusTitle
            // 
            labelConnectionStatusTitle.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
            labelConnectionStatusTitle.AutoSize = true;
            labelConnectionStatusTitle.Font = new Font("Segoe UI", 12F);
            labelConnectionStatusTitle.Location = new Point(3, 16);
            labelConnectionStatusTitle.Name = "labelConnectionStatusTitle";
            labelConnectionStatusTitle.Size = new Size(182, 21);
            labelConnectionStatusTitle.TabIndex = 6;
            labelConnectionStatusTitle.Text = "Connection status:";
            labelConnectionStatusTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelConnectionStatus
            // 
            labelConnectionStatus.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
            labelConnectionStatus.AutoSize = true;
            labelConnectionStatus.BackColor = SystemColors.Info;
            labelConnectionStatus.Font = new Font("Segoe UI", 12F);
            labelConnectionStatus.Location = new Point(191, 16);
            labelConnectionStatus.Name = "labelConnectionStatus";
            labelConnectionStatus.Size = new Size(100, 21);
            labelConnectionStatus.TabIndex = 7;
            labelConnectionStatus.Text = "none";
            labelConnectionStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonTestConnection
            // 
            buttonTestConnection.Anchor = AnchorStyles.None;
            buttonTestConnection.BackColor = SystemColors.ButtonHighlight;
            buttonTestConnection.Location = new Point(311, 11);
            buttonTestConnection.Margin = new Padding(2);
            buttonTestConnection.Name = "buttonTestConnection";
            buttonTestConnection.Size = new Size(128, 31);
            buttonTestConnection.TabIndex = 8;
            buttonTestConnection.Text = "Test connection";
            buttonTestConnection.UseVisualStyleBackColor = false;
            buttonTestConnection.Click += buttonTestConnection_Click;
            // 
            // panelRoot
            // 
            panelRoot.AutoScroll = true;
            panelRoot.BackColor = SystemColors.Info;
            panelRoot.Controls.Add(flowLayoutPanel1);
            panelRoot.Dock = DockStyle.Fill;
            panelRoot.Location = new Point(0, 0);
            panelRoot.Name = "panelRoot";
            panelRoot.Size = new Size(732, 308);
            panelRoot.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(tableLayoutPanelRoot);
            flowLayoutPanel1.Controls.Add(tableLayoutPanelConnectionFieldsRoot);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(732, 308);
            flowLayoutPanel1.TabIndex = 10;
            flowLayoutPanel1.WrapContents = false;
            // 
            // tableLayoutPanelRoot
            // 
            tableLayoutPanelRoot.AutoScroll = true;
            tableLayoutPanelRoot.ColumnCount = 4;
            tableLayoutPanelRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.8802814F));
            tableLayoutPanelRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.6126757F));
            tableLayoutPanelRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.5352116F));
            tableLayoutPanelRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.7957764F));
            tableLayoutPanelRoot.Controls.Add(buttonSaveAndClose, 3, 0);
            tableLayoutPanelRoot.Controls.Add(buttonTestConnection, 2, 0);
            tableLayoutPanelRoot.Controls.Add(labelConnectionStatus, 1, 0);
            tableLayoutPanelRoot.Controls.Add(labelConnectionStatusTitle, 0, 0);
            tableLayoutPanelRoot.Dock = DockStyle.Fill;
            tableLayoutPanelRoot.Location = new Point(3, 3);
            tableLayoutPanelRoot.Name = "tableLayoutPanelRoot";
            tableLayoutPanelRoot.RowCount = 1;
            tableLayoutPanelRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelRoot.Size = new Size(726, 54);
            tableLayoutPanelRoot.TabIndex = 7;
            // 
            // tableLayoutPanelConnectionFieldsRoot
            // 
            tableLayoutPanelConnectionFieldsRoot.AutoSize = true;
            tableLayoutPanelConnectionFieldsRoot.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanelConnectionFieldsRoot.ColumnCount = 1;
            tableLayoutPanelConnectionFieldsRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelConnectionFieldsRoot.Controls.Add(panelProvider, 0, 0);
            tableLayoutPanelConnectionFieldsRoot.Controls.Add(panelSQLite, 0, 1);
            tableLayoutPanelConnectionFieldsRoot.Controls.Add(panelPostgreSQL, 0, 2);
            tableLayoutPanelConnectionFieldsRoot.Dock = DockStyle.Fill;
            tableLayoutPanelConnectionFieldsRoot.Location = new Point(3, 63);
            tableLayoutPanelConnectionFieldsRoot.Name = "tableLayoutPanelConnectionFieldsRoot";
            tableLayoutPanelConnectionFieldsRoot.RowCount = 3;
            tableLayoutPanelConnectionFieldsRoot.RowStyles.Add(new RowStyle());
            tableLayoutPanelConnectionFieldsRoot.RowStyles.Add(new RowStyle());
            tableLayoutPanelConnectionFieldsRoot.RowStyles.Add(new RowStyle());
            tableLayoutPanelConnectionFieldsRoot.Size = new Size(726, 237);
            tableLayoutPanelConnectionFieldsRoot.TabIndex = 9;
            // 
            // panelProvider
            // 
            panelProvider.AutoSize = true;
            panelProvider.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelProvider.BorderStyle = BorderStyle.FixedSingle;
            panelProvider.Controls.Add(tableLayoutPanelProviderChoose);
            panelProvider.Dock = DockStyle.Fill;
            panelProvider.Location = new Point(3, 3);
            panelProvider.Name = "panelProvider";
            panelProvider.Size = new Size(720, 31);
            panelProvider.TabIndex = 10;
            // 
            // tableLayoutPanelProviderChoose
            // 
            tableLayoutPanelProviderChoose.AutoSize = true;
            tableLayoutPanelProviderChoose.ColumnCount = 2;
            tableLayoutPanelProviderChoose.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.5845642F));
            tableLayoutPanelProviderChoose.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.4154358F));
            tableLayoutPanelProviderChoose.Controls.Add(labelProviderChoose, 0, 0);
            tableLayoutPanelProviderChoose.Controls.Add(comboBoxDbProvider, 1, 0);
            tableLayoutPanelProviderChoose.Dock = DockStyle.Fill;
            tableLayoutPanelProviderChoose.Location = new Point(0, 0);
            tableLayoutPanelProviderChoose.Name = "tableLayoutPanelProviderChoose";
            tableLayoutPanelProviderChoose.RowCount = 1;
            tableLayoutPanelProviderChoose.RowStyles.Add(new RowStyle());
            tableLayoutPanelProviderChoose.Size = new Size(718, 29);
            tableLayoutPanelProviderChoose.TabIndex = 9;
            // 
            // labelProviderChoose
            // 
            labelProviderChoose.Anchor = AnchorStyles.Left;
            labelProviderChoose.AutoSize = true;
            labelProviderChoose.Font = new Font("Segoe UI", 11.25F);
            labelProviderChoose.Location = new Point(3, 4);
            labelProviderChoose.Name = "labelProviderChoose";
            labelProviderChoose.Size = new Size(64, 20);
            labelProviderChoose.TabIndex = 11;
            labelProviderChoose.Text = "Provider";
            labelProviderChoose.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxDbProvider
            // 
            comboBoxDbProvider.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
            comboBoxDbProvider.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDbProvider.FormattingEnabled = true;
            comboBoxDbProvider.Location = new Point(122, 3);
            comboBoxDbProvider.Name = "comboBoxDbProvider";
            comboBoxDbProvider.Size = new Size(593, 23);
            comboBoxDbProvider.TabIndex = 12;
            comboBoxDbProvider.SelectionChangeCommitted += comboBoxcomboBoxDbProvider_SelectionChangeCommitted;
            // 
            // panelSQLite
            // 
            panelSQLite.AutoSize = true;
            panelSQLite.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelSQLite.BorderStyle = BorderStyle.FixedSingle;
            panelSQLite.Controls.Add(tableLayoutPanelProviderSpecificSQLite);
            panelSQLite.Dock = DockStyle.Fill;
            panelSQLite.Location = new Point(3, 40);
            panelSQLite.Name = "panelSQLite";
            panelSQLite.Size = new Size(720, 41);
            panelSQLite.TabIndex = 8;
            // 
            // tableLayoutPanelProviderSpecificSQLite
            // 
            tableLayoutPanelProviderSpecificSQLite.AutoSize = true;
            tableLayoutPanelProviderSpecificSQLite.ColumnCount = 4;
            tableLayoutPanelProviderSpecificSQLite.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.61165F));
            tableLayoutPanelProviderSpecificSQLite.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.38835F));
            tableLayoutPanelProviderSpecificSQLite.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 76F));
            tableLayoutPanelProviderSpecificSQLite.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            tableLayoutPanelProviderSpecificSQLite.Controls.Add(labelDbSource, 0, 0);
            tableLayoutPanelProviderSpecificSQLite.Controls.Add(textBoxFileSource, 1, 0);
            tableLayoutPanelProviderSpecificSQLite.Controls.Add(buttonResetFileSource, 3, 0);
            tableLayoutPanelProviderSpecificSQLite.Controls.Add(buttonSelectFileSource, 2, 0);
            tableLayoutPanelProviderSpecificSQLite.Dock = DockStyle.Fill;
            tableLayoutPanelProviderSpecificSQLite.Location = new Point(0, 0);
            tableLayoutPanelProviderSpecificSQLite.Name = "tableLayoutPanelProviderSpecificSQLite";
            tableLayoutPanelProviderSpecificSQLite.RowCount = 1;
            tableLayoutPanelProviderSpecificSQLite.RowStyles.Add(new RowStyle());
            tableLayoutPanelProviderSpecificSQLite.Size = new Size(718, 39);
            tableLayoutPanelProviderSpecificSQLite.TabIndex = 9;
            // 
            // labelDbSource
            // 
            labelDbSource.Anchor = AnchorStyles.Left;
            labelDbSource.AutoSize = true;
            labelDbSource.Font = new Font("Segoe UI", 11.25F);
            labelDbSource.Location = new Point(3, 9);
            labelDbSource.Name = "labelDbSource";
            labelDbSource.Size = new Size(79, 20);
            labelDbSource.TabIndex = 11;
            labelDbSource.Text = "File source";
            labelDbSource.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxFileSource
            // 
            textBoxFileSource.AllowDrop = true;
            textBoxFileSource.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
            textBoxFileSource.BackColor = SystemColors.ButtonHighlight;
            textBoxFileSource.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point,  204);
            textBoxFileSource.Location = new Point(125, 8);
            textBoxFileSource.Name = "textBoxFileSource";
            textBoxFileSource.PlaceholderText = "Drop or select SQLite Database file";
            textBoxFileSource.ReadOnly = true;
            textBoxFileSource.Size = new Size(495, 23);
            textBoxFileSource.TabIndex = 12;
            textBoxFileSource.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonResetFileSource
            // 
            buttonResetFileSource.Anchor = AnchorStyles.None;
            buttonResetFileSource.BackColor = Color.Transparent;
            buttonResetFileSource.BackgroundImage = Properties.Resources.ResetImage;
            buttonResetFileSource.BackgroundImageLayout = ImageLayout.Zoom;
            buttonResetFileSource.FlatAppearance.BorderSize = 0;
            buttonResetFileSource.FlatStyle = FlatStyle.Flat;
            buttonResetFileSource.Location = new Point(702, 8);
            buttonResetFileSource.Name = "buttonResetFileSource";
            buttonResetFileSource.Size = new Size(12, 23);
            buttonResetFileSource.TabIndex = 10;
            buttonResetFileSource.UseVisualStyleBackColor = false;
            // 
            // buttonSelectFileSource
            // 
            buttonSelectFileSource.Anchor = AnchorStyles.None;
            buttonSelectFileSource.Location = new Point(626, 3);
            buttonSelectFileSource.Name = "buttonSelectFileSource";
            buttonSelectFileSource.Size = new Size(70, 33);
            buttonSelectFileSource.TabIndex = 13;
            buttonSelectFileSource.Text = "Select file";
            buttonSelectFileSource.UseVisualStyleBackColor = true;
            buttonSelectFileSource.Click += buttonSelectFileSource_Click;
            // 
            // panelPostgreSQL
            // 
            panelPostgreSQL.AutoSize = true;
            panelPostgreSQL.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelPostgreSQL.BorderStyle = BorderStyle.FixedSingle;
            panelPostgreSQL.Controls.Add(tableLayoutPanelProviderSpecificPostgreSQL);
            panelPostgreSQL.Dock = DockStyle.Top;
            panelPostgreSQL.Location = new Point(3, 87);
            panelPostgreSQL.Name = "panelPostgreSQL";
            panelPostgreSQL.Size = new Size(720, 147);
            panelPostgreSQL.TabIndex = 11;
            // 
            // tableLayoutPanelProviderSpecificPostgreSQL
            // 
            tableLayoutPanelProviderSpecificPostgreSQL.AutoSize = true;
            tableLayoutPanelProviderSpecificPostgreSQL.ColumnCount = 3;
            tableLayoutPanelProviderSpecificPostgreSQL.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.21312F));
            tableLayoutPanelProviderSpecificPostgreSQL.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.78688F));
            tableLayoutPanelProviderSpecificPostgreSQL.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelProviderSpecificPostgreSQL.Controls.Add(buttonResetPort, 2, 1);
            tableLayoutPanelProviderSpecificPostgreSQL.Controls.Add(buttonResetHost, 2, 0);
            tableLayoutPanelProviderSpecificPostgreSQL.Controls.Add(labelHost, 0, 0);
            tableLayoutPanelProviderSpecificPostgreSQL.Controls.Add(labelPort, 0, 1);
            tableLayoutPanelProviderSpecificPostgreSQL.Controls.Add(labelUsername, 0, 2);
            tableLayoutPanelProviderSpecificPostgreSQL.Controls.Add(labelPassword, 0, 3);
            tableLayoutPanelProviderSpecificPostgreSQL.Controls.Add(buttonResetUsername, 2, 2);
            tableLayoutPanelProviderSpecificPostgreSQL.Controls.Add(buttonResetPassword, 2, 3);
            tableLayoutPanelProviderSpecificPostgreSQL.Controls.Add(textBoxHost, 1, 0);
            tableLayoutPanelProviderSpecificPostgreSQL.Controls.Add(textBoxPort, 1, 1);
            tableLayoutPanelProviderSpecificPostgreSQL.Controls.Add(textBoxUsername, 1, 2);
            tableLayoutPanelProviderSpecificPostgreSQL.Controls.Add(textBoxPassword, 1, 3);
            tableLayoutPanelProviderSpecificPostgreSQL.Controls.Add(textBoxDatabase, 1, 4);
            tableLayoutPanelProviderSpecificPostgreSQL.Controls.Add(labelDatabase, 0, 4);
            tableLayoutPanelProviderSpecificPostgreSQL.Controls.Add(button1, 2, 4);
            tableLayoutPanelProviderSpecificPostgreSQL.Dock = DockStyle.Fill;
            tableLayoutPanelProviderSpecificPostgreSQL.Location = new Point(0, 0);
            tableLayoutPanelProviderSpecificPostgreSQL.Name = "tableLayoutPanelProviderSpecificPostgreSQL";
            tableLayoutPanelProviderSpecificPostgreSQL.RowCount = 5;
            tableLayoutPanelProviderSpecificPostgreSQL.RowStyles.Add(new RowStyle());
            tableLayoutPanelProviderSpecificPostgreSQL.RowStyles.Add(new RowStyle());
            tableLayoutPanelProviderSpecificPostgreSQL.RowStyles.Add(new RowStyle());
            tableLayoutPanelProviderSpecificPostgreSQL.RowStyles.Add(new RowStyle());
            tableLayoutPanelProviderSpecificPostgreSQL.RowStyles.Add(new RowStyle());
            tableLayoutPanelProviderSpecificPostgreSQL.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelProviderSpecificPostgreSQL.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelProviderSpecificPostgreSQL.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelProviderSpecificPostgreSQL.Size = new Size(718, 145);
            tableLayoutPanelProviderSpecificPostgreSQL.TabIndex = 9;
            // 
            // buttonResetPort
            // 
            buttonResetPort.Anchor = AnchorStyles.None;
            buttonResetPort.BackColor = Color.Transparent;
            buttonResetPort.BackgroundImage = Properties.Resources.ResetImage;
            buttonResetPort.BackgroundImageLayout = ImageLayout.Zoom;
            buttonResetPort.FlatAppearance.BorderSize = 0;
            buttonResetPort.FlatStyle = FlatStyle.Flat;
            buttonResetPort.Location = new Point(701, 32);
            buttonResetPort.Name = "buttonResetPort";
            buttonResetPort.Size = new Size(13, 23);
            buttonResetPort.TabIndex = 11;
            buttonResetPort.UseVisualStyleBackColor = false;
            // 
            // buttonResetHost
            // 
            buttonResetHost.Anchor = AnchorStyles.None;
            buttonResetHost.BackColor = Color.Transparent;
            buttonResetHost.BackgroundImage = Properties.Resources.ResetImage;
            buttonResetHost.BackgroundImageLayout = ImageLayout.Zoom;
            buttonResetHost.FlatAppearance.BorderSize = 0;
            buttonResetHost.FlatStyle = FlatStyle.Flat;
            buttonResetHost.Location = new Point(701, 3);
            buttonResetHost.Name = "buttonResetHost";
            buttonResetHost.Size = new Size(13, 23);
            buttonResetHost.TabIndex = 11;
            buttonResetHost.UseVisualStyleBackColor = false;
            // 
            // labelHost
            // 
            labelHost.Anchor = AnchorStyles.Left;
            labelHost.AutoSize = true;
            labelHost.Font = new Font("Segoe UI", 11.25F);
            labelHost.Location = new Point(3, 4);
            labelHost.Name = "labelHost";
            labelHost.Size = new Size(40, 20);
            labelHost.TabIndex = 11;
            labelHost.Text = "Host";
            labelHost.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelPort
            // 
            labelPort.Anchor = AnchorStyles.Left;
            labelPort.AutoSize = true;
            labelPort.Font = new Font("Segoe UI", 11.25F);
            labelPort.Location = new Point(3, 33);
            labelPort.Name = "labelPort";
            labelPort.Size = new Size(35, 20);
            labelPort.TabIndex = 12;
            labelPort.Text = "Port";
            // 
            // labelUsername
            // 
            labelUsername.Anchor = AnchorStyles.Left;
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 11.25F);
            labelUsername.Location = new Point(3, 62);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(75, 20);
            labelUsername.TabIndex = 13;
            labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            labelPassword.Anchor = AnchorStyles.Left;
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 11.25F);
            labelPassword.Location = new Point(3, 91);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(70, 20);
            labelPassword.TabIndex = 14;
            labelPassword.Text = "Password";
            // 
            // buttonResetUsername
            // 
            buttonResetUsername.Anchor = AnchorStyles.None;
            buttonResetUsername.BackColor = Color.Transparent;
            buttonResetUsername.BackgroundImage = Properties.Resources.ResetImage;
            buttonResetUsername.BackgroundImageLayout = ImageLayout.Zoom;
            buttonResetUsername.FlatAppearance.BorderSize = 0;
            buttonResetUsername.FlatStyle = FlatStyle.Flat;
            buttonResetUsername.Location = new Point(701, 61);
            buttonResetUsername.Name = "buttonResetUsername";
            buttonResetUsername.Size = new Size(13, 23);
            buttonResetUsername.TabIndex = 15;
            buttonResetUsername.UseVisualStyleBackColor = false;
            // 
            // buttonResetPassword
            // 
            buttonResetPassword.Anchor = AnchorStyles.None;
            buttonResetPassword.BackColor = Color.Transparent;
            buttonResetPassword.BackgroundImage = Properties.Resources.ResetImage;
            buttonResetPassword.BackgroundImageLayout = ImageLayout.Zoom;
            buttonResetPassword.FlatAppearance.BorderSize = 0;
            buttonResetPassword.FlatStyle = FlatStyle.Flat;
            buttonResetPassword.Location = new Point(701, 90);
            buttonResetPassword.Name = "buttonResetPassword";
            buttonResetPassword.Size = new Size(13, 23);
            buttonResetPassword.TabIndex = 16;
            buttonResetPassword.UseVisualStyleBackColor = false;
            // 
            // textBoxHost
            // 
            textBoxHost.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
            textBoxHost.Location = new Point(123, 3);
            textBoxHost.Name = "textBoxHost";
            textBoxHost.Size = new Size(571, 23);
            textBoxHost.TabIndex = 17;
            // 
            // textBoxPort
            // 
            textBoxPort.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
            textBoxPort.Location = new Point(123, 32);
            textBoxPort.Name = "textBoxPort";
            textBoxPort.Size = new Size(571, 23);
            textBoxPort.TabIndex = 18;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
            textBoxUsername.Location = new Point(123, 61);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(571, 23);
            textBoxUsername.TabIndex = 19;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
            textBoxPassword.Location = new Point(123, 90);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(571, 23);
            textBoxPassword.TabIndex = 20;
            // 
            // textBoxDatabase
            // 
            textBoxDatabase.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
            textBoxDatabase.Location = new Point(123, 119);
            textBoxDatabase.Name = "textBoxDatabase";
            textBoxDatabase.Size = new Size(571, 23);
            textBoxDatabase.TabIndex = 22;
            // 
            // labelDatabase
            // 
            labelDatabase.Anchor = AnchorStyles.Left;
            labelDatabase.AutoSize = true;
            labelDatabase.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point,  204);
            labelDatabase.Location = new Point(3, 120);
            labelDatabase.Name = "labelDatabase";
            labelDatabase.Size = new Size(72, 20);
            labelDatabase.TabIndex = 21;
            labelDatabase.Text = "Database";
            labelDatabase.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.ResetImage;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(701, 119);
            button1.Name = "button1";
            button1.Size = new Size(13, 23);
            button1.TabIndex = 23;
            button1.UseVisualStyleBackColor = false;
            // 
            // FormConnection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 308);
            Controls.Add(panelRoot);
            Name = "FormConnection";
            Text = "Connection settings";
            panelRoot.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tableLayoutPanelRoot.ResumeLayout(false);
            tableLayoutPanelRoot.PerformLayout();
            tableLayoutPanelConnectionFieldsRoot.ResumeLayout(false);
            tableLayoutPanelConnectionFieldsRoot.PerformLayout();
            panelProvider.ResumeLayout(false);
            panelProvider.PerformLayout();
            tableLayoutPanelProviderChoose.ResumeLayout(false);
            tableLayoutPanelProviderChoose.PerformLayout();
            panelSQLite.ResumeLayout(false);
            panelSQLite.PerformLayout();
            tableLayoutPanelProviderSpecificSQLite.ResumeLayout(false);
            tableLayoutPanelProviderSpecificSQLite.PerformLayout();
            panelPostgreSQL.ResumeLayout(false);
            panelPostgreSQL.PerformLayout();
            tableLayoutPanelProviderSpecificPostgreSQL.ResumeLayout(false);
            tableLayoutPanelProviderSpecificPostgreSQL.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonSaveAndClose;
        private Label labelConnectionStatusTitle;
        private Label labelConnectionStatus;
        private Button buttonTestConnection;
        private Panel panelRoot;
        private TableLayoutPanel tableLayoutPanelRoot;
        private Panel panelSQLite;
        private TableLayoutPanel tableLayoutPanelProviderSpecificSQLite;
        private Button buttonResetFileSource;
        private Label labelDbSource;
        private TextBox textBoxFileSource;
        private TableLayoutPanel tableLayoutPanelConnectionFieldsRoot;
        private Panel panelProvider;
        private TableLayoutPanel tableLayoutPanelProviderChoose;
        private Label labelProviderChoose;
        private ComboBox comboBoxDbProvider;
        private Panel panelPostgreSQL;
        private TableLayoutPanel tableLayoutPanelProviderSpecificPostgreSQL;
        private Label labelHost;
        private Button buttonSelectFileSource;
        private Button buttonResetPort;
        private Button buttonResetHost;
        private Label labelPort;
        private Label labelUsername;
        private Label labelPassword;
        private Button buttonResetUsername;
        private Button buttonResetPassword;
        private TextBox textBoxHost;
        private TextBox textBoxPort;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label labelDatabase;
        private TextBox textBoxDatabase;
        private Button button1;
    }
}