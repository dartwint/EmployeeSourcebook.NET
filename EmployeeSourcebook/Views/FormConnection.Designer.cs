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
            flowLayoutPanelRootContainer = new FlowLayoutPanel();
            tableLayoutPanelConnectionData = new TableLayoutPanel();
            labelProvider = new Label();
            comboBoxProvider = new ComboBox();
            panelProviderSpecificRoot = new Panel();
            flowLayoutPanelSpecificRoot = new FlowLayoutPanel();
            panelWithBorders1 = new Panel();
            tableLayoutPanelProviderPostgreSQL = new TableLayoutPanel();
            buttonResetPort = new Button();
            textBoxPort = new TextBox();
            labelPort = new Label();
            buttonResetUsername = new Button();
            textBoxUsername = new TextBox();
            labelUsername = new Label();
            buttonResetPassword = new Button();
            textBoxPassword = new TextBox();
            labelPassword = new Label();
            labelHost = new Label();
            textBoxHost = new TextBox();
            buttonResetHost = new Button();
            panelWithBorders2 = new Panel();
            tableLayoutPanelProviderSQLite = new TableLayoutPanel();
            buttonResetFileSource = new Button();
            labelDbSource = new Label();
            panelMargin = new Panel();
            tableLayoutPanelControls = new TableLayoutPanel();
            labelConnectionStatusTitle = new Label();
            labelConnectionStatus = new Label();
            buttonTestConnection = new Button();
            flowLayoutPanelRootContainer.SuspendLayout();
            tableLayoutPanelConnectionData.SuspendLayout();
            panelProviderSpecificRoot.SuspendLayout();
            flowLayoutPanelSpecificRoot.SuspendLayout();
            panelWithBorders1.SuspendLayout();
            tableLayoutPanelProviderPostgreSQL.SuspendLayout();
            panelWithBorders2.SuspendLayout();
            tableLayoutPanelProviderSQLite.SuspendLayout();
            tableLayoutPanelControls.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSaveAndClose
            // 
            buttonSaveAndClose.Anchor = AnchorStyles.Bottom;
            buttonSaveAndClose.BackColor = SystemColors.GradientActiveCaption;
            buttonSaveAndClose.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point,  204);
            buttonSaveAndClose.Location = new Point(4, 339);
            buttonSaveAndClose.Margin = new Padding(4, 5, 4, 5);
            buttonSaveAndClose.Name = "buttonSaveAndClose";
            buttonSaveAndClose.Size = new Size(277, 95);
            buttonSaveAndClose.TabIndex = 5;
            buttonSaveAndClose.Text = "Save and close";
            buttonSaveAndClose.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanelRootContainer
            // 
            flowLayoutPanelRootContainer.AutoScroll = true;
            flowLayoutPanelRootContainer.AutoSize = true;
            flowLayoutPanelRootContainer.BackColor = SystemColors.Info;
            flowLayoutPanelRootContainer.Controls.Add(tableLayoutPanelConnectionData);
            flowLayoutPanelRootContainer.Controls.Add(panelMargin);
            flowLayoutPanelRootContainer.Controls.Add(tableLayoutPanelControls);
            flowLayoutPanelRootContainer.Dock = DockStyle.Fill;
            flowLayoutPanelRootContainer.Location = new Point(0, 0);
            flowLayoutPanelRootContainer.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanelRootContainer.Name = "flowLayoutPanelRootContainer";
            flowLayoutPanelRootContainer.Size = new Size(1123, 858);
            flowLayoutPanelRootContainer.TabIndex = 6;
            flowLayoutPanelRootContainer.WrapContents = false;
            // 
            // tableLayoutPanelConnectionData
            // 
            tableLayoutPanelConnectionData.Anchor = AnchorStyles.Left;
            tableLayoutPanelConnectionData.ColumnCount = 2;
            tableLayoutPanelConnectionData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.8580246F));
            tableLayoutPanelConnectionData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.1419754F));
            tableLayoutPanelConnectionData.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelConnectionData.Controls.Add(labelProvider, 0, 0);
            tableLayoutPanelConnectionData.Controls.Add(comboBoxProvider, 1, 0);
            tableLayoutPanelConnectionData.Controls.Add(panelProviderSpecificRoot, 0, 1);
            tableLayoutPanelConnectionData.Location = new Point(4, 5);
            tableLayoutPanelConnectionData.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanelConnectionData.Name = "tableLayoutPanelConnectionData";
            tableLayoutPanelConnectionData.RowCount = 2;
            tableLayoutPanelConnectionData.RowStyles.Add(new RowStyle(SizeType.Percent, 19.3877544F));
            tableLayoutPanelConnectionData.RowStyles.Add(new RowStyle(SizeType.Percent, 80.61224F));
            tableLayoutPanelConnectionData.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelConnectionData.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelConnectionData.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelConnectionData.Size = new Size(648, 439);
            tableLayoutPanelConnectionData.TabIndex = 3;
            // 
            // labelProvider
            // 
            labelProvider.AutoSize = true;
            labelProvider.Dock = DockStyle.Fill;
            labelProvider.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  204);
            labelProvider.Location = new Point(4, 0);
            labelProvider.Margin = new Padding(4, 0, 4, 0);
            labelProvider.Name = "labelProvider";
            labelProvider.Size = new Size(179, 85);
            labelProvider.TabIndex = 12;
            labelProvider.Text = "Provider";
            labelProvider.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxProvider
            // 
            comboBoxProvider.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
            comboBoxProvider.FormattingEnabled = true;
            comboBoxProvider.Location = new Point(191, 26);
            comboBoxProvider.Margin = new Padding(4, 5, 4, 5);
            comboBoxProvider.Name = "comboBoxProvider";
            comboBoxProvider.Size = new Size(453, 33);
            comboBoxProvider.TabIndex = 13;
            comboBoxProvider.SelectionChangeCommitted += comboBoxProvider_SelectionChangeCommitted;
            // 
            // panelProviderSpecificRoot
            // 
            tableLayoutPanelConnectionData.SetColumnSpan(panelProviderSpecificRoot, 2);
            panelProviderSpecificRoot.Controls.Add(flowLayoutPanelSpecificRoot);
            panelProviderSpecificRoot.Dock = DockStyle.Fill;
            panelProviderSpecificRoot.Location = new Point(1, 86);
            panelProviderSpecificRoot.Margin = new Padding(1);
            panelProviderSpecificRoot.Name = "panelProviderSpecificRoot";
            panelProviderSpecificRoot.Size = new Size(646, 352);
            panelProviderSpecificRoot.TabIndex = 7;
            // 
            // flowLayoutPanelSpecificRoot
            // 
            flowLayoutPanelSpecificRoot.AutoScroll = true;
            flowLayoutPanelSpecificRoot.Controls.Add(panelWithBorders1);
            flowLayoutPanelSpecificRoot.Controls.Add(panelWithBorders2);
            flowLayoutPanelSpecificRoot.Dock = DockStyle.Fill;
            flowLayoutPanelSpecificRoot.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelSpecificRoot.Location = new Point(0, 0);
            flowLayoutPanelSpecificRoot.Name = "flowLayoutPanelSpecificRoot";
            flowLayoutPanelSpecificRoot.Size = new Size(646, 352);
            flowLayoutPanelSpecificRoot.TabIndex = 7;
            flowLayoutPanelSpecificRoot.WrapContents = false;
            // 
            // panelWithBorders1
            // 
            panelWithBorders1.AutoSize = true;
            panelWithBorders1.BorderStyle = BorderStyle.FixedSingle;
            panelWithBorders1.Controls.Add(tableLayoutPanelProviderPostgreSQL);
            panelWithBorders1.Dock = DockStyle.Top;
            panelWithBorders1.Location = new Point(3, 3);
            panelWithBorders1.Name = "panelWithBorders1";
            panelWithBorders1.Size = new Size(961, 194);
            panelWithBorders1.TabIndex = 13;
            // 
            // tableLayoutPanelProviderPostgreSQL
            // 
            tableLayoutPanelProviderPostgreSQL.AutoSize = true;
            tableLayoutPanelProviderPostgreSQL.ColumnCount = 3;
            tableLayoutPanelProviderPostgreSQL.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.14226F));
            tableLayoutPanelProviderPostgreSQL.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.84937F));
            tableLayoutPanelProviderPostgreSQL.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.89655161F));
            tableLayoutPanelProviderPostgreSQL.Controls.Add(buttonResetPort, 2, 3);
            tableLayoutPanelProviderPostgreSQL.Controls.Add(textBoxPort, 1, 3);
            tableLayoutPanelProviderPostgreSQL.Controls.Add(labelPort, 0, 3);
            tableLayoutPanelProviderPostgreSQL.Controls.Add(buttonResetUsername, 2, 2);
            tableLayoutPanelProviderPostgreSQL.Controls.Add(textBoxUsername, 1, 2);
            tableLayoutPanelProviderPostgreSQL.Controls.Add(labelUsername, 0, 2);
            tableLayoutPanelProviderPostgreSQL.Controls.Add(buttonResetPassword, 2, 1);
            tableLayoutPanelProviderPostgreSQL.Controls.Add(textBoxPassword, 1, 1);
            tableLayoutPanelProviderPostgreSQL.Controls.Add(labelPassword, 0, 1);
            tableLayoutPanelProviderPostgreSQL.Controls.Add(labelHost, 0, 0);
            tableLayoutPanelProviderPostgreSQL.Controls.Add(textBoxHost, 1, 0);
            tableLayoutPanelProviderPostgreSQL.Controls.Add(buttonResetHost, 2, 0);
            tableLayoutPanelProviderPostgreSQL.Dock = DockStyle.Fill;
            tableLayoutPanelProviderPostgreSQL.Location = new Point(0, 0);
            tableLayoutPanelProviderPostgreSQL.Name = "tableLayoutPanelProviderPostgreSQL";
            tableLayoutPanelProviderPostgreSQL.RowCount = 4;
            tableLayoutPanelProviderPostgreSQL.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelProviderPostgreSQL.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelProviderPostgreSQL.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelProviderPostgreSQL.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelProviderPostgreSQL.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelProviderPostgreSQL.Size = new Size(959, 192);
            tableLayoutPanelProviderPostgreSQL.TabIndex = 8;
            // 
            // buttonResetPort
            // 
            buttonResetPort.BackColor = Color.Transparent;
            buttonResetPort.BackgroundImage = Properties.Resources.ResetImage;
            buttonResetPort.BackgroundImageLayout = ImageLayout.Stretch;
            buttonResetPort.Dock = DockStyle.Fill;
            buttonResetPort.FlatAppearance.BorderSize = 0;
            buttonResetPort.FlatStyle = FlatStyle.Flat;
            buttonResetPort.Location = new Point(896, 149);
            buttonResetPort.Margin = new Padding(4, 5, 4, 5);
            buttonResetPort.Name = "buttonResetPort";
            buttonResetPort.Size = new Size(59, 38);
            buttonResetPort.TabIndex = 9;
            buttonResetPort.UseVisualStyleBackColor = false;
            // 
            // textBoxPort
            // 
            textBoxPort.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
            textBoxPort.Location = new Point(187, 152);
            textBoxPort.Margin = new Padding(4, 5, 4, 5);
            textBoxPort.Name = "textBoxPort";
            textBoxPort.PlaceholderText = "5432";
            textBoxPort.Size = new Size(701, 31);
            textBoxPort.TabIndex = 5;
            // 
            // labelPort
            // 
            labelPort.AutoSize = true;
            labelPort.Dock = DockStyle.Fill;
            labelPort.Font = new Font("Segoe UI", 11.25F);
            labelPort.Location = new Point(4, 144);
            labelPort.Margin = new Padding(4, 0, 4, 0);
            labelPort.Name = "labelPort";
            labelPort.Size = new Size(175, 48);
            labelPort.TabIndex = 2;
            labelPort.Text = "Port";
            labelPort.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonResetUsername
            // 
            buttonResetUsername.BackColor = Color.Transparent;
            buttonResetUsername.BackgroundImage = Properties.Resources.ResetImage;
            buttonResetUsername.BackgroundImageLayout = ImageLayout.Stretch;
            buttonResetUsername.Dock = DockStyle.Fill;
            buttonResetUsername.FlatAppearance.BorderSize = 0;
            buttonResetUsername.FlatStyle = FlatStyle.Flat;
            buttonResetUsername.Location = new Point(896, 101);
            buttonResetUsername.Margin = new Padding(4, 5, 4, 5);
            buttonResetUsername.Name = "buttonResetUsername";
            buttonResetUsername.Size = new Size(59, 38);
            buttonResetUsername.TabIndex = 10;
            buttonResetUsername.UseVisualStyleBackColor = false;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
            textBoxUsername.Location = new Point(187, 104);
            textBoxUsername.Margin = new Padding(4, 5, 4, 5);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.PlaceholderText = "postgres";
            textBoxUsername.Size = new Size(701, 31);
            textBoxUsername.TabIndex = 6;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Dock = DockStyle.Fill;
            labelUsername.Font = new Font("Segoe UI", 11.25F);
            labelUsername.Location = new Point(4, 96);
            labelUsername.Margin = new Padding(4, 0, 4, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(175, 48);
            labelUsername.TabIndex = 3;
            labelUsername.Text = "Username";
            labelUsername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonResetPassword
            // 
            buttonResetPassword.BackColor = Color.Transparent;
            buttonResetPassword.BackgroundImage = Properties.Resources.ResetImage;
            buttonResetPassword.BackgroundImageLayout = ImageLayout.Stretch;
            buttonResetPassword.Dock = DockStyle.Fill;
            buttonResetPassword.FlatAppearance.BorderSize = 0;
            buttonResetPassword.FlatStyle = FlatStyle.Flat;
            buttonResetPassword.Location = new Point(896, 53);
            buttonResetPassword.Margin = new Padding(4, 5, 4, 5);
            buttonResetPassword.Name = "buttonResetPassword";
            buttonResetPassword.Size = new Size(59, 38);
            buttonResetPassword.TabIndex = 11;
            buttonResetPassword.UseVisualStyleBackColor = false;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
            textBoxPassword.Location = new Point(187, 56);
            textBoxPassword.Margin = new Padding(4, 5, 4, 5);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "masterkey";
            textBoxPassword.Size = new Size(701, 31);
            textBoxPassword.TabIndex = 7;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Dock = DockStyle.Fill;
            labelPassword.Font = new Font("Segoe UI", 11.25F);
            labelPassword.Location = new Point(4, 48);
            labelPassword.Margin = new Padding(4, 0, 4, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(175, 48);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Password";
            labelPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelHost
            // 
            labelHost.AutoSize = true;
            labelHost.Dock = DockStyle.Fill;
            labelHost.Font = new Font("Segoe UI", 11.25F);
            labelHost.Location = new Point(4, 0);
            labelHost.Margin = new Padding(4, 0, 4, 0);
            labelHost.Name = "labelHost";
            labelHost.Size = new Size(175, 48);
            labelHost.TabIndex = 1;
            labelHost.Text = "Host";
            labelHost.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxHost
            // 
            textBoxHost.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
            textBoxHost.Location = new Point(187, 8);
            textBoxHost.Margin = new Padding(4, 5, 4, 5);
            textBoxHost.Name = "textBoxHost";
            textBoxHost.PlaceholderText = "localhost";
            textBoxHost.Size = new Size(701, 31);
            textBoxHost.TabIndex = 0;
            // 
            // buttonResetHost
            // 
            buttonResetHost.BackColor = Color.Transparent;
            buttonResetHost.BackgroundImage = Properties.Resources.ResetImage;
            buttonResetHost.BackgroundImageLayout = ImageLayout.Stretch;
            buttonResetHost.Dock = DockStyle.Fill;
            buttonResetHost.FlatAppearance.BorderSize = 0;
            buttonResetHost.FlatStyle = FlatStyle.Flat;
            buttonResetHost.Location = new Point(896, 5);
            buttonResetHost.Margin = new Padding(4, 5, 4, 5);
            buttonResetHost.Name = "buttonResetHost";
            buttonResetHost.Size = new Size(59, 38);
            buttonResetHost.TabIndex = 8;
            buttonResetHost.UseVisualStyleBackColor = false;
            // 
            // panelWithBorders2
            // 
            panelWithBorders2.AutoSize = true;
            panelWithBorders2.BorderStyle = BorderStyle.FixedSingle;
            panelWithBorders2.Controls.Add(tableLayoutPanelProviderSQLite);
            panelWithBorders2.Dock = DockStyle.Top;
            panelWithBorders2.Location = new Point(3, 203);
            panelWithBorders2.Name = "panelWithBorders2";
            panelWithBorders2.Size = new Size(961, 50);
            panelWithBorders2.TabIndex = 14;
            // 
            // tableLayoutPanelProviderSQLite
            // 
            tableLayoutPanelProviderSQLite.AutoSize = true;
            tableLayoutPanelProviderSQLite.ColumnCount = 3;
            tableLayoutPanelProviderSQLite.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.14226F));
            tableLayoutPanelProviderSQLite.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.5564842F));
            tableLayoutPanelProviderSQLite.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.173912F));
            tableLayoutPanelProviderSQLite.Controls.Add(buttonResetFileSource, 2, 0);
            tableLayoutPanelProviderSQLite.Controls.Add(labelDbSource, 0, 0);
            tableLayoutPanelProviderSQLite.Dock = DockStyle.Fill;
            tableLayoutPanelProviderSQLite.Location = new Point(0, 0);
            tableLayoutPanelProviderSQLite.Name = "tableLayoutPanelProviderSQLite";
            tableLayoutPanelProviderSQLite.RowCount = 1;
            tableLayoutPanelProviderSQLite.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelProviderSQLite.Size = new Size(959, 48);
            tableLayoutPanelProviderSQLite.TabIndex = 12;
            // 
            // buttonResetFileSource
            // 
            buttonResetFileSource.BackColor = Color.Transparent;
            buttonResetFileSource.BackgroundImage = Properties.Resources.ResetImage;
            buttonResetFileSource.BackgroundImageLayout = ImageLayout.Stretch;
            buttonResetFileSource.Dock = DockStyle.Fill;
            buttonResetFileSource.FlatAppearance.BorderSize = 0;
            buttonResetFileSource.FlatStyle = FlatStyle.Flat;
            buttonResetFileSource.Location = new Point(701, 5);
            buttonResetFileSource.Margin = new Padding(4, 5, 4, 5);
            buttonResetFileSource.Name = "buttonResetFileSource";
            buttonResetFileSource.Size = new Size(254, 38);
            buttonResetFileSource.TabIndex = 15;
            buttonResetFileSource.UseVisualStyleBackColor = false;
            // 
            // labelDbSource
            // 
            labelDbSource.AutoSize = true;
            labelDbSource.Dock = DockStyle.Fill;
            labelDbSource.Font = new Font("Segoe UI", 11.25F);
            labelDbSource.Location = new Point(4, 0);
            labelDbSource.Margin = new Padding(4, 0, 4, 0);
            labelDbSource.Name = "labelDbSource";
            labelDbSource.Size = new Size(175, 48);
            labelDbSource.TabIndex = 2;
            labelDbSource.Text = "File source";
            labelDbSource.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelMargin
            // 
            panelMargin.Anchor =  AnchorStyles.Top | AnchorStyles.Bottom;
            panelMargin.Location = new Point(659, 3);
            panelMargin.Name = "panelMargin";
            panelMargin.Size = new Size(46, 443);
            panelMargin.TabIndex = 7;
            // 
            // tableLayoutPanelControls
            // 
            tableLayoutPanelControls.Anchor =  AnchorStyles.Top | AnchorStyles.Bottom;
            tableLayoutPanelControls.ColumnCount = 1;
            tableLayoutPanelControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelControls.Controls.Add(labelConnectionStatusTitle, 0, 0);
            tableLayoutPanelControls.Controls.Add(labelConnectionStatus, 0, 1);
            tableLayoutPanelControls.Controls.Add(buttonSaveAndClose, 0, 3);
            tableLayoutPanelControls.Controls.Add(buttonTestConnection, 0, 2);
            tableLayoutPanelControls.Location = new Point(712, 5);
            tableLayoutPanelControls.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanelControls.Name = "tableLayoutPanelControls";
            tableLayoutPanelControls.RowCount = 4;
            tableLayoutPanelControls.RowStyles.Add(new RowStyle(SizeType.Percent, 11.9148922F));
            tableLayoutPanelControls.RowStyles.Add(new RowStyle(SizeType.Percent, 8.794327F));
            tableLayoutPanelControls.RowStyles.Add(new RowStyle(SizeType.Percent, 29.3367348F));
            tableLayoutPanelControls.RowStyles.Add(new RowStyle(SizeType.Percent, 50.2551F));
            tableLayoutPanelControls.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelControls.Size = new Size(286, 439);
            tableLayoutPanelControls.TabIndex = 6;
            // 
            // labelConnectionStatusTitle
            // 
            labelConnectionStatusTitle.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
            labelConnectionStatusTitle.AutoSize = true;
            labelConnectionStatusTitle.Font = new Font("Segoe UI", 12F);
            labelConnectionStatusTitle.Location = new Point(4, 10);
            labelConnectionStatusTitle.Margin = new Padding(4, 0, 4, 0);
            labelConnectionStatusTitle.Name = "labelConnectionStatusTitle";
            labelConnectionStatusTitle.Size = new Size(278, 32);
            labelConnectionStatusTitle.TabIndex = 6;
            labelConnectionStatusTitle.Text = "Connection status";
            labelConnectionStatusTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelConnectionStatus
            // 
            labelConnectionStatus.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
            labelConnectionStatus.AutoSize = true;
            labelConnectionStatus.BackColor = SystemColors.Info;
            labelConnectionStatus.Font = new Font("Segoe UI", 12F);
            labelConnectionStatus.Location = new Point(4, 55);
            labelConnectionStatus.Margin = new Padding(4, 0, 4, 0);
            labelConnectionStatus.Name = "labelConnectionStatus";
            labelConnectionStatus.Size = new Size(278, 32);
            labelConnectionStatus.TabIndex = 7;
            labelConnectionStatus.Text = "none";
            labelConnectionStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonTestConnection
            // 
            buttonTestConnection.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
            buttonTestConnection.BackColor = SystemColors.ButtonHighlight;
            buttonTestConnection.Location = new Point(3, 128);
            buttonTestConnection.Name = "buttonTestConnection";
            buttonTestConnection.Size = new Size(280, 51);
            buttonTestConnection.TabIndex = 8;
            buttonTestConnection.Text = "Test connection";
            buttonTestConnection.UseVisualStyleBackColor = false;
            // 
            // FormConnection
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 858);
            Controls.Add(flowLayoutPanelRootContainer);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormConnection";
            Text = "Connection settings";
            flowLayoutPanelRootContainer.ResumeLayout(false);
            tableLayoutPanelConnectionData.ResumeLayout(false);
            tableLayoutPanelConnectionData.PerformLayout();
            panelProviderSpecificRoot.ResumeLayout(false);
            flowLayoutPanelSpecificRoot.ResumeLayout(false);
            flowLayoutPanelSpecificRoot.PerformLayout();
            panelWithBorders1.ResumeLayout(false);
            panelWithBorders1.PerformLayout();
            tableLayoutPanelProviderPostgreSQL.ResumeLayout(false);
            tableLayoutPanelProviderPostgreSQL.PerformLayout();
            panelWithBorders2.ResumeLayout(false);
            panelWithBorders2.PerformLayout();
            tableLayoutPanelProviderSQLite.ResumeLayout(false);
            tableLayoutPanelProviderSQLite.PerformLayout();
            tableLayoutPanelControls.ResumeLayout(false);
            tableLayoutPanelControls.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonSaveAndClose;
        private FlowLayoutPanel flowLayoutPanelRootContainer;
        private TableLayoutPanel tableLayoutPanelControls;
        private Label labelConnectionStatusTitle;
        private Label labelConnectionStatus;
        private TableLayoutPanel tableLayoutPanelConnectionData;
        private Label labelPort;
        private TextBox textBoxHost;
        private Label labelHost;
        private Label labelUsername;
        private Label labelPassword;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private TextBox textBoxPort;
        private Button buttonResetHost;
        private Button buttonResetPort;
        private Button buttonResetUsername;
        private Label labelProvider;
        private ComboBox comboBoxProvider;
        private Button buttonResetPassword;
        private Button buttonTestConnection;
        private Panel panelProviderSpecificRoot;
        private TableLayoutPanel tableLayoutPanelProviderPostgreSQL;
        private FlowLayoutPanel flowLayoutPanelSpecificRoot;
        private TableLayoutPanel tableLayoutPanelProviderSQLite;
        private Panel panelMargin;
        private Label labelDbSource;
        private Panel panelWithBorders1;
        private Panel panelWithBorders2;
        private Button buttonResetFileSource;
    }
}