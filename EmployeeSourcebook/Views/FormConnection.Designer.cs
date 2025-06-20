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
            buttonTestConnection = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanelConnectionData = new TableLayoutPanel();
            labelPort = new Label();
            textBoxHost = new TextBox();
            labelHost = new Label();
            labelUsername = new Label();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            textBoxPort = new TextBox();
            buttonResetHost = new Button();
            buttonResetPort = new Button();
            buttonResetUsername = new Button();
            labelProvider = new Label();
            comboBoxProvider = new ComboBox();
            buttonResetPassword = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            labelConnectionStatusTitle = new Label();
            labelConnectionStatus = new Label();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanelConnectionData.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonTestConnection
            // 
            buttonTestConnection.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
            buttonTestConnection.BackColor = SystemColors.GradientActiveCaption;
            buttonTestConnection.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point,  204);
            buttonTestConnection.Location = new Point(3, 125);
            buttonTestConnection.Name = "buttonTestConnection";
            buttonTestConnection.Size = new Size(194, 57);
            buttonTestConnection.TabIndex = 5;
            buttonTestConnection.Text = "Save and test connection";
            buttonTestConnection.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.BackColor = SystemColors.Info;
            flowLayoutPanel1.Controls.Add(tableLayoutPanelConnectionData);
            flowLayoutPanel1.Controls.Add(tableLayoutPanel1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(652, 272);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanelConnectionData
            // 
            tableLayoutPanelConnectionData.ColumnCount = 3;
            tableLayoutPanelConnectionData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.35021F));
            tableLayoutPanelConnectionData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.1077347F));
            tableLayoutPanelConnectionData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.542055F));
            tableLayoutPanelConnectionData.Controls.Add(labelPort, 0, 1);
            tableLayoutPanelConnectionData.Controls.Add(textBoxHost, 1, 4);
            tableLayoutPanelConnectionData.Controls.Add(labelHost, 0, 4);
            tableLayoutPanelConnectionData.Controls.Add(labelUsername, 0, 2);
            tableLayoutPanelConnectionData.Controls.Add(labelPassword, 0, 3);
            tableLayoutPanelConnectionData.Controls.Add(textBoxPassword, 1, 3);
            tableLayoutPanelConnectionData.Controls.Add(textBoxUsername, 1, 2);
            tableLayoutPanelConnectionData.Controls.Add(textBoxPort, 1, 1);
            tableLayoutPanelConnectionData.Controls.Add(buttonResetHost, 2, 4);
            tableLayoutPanelConnectionData.Controls.Add(buttonResetPort, 2, 1);
            tableLayoutPanelConnectionData.Controls.Add(buttonResetUsername, 2, 2);
            tableLayoutPanelConnectionData.Controls.Add(labelProvider, 0, 0);
            tableLayoutPanelConnectionData.Controls.Add(comboBoxProvider, 1, 0);
            tableLayoutPanelConnectionData.Controls.Add(buttonResetPassword, 2, 3);
            tableLayoutPanelConnectionData.Location = new Point(3, 3);
            tableLayoutPanelConnectionData.Name = "tableLayoutPanelConnectionData";
            tableLayoutPanelConnectionData.RowCount = 5;
            tableLayoutPanelConnectionData.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelConnectionData.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelConnectionData.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelConnectionData.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelConnectionData.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelConnectionData.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelConnectionData.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelConnectionData.Size = new Size(435, 235);
            tableLayoutPanelConnectionData.TabIndex = 3;
            // 
            // labelPort
            // 
            labelPort.AutoSize = true;
            labelPort.Dock = DockStyle.Fill;
            labelPort.Font = new Font("Segoe UI", 11.25F);
            labelPort.Location = new Point(3, 47);
            labelPort.Name = "labelPort";
            labelPort.Size = new Size(117, 47);
            labelPort.TabIndex = 2;
            labelPort.Text = "Port";
            labelPort.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxHost
            // 
            textBoxHost.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
            textBoxHost.Location = new Point(126, 200);
            textBoxHost.Name = "textBoxHost";
            textBoxHost.PlaceholderText = "localhost";
            textBoxHost.Size = new Size(277, 23);
            textBoxHost.TabIndex = 0;
            // 
            // labelHost
            // 
            labelHost.AutoSize = true;
            labelHost.Dock = DockStyle.Fill;
            labelHost.Font = new Font("Segoe UI", 11.25F);
            labelHost.Location = new Point(3, 188);
            labelHost.Name = "labelHost";
            labelHost.Size = new Size(117, 47);
            labelHost.TabIndex = 1;
            labelHost.Text = "Host";
            labelHost.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Dock = DockStyle.Fill;
            labelUsername.Font = new Font("Segoe UI", 11.25F);
            labelUsername.Location = new Point(3, 94);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(117, 47);
            labelUsername.TabIndex = 3;
            labelUsername.Text = "Username";
            labelUsername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Dock = DockStyle.Fill;
            labelPassword.Font = new Font("Segoe UI", 11.25F);
            labelPassword.Location = new Point(3, 141);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(117, 47);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Password";
            labelPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
            textBoxPassword.Location = new Point(126, 153);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "masterkey";
            textBoxPassword.Size = new Size(277, 23);
            textBoxPassword.TabIndex = 7;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
            textBoxUsername.Location = new Point(126, 106);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.PlaceholderText = "postgres";
            textBoxUsername.Size = new Size(277, 23);
            textBoxUsername.TabIndex = 6;
            // 
            // textBoxPort
            // 
            textBoxPort.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
            textBoxPort.Location = new Point(126, 59);
            textBoxPort.Name = "textBoxPort";
            textBoxPort.PlaceholderText = "5432";
            textBoxPort.Size = new Size(277, 23);
            textBoxPort.TabIndex = 5;
            // 
            // buttonResetHost
            // 
            buttonResetHost.Anchor = AnchorStyles.Left;
            buttonResetHost.BackColor = Color.Transparent;
            buttonResetHost.BackgroundImage = Properties.Resources.ResetImage;
            buttonResetHost.BackgroundImageLayout = ImageLayout.Stretch;
            buttonResetHost.FlatAppearance.BorderSize = 0;
            buttonResetHost.FlatStyle = FlatStyle.Flat;
            buttonResetHost.Location = new Point(409, 200);
            buttonResetHost.Name = "buttonResetHost";
            buttonResetHost.Size = new Size(22, 23);
            buttonResetHost.TabIndex = 8;
            buttonResetHost.UseVisualStyleBackColor = false;
            // 
            // buttonResetPort
            // 
            buttonResetPort.Anchor = AnchorStyles.Left;
            buttonResetPort.BackColor = Color.Transparent;
            buttonResetPort.BackgroundImage = Properties.Resources.ResetImage;
            buttonResetPort.BackgroundImageLayout = ImageLayout.Stretch;
            buttonResetPort.FlatAppearance.BorderSize = 0;
            buttonResetPort.FlatStyle = FlatStyle.Flat;
            buttonResetPort.Location = new Point(409, 59);
            buttonResetPort.Name = "buttonResetPort";
            buttonResetPort.Size = new Size(22, 23);
            buttonResetPort.TabIndex = 9;
            buttonResetPort.UseVisualStyleBackColor = false;
            // 
            // buttonResetUsername
            // 
            buttonResetUsername.Anchor = AnchorStyles.Left;
            buttonResetUsername.BackColor = Color.Transparent;
            buttonResetUsername.BackgroundImage = Properties.Resources.ResetImage;
            buttonResetUsername.BackgroundImageLayout = ImageLayout.Stretch;
            buttonResetUsername.FlatAppearance.BorderSize = 0;
            buttonResetUsername.FlatStyle = FlatStyle.Flat;
            buttonResetUsername.Location = new Point(409, 106);
            buttonResetUsername.Name = "buttonResetUsername";
            buttonResetUsername.Size = new Size(22, 23);
            buttonResetUsername.TabIndex = 10;
            buttonResetUsername.UseVisualStyleBackColor = false;
            // 
            // labelProvider
            // 
            labelProvider.AutoSize = true;
            labelProvider.Dock = DockStyle.Fill;
            labelProvider.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  204);
            labelProvider.Location = new Point(3, 0);
            labelProvider.Name = "labelProvider";
            labelProvider.Size = new Size(117, 47);
            labelProvider.TabIndex = 12;
            labelProvider.Text = "Provider";
            labelProvider.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxProvider
            // 
            comboBoxProvider.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelConnectionData.SetColumnSpan(comboBoxProvider, 2);
            comboBoxProvider.FormattingEnabled = true;
            comboBoxProvider.Location = new Point(126, 12);
            comboBoxProvider.Name = "comboBoxProvider";
            comboBoxProvider.Size = new Size(306, 23);
            comboBoxProvider.TabIndex = 13;
            // 
            // buttonResetPassword
            // 
            buttonResetPassword.Anchor = AnchorStyles.Left;
            buttonResetPassword.BackColor = Color.Transparent;
            buttonResetPassword.BackgroundImage = Properties.Resources.ResetImage;
            buttonResetPassword.BackgroundImageLayout = ImageLayout.Stretch;
            buttonResetPassword.FlatAppearance.BorderSize = 0;
            buttonResetPassword.FlatStyle = FlatStyle.Flat;
            buttonResetPassword.Location = new Point(409, 153);
            buttonResetPassword.Name = "buttonResetPassword";
            buttonResetPassword.Size = new Size(22, 23);
            buttonResetPassword.TabIndex = 11;
            buttonResetPassword.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(buttonTestConnection, 0, 2);
            tableLayoutPanel1.Controls.Add(labelConnectionStatusTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(labelConnectionStatus, 0, 1);
            tableLayoutPanel1.Location = new Point(444, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.87234F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.19149F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 68.93617F));
            tableLayoutPanel1.Size = new Size(200, 235);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // labelConnectionStatusTitle
            // 
            labelConnectionStatusTitle.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
            labelConnectionStatusTitle.AutoSize = true;
            labelConnectionStatusTitle.Font = new Font("Segoe UI", 12F);
            labelConnectionStatusTitle.Location = new Point(3, 10);
            labelConnectionStatusTitle.Name = "labelConnectionStatusTitle";
            labelConnectionStatusTitle.Size = new Size(194, 21);
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
            labelConnectionStatus.Location = new Point(3, 46);
            labelConnectionStatus.Name = "labelConnectionStatus";
            labelConnectionStatus.Size = new Size(194, 21);
            labelConnectionStatus.TabIndex = 7;
            labelConnectionStatus.Text = "none";
            labelConnectionStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormConnection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 272);
            Controls.Add(flowLayoutPanel1);
            Name = "FormConnection";
            Text = "Connection settings";
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanelConnectionData.ResumeLayout(false);
            tableLayoutPanelConnectionData.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonTestConnection;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel1;
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
    }
}