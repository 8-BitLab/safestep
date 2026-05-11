namespace SafeStep___Desktop__WinForms_
{
    partial class Options
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
            pnlHeader = new Panel();
            lblHeaderSubtitle = new Label();
            lblHeaderTitle = new Label();
            pnlPortsCard = new Panel();
            lblPortsSubtitle = new Label();
            lblPortsTitle = new Label();
            lblPort1 = new Label();
            cmbPort1 = new ComboBox();
            lblPort2 = new Label();
            cmbPort2 = new ComboBox();
            lblPort3 = new Label();
            cmbPort3 = new ComboBox();
            lblPort4 = new Label();
            cmbPort4 = new ComboBox();
            lblBaudRate = new Label();
            cmbOptionsBaudRate = new ComboBox();
            pnlDevicesCard = new Panel();
            btnRefreshDevices = new Button();
            label3 = new Label();
            lstDevices = new ListBox();
            lblDetectedDevicesSubtitle = new Label();
            lblDetectedDevicesTitle = new Label();
            pnlSelectedDeviceCard = new Panel();
            btnSaveMapping = new Button();
            btnPairDevice = new Button();
            txtFriendlyName = new TextBox();
            lblFriendlyName = new Label();
            txtDetectedDeviceName = new TextBox();
            lblDetectedDeviceName = new Label();
            txtTagId = new TextBox();
            lblTagId = new Label();
            label1 = new Label();
            lblSelectedDeviceSubtitle = new Label();
            pnlSettingsCard = new Panel();
            btnCloseOptions = new Button();
            btnSaveOptions = new Button();
            txtFirebaseApiKey = new TextBox();
            lblFirebaseApiKey = new Label();
            txtFirebaseUrl = new TextBox();
            lblFirebaseUrl = new Label();
            rdoCloud = new RadioButton();
            rdoLocal = new RadioButton();
            lblConnectionMode = new Label();
            txtDeviceFilter = new TextBox();
            lblDeviceFilter = new Label();
            chkAutoConnect = new CheckBox();
            lblSettingsSubtitle = new Label();
            lblSettingsTitle = new Label();
            pnlHeader.SuspendLayout();
            pnlPortsCard.SuspendLayout();
            pnlDevicesCard.SuspendLayout();
            pnlSelectedDeviceCard.SuspendLayout();
            pnlSettingsCard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblHeaderSubtitle);
            pnlHeader.Controls.Add(lblHeaderTitle);
            pnlHeader.Location = new Point(20, 18);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1175, 82);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderSubtitle
            // 
            lblHeaderSubtitle.AutoSize = true;
            lblHeaderSubtitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblHeaderSubtitle.Location = new Point(24, 45);
            lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            lblHeaderSubtitle.Size = new Size(460, 17);
            lblHeaderSubtitle.TabIndex = 1;
            lblHeaderSubtitle.Text = "Manage ports, BLE devices, pairing details, and cloud connection preferences";
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeaderTitle.ForeColor = Color.FromArgb(31, 41, 55);
            lblHeaderTitle.Location = new Point(20, 8);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(225, 37);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "Desktop Settings";
            // 
            // pnlPortsCard
            // 
            pnlPortsCard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlPortsCard.BackColor = Color.White;
            pnlPortsCard.Controls.Add(lblPortsSubtitle);
            pnlPortsCard.Controls.Add(lblPortsTitle);
            pnlPortsCard.Controls.Add(lblPort1);
            pnlPortsCard.Controls.Add(cmbPort1);
            pnlPortsCard.Controls.Add(lblPort2);
            pnlPortsCard.Controls.Add(cmbPort2);
            pnlPortsCard.Controls.Add(lblPort3);
            pnlPortsCard.Controls.Add(cmbPort3);
            pnlPortsCard.Controls.Add(lblPort4);
            pnlPortsCard.Controls.Add(cmbPort4);
            pnlPortsCard.Controls.Add(lblBaudRate);
            pnlPortsCard.Controls.Add(cmbOptionsBaudRate);
            pnlPortsCard.Location = new Point(20, 118);
            pnlPortsCard.Name = "pnlPortsCard";
            pnlPortsCard.Size = new Size(1175, 126);
            pnlPortsCard.TabIndex = 1;
            // 
            // lblPortsSubtitle
            // 
            lblPortsSubtitle.AutoSize = true;
            lblPortsSubtitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblPortsSubtitle.Location = new Point(24, 47);
            lblPortsSubtitle.Name = "lblPortsSubtitle";
            lblPortsSubtitle.Size = new Size(283, 17);
            lblPortsSubtitle.TabIndex = 1;
            lblPortsSubtitle.Text = "Choose the ports used by dongles and devices";
            // 
            // lblPortsTitle
            // 
            lblPortsTitle.AutoSize = true;
            lblPortsTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPortsTitle.ForeColor = Color.FromArgb(31, 41, 55);
            lblPortsTitle.Location = new Point(20, 18);
            lblPortsTitle.Name = "lblPortsTitle";
            lblPortsTitle.Size = new Size(143, 21);
            lblPortsTitle.TabIndex = 0;
            lblPortsTitle.Text = "Ports and Serial IO";
            // 
            // lblPort1
            // 
            lblPort1.AutoSize = true;
            lblPort1.ForeColor = Color.FromArgb(55, 65, 81);
            lblPort1.Location = new Point(24, 82);
            lblPort1.Name = "lblPort1";
            lblPort1.Size = new Size(43, 17);
            lblPort1.TabIndex = 2;
            lblPort1.Text = "Port 1";
            // 
            // cmbPort1
            // 
            cmbPort1.BackColor = Color.FromArgb(249, 250, 251);
            cmbPort1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPort1.FlatStyle = FlatStyle.Flat;
            cmbPort1.FormattingEnabled = true;
            cmbPort1.Location = new Point(73, 78);
            cmbPort1.Name = "cmbPort1";
            cmbPort1.Size = new Size(130, 25);
            cmbPort1.TabIndex = 3;
            // 
            // lblPort2
            // 
            lblPort2.AutoSize = true;
            lblPort2.ForeColor = Color.FromArgb(55, 65, 81);
            lblPort2.Location = new Point(230, 82);
            lblPort2.Name = "lblPort2";
            lblPort2.Size = new Size(43, 17);
            lblPort2.TabIndex = 4;
            lblPort2.Text = "Port 2";
            // 
            // cmbPort2
            // 
            cmbPort2.BackColor = Color.FromArgb(249, 250, 251);
            cmbPort2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPort2.FlatStyle = FlatStyle.Flat;
            cmbPort2.FormattingEnabled = true;
            cmbPort2.Location = new Point(279, 78);
            cmbPort2.Name = "cmbPort2";
            cmbPort2.Size = new Size(130, 25);
            cmbPort2.TabIndex = 5;
            // 
            // lblPort3
            // 
            lblPort3.AutoSize = true;
            lblPort3.ForeColor = Color.FromArgb(55, 65, 81);
            lblPort3.Location = new Point(436, 82);
            lblPort3.Name = "lblPort3";
            lblPort3.Size = new Size(43, 17);
            lblPort3.TabIndex = 6;
            lblPort3.Text = "Port 3";
            // 
            // cmbPort3
            // 
            cmbPort3.BackColor = Color.FromArgb(249, 250, 251);
            cmbPort3.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPort3.FlatStyle = FlatStyle.Flat;
            cmbPort3.FormattingEnabled = true;
            cmbPort3.Location = new Point(485, 78);
            cmbPort3.Name = "cmbPort3";
            cmbPort3.Size = new Size(130, 25);
            cmbPort3.TabIndex = 7;
            // 
            // lblPort4
            // 
            lblPort4.AutoSize = true;
            lblPort4.ForeColor = Color.FromArgb(55, 65, 81);
            lblPort4.Location = new Point(642, 82);
            lblPort4.Name = "lblPort4";
            lblPort4.Size = new Size(43, 17);
            lblPort4.TabIndex = 8;
            lblPort4.Text = "Port 4";
            // 
            // cmbPort4
            // 
            cmbPort4.BackColor = Color.FromArgb(249, 250, 251);
            cmbPort4.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPort4.FlatStyle = FlatStyle.Flat;
            cmbPort4.FormattingEnabled = true;
            cmbPort4.Location = new Point(691, 78);
            cmbPort4.Name = "cmbPort4";
            cmbPort4.Size = new Size(130, 25);
            cmbPort4.TabIndex = 9;
            // 
            // lblBaudRate
            // 
            lblBaudRate.AutoSize = true;
            lblBaudRate.ForeColor = Color.FromArgb(55, 65, 81);
            lblBaudRate.Location = new Point(858, 82);
            lblBaudRate.Name = "lblBaudRate";
            lblBaudRate.Size = new Size(67, 17);
            lblBaudRate.TabIndex = 10;
            lblBaudRate.Text = "Baud Rate";
            // 
            // cmbOptionsBaudRate
            // 
            cmbOptionsBaudRate.BackColor = Color.FromArgb(249, 250, 251);
            cmbOptionsBaudRate.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOptionsBaudRate.FlatStyle = FlatStyle.Flat;
            cmbOptionsBaudRate.FormattingEnabled = true;
            cmbOptionsBaudRate.Location = new Point(933, 78);
            cmbOptionsBaudRate.Name = "cmbOptionsBaudRate";
            cmbOptionsBaudRate.Size = new Size(150, 25);
            cmbOptionsBaudRate.TabIndex = 11;
            // 
            // pnlDevicesCard
            // 
            pnlDevicesCard.BackColor = Color.White;
            pnlDevicesCard.Controls.Add(btnRefreshDevices);
            pnlDevicesCard.Controls.Add(label3);
            pnlDevicesCard.Controls.Add(lstDevices);
            pnlDevicesCard.Controls.Add(lblDetectedDevicesSubtitle);
            pnlDevicesCard.Controls.Add(lblDetectedDevicesTitle);
            pnlDevicesCard.Location = new Point(20, 262);
            pnlDevicesCard.Name = "pnlDevicesCard";
            pnlDevicesCard.Size = new Size(556, 286);
            pnlDevicesCard.TabIndex = 2;
            // 
            // btnRefreshDevices
            // 
            btnRefreshDevices.BackColor = Color.FromArgb(59, 130, 246);
            btnRefreshDevices.Cursor = Cursors.Hand;
            btnRefreshDevices.FlatAppearance.BorderSize = 0;
            btnRefreshDevices.FlatStyle = FlatStyle.Flat;
            btnRefreshDevices.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefreshDevices.ForeColor = Color.White;
            btnRefreshDevices.Location = new Point(20, 235);
            btnRefreshDevices.Name = "btnRefreshDevices";
            btnRefreshDevices.Size = new Size(140, 36);
            btnRefreshDevices.TabIndex = 4;
            btnRefreshDevices.Text = "Refresh Devices";
            btnRefreshDevices.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(107, 114, 128);
            label3.Location = new Point(20, 72);
            label3.Name = "label3";
            label3.Size = new Size(129, 17);
            label3.TabIndex = 2;
            label3.Text = "Scanned BLE Devices";
            // 
            // lstDevices
            // 
            lstDevices.BackColor = Color.FromArgb(249, 250, 251);
            lstDevices.BorderStyle = BorderStyle.None;
            lstDevices.ForeColor = Color.FromArgb(31, 41, 55);
            lstDevices.FormattingEnabled = true;
            lstDevices.Location = new Point(20, 97);
            lstDevices.Name = "lstDevices";
            lstDevices.Size = new Size(516, 119);
            lstDevices.TabIndex = 3;
            // 
            // lblDetectedDevicesSubtitle
            // 
            lblDetectedDevicesSubtitle.AutoSize = true;
            lblDetectedDevicesSubtitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblDetectedDevicesSubtitle.Location = new Point(24, 43);
            lblDetectedDevicesSubtitle.Name = "lblDetectedDevicesSubtitle";
            lblDetectedDevicesSubtitle.Size = new Size(344, 17);
            lblDetectedDevicesSubtitle.TabIndex = 1;
            lblDetectedDevicesSubtitle.Text = "Nearby BLE devices discovered by the active scan session";
            // 
            // lblDetectedDevicesTitle
            // 
            lblDetectedDevicesTitle.AutoSize = true;
            lblDetectedDevicesTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetectedDevicesTitle.ForeColor = Color.FromArgb(31, 41, 55);
            lblDetectedDevicesTitle.Location = new Point(20, 18);
            lblDetectedDevicesTitle.Name = "lblDetectedDevicesTitle";
            lblDetectedDevicesTitle.Size = new Size(138, 21);
            lblDetectedDevicesTitle.TabIndex = 0;
            lblDetectedDevicesTitle.Text = "Detected Devices";
            // 
            // pnlSelectedDeviceCard
            // 
            pnlSelectedDeviceCard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSelectedDeviceCard.BackColor = Color.White;
            pnlSelectedDeviceCard.Controls.Add(btnSaveMapping);
            pnlSelectedDeviceCard.Controls.Add(btnPairDevice);
            pnlSelectedDeviceCard.Controls.Add(txtFriendlyName);
            pnlSelectedDeviceCard.Controls.Add(lblFriendlyName);
            pnlSelectedDeviceCard.Controls.Add(txtDetectedDeviceName);
            pnlSelectedDeviceCard.Controls.Add(lblDetectedDeviceName);
            pnlSelectedDeviceCard.Controls.Add(txtTagId);
            pnlSelectedDeviceCard.Controls.Add(lblTagId);
            pnlSelectedDeviceCard.Controls.Add(label1);
            pnlSelectedDeviceCard.Controls.Add(lblSelectedDeviceSubtitle);
            pnlSelectedDeviceCard.Location = new Point(597, 262);
            pnlSelectedDeviceCard.Name = "pnlSelectedDeviceCard";
            pnlSelectedDeviceCard.Size = new Size(598, 286);
            pnlSelectedDeviceCard.TabIndex = 3;
            // 
            // btnSaveMapping
            // 
            btnSaveMapping.BackColor = Color.FromArgb(31, 41, 55);
            btnSaveMapping.Cursor = Cursors.Hand;
            btnSaveMapping.FlatAppearance.BorderSize = 0;
            btnSaveMapping.FlatStyle = FlatStyle.Flat;
            btnSaveMapping.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveMapping.ForeColor = Color.White;
            btnSaveMapping.Location = new Point(200, 226);
            btnSaveMapping.Name = "btnSaveMapping";
            btnSaveMapping.Size = new Size(128, 36);
            btnSaveMapping.TabIndex = 9;
            btnSaveMapping.Text = "Save Mapping";
            btnSaveMapping.UseVisualStyleBackColor = false;
            btnSaveMapping.Click += btnSaveMapping_Click;
            // 
            // btnPairDevice
            // 
            btnPairDevice.BackColor = Color.FromArgb(34, 197, 94);
            btnPairDevice.Cursor = Cursors.Hand;
            btnPairDevice.FlatAppearance.BorderSize = 0;
            btnPairDevice.FlatStyle = FlatStyle.Flat;
            btnPairDevice.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPairDevice.ForeColor = Color.White;
            btnPairDevice.Location = new Point(24, 226);
            btnPairDevice.Name = "btnPairDevice";
            btnPairDevice.Size = new Size(128, 36);
            btnPairDevice.TabIndex = 8;
            btnPairDevice.Text = "Pair Device";
            btnPairDevice.UseVisualStyleBackColor = false;
            // 
            // txtFriendlyName
            // 
            txtFriendlyName.BackColor = Color.FromArgb(249, 250, 251);
            txtFriendlyName.BorderStyle = BorderStyle.FixedSingle;
            txtFriendlyName.Location = new Point(24, 181);
            txtFriendlyName.Name = "txtFriendlyName";
            txtFriendlyName.Size = new Size(304, 25);
            txtFriendlyName.TabIndex = 7;
            // 
            // lblFriendlyName
            // 
            lblFriendlyName.AutoSize = true;
            lblFriendlyName.ForeColor = Color.FromArgb(55, 65, 81);
            lblFriendlyName.Location = new Point(24, 158);
            lblFriendlyName.Name = "lblFriendlyName";
            lblFriendlyName.Size = new Size(92, 17);
            lblFriendlyName.TabIndex = 6;
            lblFriendlyName.Text = "Friendly Name";
            // 
            // txtDetectedDeviceName
            // 
            txtDetectedDeviceName.BackColor = Color.FromArgb(243, 244, 246);
            txtDetectedDeviceName.BorderStyle = BorderStyle.FixedSingle;
            txtDetectedDeviceName.Location = new Point(24, 123);
            txtDetectedDeviceName.Name = "txtDetectedDeviceName";
            txtDetectedDeviceName.ReadOnly = true;
            txtDetectedDeviceName.Size = new Size(304, 25);
            txtDetectedDeviceName.TabIndex = 5;
            // 
            // lblDetectedDeviceName
            // 
            lblDetectedDeviceName.AutoSize = true;
            lblDetectedDeviceName.ForeColor = Color.FromArgb(55, 65, 81);
            lblDetectedDeviceName.Location = new Point(24, 100);
            lblDetectedDeviceName.Name = "lblDetectedDeviceName";
            lblDetectedDeviceName.Size = new Size(99, 17);
            lblDetectedDeviceName.TabIndex = 4;
            lblDetectedDeviceName.Text = "Detected Name";
            // 
            // txtTagId
            // 
            txtTagId.BackColor = Color.FromArgb(243, 244, 246);
            txtTagId.BorderStyle = BorderStyle.FixedSingle;
            txtTagId.Location = new Point(24, 65);
            txtTagId.Name = "txtTagId";
            txtTagId.ReadOnly = true;
            txtTagId.Size = new Size(304, 25);
            txtTagId.TabIndex = 3;
            // 
            // lblTagId
            // 
            lblTagId.AutoSize = true;
            lblTagId.ForeColor = Color.FromArgb(55, 65, 81);
            lblTagId.Location = new Point(24, 42);
            lblTagId.Name = "lblTagId";
            lblTagId.Size = new Size(45, 17);
            lblTagId.TabIndex = 2;
            lblTagId.Text = "Tag ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(31, 41, 55);
            label1.Location = new Point(20, 18);
            label1.Name = "label1";
            label1.Size = new Size(127, 21);
            label1.TabIndex = 0;
            label1.Text = "Selected Device";
            // 
            // lblSelectedDeviceSubtitle
            // 
            lblSelectedDeviceSubtitle.AutoSize = true;
            lblSelectedDeviceSubtitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblSelectedDeviceSubtitle.Location = new Point(147, 21);
            lblSelectedDeviceSubtitle.Name = "lblSelectedDeviceSubtitle";
            lblSelectedDeviceSubtitle.Size = new Size(186, 17);
            lblSelectedDeviceSubtitle.TabIndex = 1;
            lblSelectedDeviceSubtitle.Text = "Review and name a BLE device";
            // 
            // pnlSettingsCard
            // 
            pnlSettingsCard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlSettingsCard.BackColor = Color.White;
            pnlSettingsCard.Controls.Add(btnCloseOptions);
            pnlSettingsCard.Controls.Add(btnSaveOptions);
            pnlSettingsCard.Controls.Add(txtFirebaseApiKey);
            pnlSettingsCard.Controls.Add(lblFirebaseApiKey);
            pnlSettingsCard.Controls.Add(txtFirebaseUrl);
            pnlSettingsCard.Controls.Add(lblFirebaseUrl);
            pnlSettingsCard.Controls.Add(rdoCloud);
            pnlSettingsCard.Controls.Add(rdoLocal);
            pnlSettingsCard.Controls.Add(lblConnectionMode);
            pnlSettingsCard.Controls.Add(txtDeviceFilter);
            pnlSettingsCard.Controls.Add(lblDeviceFilter);
            pnlSettingsCard.Controls.Add(chkAutoConnect);
            pnlSettingsCard.Controls.Add(lblSettingsSubtitle);
            pnlSettingsCard.Controls.Add(lblSettingsTitle);
            pnlSettingsCard.Location = new Point(20, 567);
            pnlSettingsCard.Name = "pnlSettingsCard";
            pnlSettingsCard.Size = new Size(1175, 173);
            pnlSettingsCard.TabIndex = 4;
            // 
            // btnCloseOptions
            // 
            btnCloseOptions.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCloseOptions.BackColor = Color.FromArgb(31, 41, 55);
            btnCloseOptions.Cursor = Cursors.Hand;
            btnCloseOptions.FlatAppearance.BorderSize = 0;
            btnCloseOptions.FlatStyle = FlatStyle.Flat;
            btnCloseOptions.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloseOptions.ForeColor = Color.White;
            btnCloseOptions.Location = new Point(1019, 121);
            btnCloseOptions.Name = "btnCloseOptions";
            btnCloseOptions.Size = new Size(132, 36);
            btnCloseOptions.TabIndex = 13;
            btnCloseOptions.Text = "Close";
            btnCloseOptions.UseVisualStyleBackColor = false;
            btnCloseOptions.Click += btnCloseOptions_Click;
            // 
            // btnSaveOptions
            // 
            btnSaveOptions.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveOptions.BackColor = Color.FromArgb(59, 130, 246);
            btnSaveOptions.Cursor = Cursors.Hand;
            btnSaveOptions.FlatAppearance.BorderSize = 0;
            btnSaveOptions.FlatStyle = FlatStyle.Flat;
            btnSaveOptions.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveOptions.ForeColor = Color.White;
            btnSaveOptions.Location = new Point(848, 121);
            btnSaveOptions.Name = "btnSaveOptions";
            btnSaveOptions.Size = new Size(132, 36);
            btnSaveOptions.TabIndex = 12;
            btnSaveOptions.Text = "Save Settings";
            btnSaveOptions.UseVisualStyleBackColor = false;
            btnSaveOptions.Click += btnSaveOptions_Click;
            // 
            // txtFirebaseApiKey
            // 
            txtFirebaseApiKey.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFirebaseApiKey.BackColor = Color.FromArgb(249, 250, 251);
            txtFirebaseApiKey.BorderStyle = BorderStyle.FixedSingle;
            txtFirebaseApiKey.Location = new Point(436, 39);
            txtFirebaseApiKey.Name = "txtFirebaseApiKey";
            txtFirebaseApiKey.PlaceholderText = "Your Firebase API key";
            txtFirebaseApiKey.Size = new Size(303, 25);
            txtFirebaseApiKey.TabIndex = 11;
            // 
            // lblFirebaseApiKey
            // 
            lblFirebaseApiKey.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFirebaseApiKey.AutoSize = true;
            lblFirebaseApiKey.ForeColor = Color.FromArgb(55, 65, 81);
            lblFirebaseApiKey.Location = new Point(436, 19);
            lblFirebaseApiKey.Name = "lblFirebaseApiKey";
            lblFirebaseApiKey.Size = new Size(51, 17);
            lblFirebaseApiKey.TabIndex = 10;
            lblFirebaseApiKey.Text = "API Key";
            // 
            // txtFirebaseUrl
            // 
            txtFirebaseUrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFirebaseUrl.BackColor = Color.FromArgb(249, 250, 251);
            txtFirebaseUrl.BorderStyle = BorderStyle.FixedSingle;
            txtFirebaseUrl.Location = new Point(436, 114);
            txtFirebaseUrl.Name = "txtFirebaseUrl";
            txtFirebaseUrl.PlaceholderText = "https://your-project-default-rtdb.firebaseio.com/";
            txtFirebaseUrl.Size = new Size(303, 25);
            txtFirebaseUrl.TabIndex = 9;
            // 
            // lblFirebaseUrl
            // 
            lblFirebaseUrl.AutoSize = true;
            lblFirebaseUrl.ForeColor = Color.FromArgb(55, 65, 81);
            lblFirebaseUrl.Location = new Point(436, 93);
            lblFirebaseUrl.Name = "lblFirebaseUrl";
            lblFirebaseUrl.Size = new Size(84, 17);
            lblFirebaseUrl.TabIndex = 8;
            lblFirebaseUrl.Text = "Firebase URL";
            // 
            // rdoCloud
            // 
            rdoCloud.AutoSize = true;
            rdoCloud.ForeColor = Color.FromArgb(31, 41, 55);
            rdoCloud.Location = new Point(258, 121);
            rdoCloud.Name = "rdoCloud";
            rdoCloud.Size = new Size(121, 21);
            rdoCloud.TabIndex = 7;
            rdoCloud.Text = "Cloud (Firebase)";
            rdoCloud.UseVisualStyleBackColor = true;
            rdoCloud.CheckedChanged += rdoConnectionMode_CheckedChanged;
            // 
            // rdoLocal
            // 
            rdoLocal.AutoSize = true;
            rdoLocal.ForeColor = Color.FromArgb(31, 41, 55);
            rdoLocal.Location = new Point(142, 121);
            rdoLocal.Name = "rdoLocal";
            rdoLocal.Size = new Size(102, 21);
            rdoLocal.TabIndex = 6;
            rdoLocal.Text = "Local Dongle";
            rdoLocal.UseVisualStyleBackColor = true;
            rdoLocal.CheckedChanged += rdoConnectionMode_CheckedChanged;
            // 
            // lblConnectionMode
            // 
            lblConnectionMode.AutoSize = true;
            lblConnectionMode.ForeColor = Color.FromArgb(55, 65, 81);
            lblConnectionMode.Location = new Point(20, 121);
            lblConnectionMode.Name = "lblConnectionMode";
            lblConnectionMode.Size = new Size(112, 17);
            lblConnectionMode.TabIndex = 5;
            lblConnectionMode.Text = "Connection Mode";
            // 
            // txtDeviceFilter
            // 
            txtDeviceFilter.BackColor = Color.FromArgb(249, 250, 251);
            txtDeviceFilter.BorderStyle = BorderStyle.FixedSingle;
            txtDeviceFilter.Location = new Point(848, 39);
            txtDeviceFilter.Name = "txtDeviceFilter";
            txtDeviceFilter.Size = new Size(303, 25);
            txtDeviceFilter.TabIndex = 4;
            // 
            // lblDeviceFilter
            // 
            lblDeviceFilter.AutoSize = true;
            lblDeviceFilter.ForeColor = Color.FromArgb(55, 65, 81);
            lblDeviceFilter.Location = new Point(848, 19);
            lblDeviceFilter.Name = "lblDeviceFilter";
            lblDeviceFilter.Size = new Size(102, 17);
            lblDeviceFilter.TabIndex = 3;
            lblDeviceFilter.Text = "BLE Device Filter";
            // 
            // chkAutoConnect
            // 
            chkAutoConnect.AutoSize = true;
            chkAutoConnect.ForeColor = Color.FromArgb(31, 41, 55);
            chkAutoConnect.Location = new Point(24, 89);
            chkAutoConnect.Name = "chkAutoConnect";
            chkAutoConnect.Size = new Size(171, 21);
            chkAutoConnect.TabIndex = 2;
            chkAutoConnect.Text = "Auto-Connect on Startup";
            chkAutoConnect.UseVisualStyleBackColor = true;
            chkAutoConnect.CheckedChanged += chkAutoConnect_CheckedChanged;
            // 
            // lblSettingsSubtitle
            // 
            lblSettingsSubtitle.AutoSize = true;
            lblSettingsSubtitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblSettingsSubtitle.Location = new Point(24, 39);
            lblSettingsSubtitle.Name = "lblSettingsSubtitle";
            lblSettingsSubtitle.Size = new Size(340, 17);
            lblSettingsSubtitle.TabIndex = 1;
            lblSettingsSubtitle.Text = "Control BLE discovery, app startup, and Firebase settings";
            // 
            // lblSettingsTitle
            // 
            lblSettingsTitle.AutoSize = true;
            lblSettingsTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSettingsTitle.ForeColor = Color.FromArgb(31, 41, 55);
            lblSettingsTitle.Location = new Point(20, 18);
            lblSettingsTitle.Name = "lblSettingsTitle";
            lblSettingsTitle.Size = new Size(70, 21);
            lblSettingsTitle.TabIndex = 0;
            lblSettingsTitle.Text = "Settings";
            // 
            // Options
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1215, 760);
            Controls.Add(pnlSettingsCard);
            Controls.Add(pnlSelectedDeviceCard);
            Controls.Add(pnlDevicesCard);
            Controls.Add(pnlPortsCard);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(1231, 799);
            Name = "Options";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SafeStep Options";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlPortsCard.ResumeLayout(false);
            pnlPortsCard.PerformLayout();
            pnlDevicesCard.ResumeLayout(false);
            pnlDevicesCard.PerformLayout();
            pnlSelectedDeviceCard.ResumeLayout(false);
            pnlSelectedDeviceCard.PerformLayout();
            pnlSettingsCard.ResumeLayout(false);
            pnlSettingsCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblPortsTitle;
        private ComboBox cmbPort1;
        private Label lblPort1;
        private Label lblPort2;
        private ComboBox cmbPort2;
        private ComboBox cmbPort3;
        private Label lblPort3;
        private ComboBox cmbPort4;
        private Label lblPort4;
        private Label lblBaudRate;
        private ComboBox cmbOptionsBaudRate;
        private Label lblDetectedDevicesTitle;
        private Label lblTagId;
        private TextBox txtTagId;
        private Label lblFriendlyName;
        private TextBox txtFriendlyName;
        private Button btnSaveMapping;
        private Label lblSettingsTitle;
        private CheckBox chkAutoConnect;
        private Label lblDeviceFilter;
        private TextBox txtDeviceFilter;
        private Button btnSaveOptions;
        private Button btnCloseOptions;
        private ListBox lstDevices;
        private Label label1;
        private TextBox txtDetectedDeviceName;
        private Label lblDetectedDeviceName;
        private Button btnPairDevice;
        private Button btnRefreshDevices;
        private Label label3;
        private Label lblConnectionMode;
        private RadioButton rdoLocal;
        private RadioButton rdoCloud;
        private Label lblFirebaseUrl;
        private TextBox txtFirebaseUrl;
        private Label lblFirebaseApiKey;
        private TextBox txtFirebaseApiKey;
        private Panel pnlHeader;
        private Label lblHeaderSubtitle;
        private Label lblHeaderTitle;
        private Panel pnlPortsCard;
        private Label lblPortsSubtitle;
        private Panel pnlDevicesCard;
        private Label lblDetectedDevicesSubtitle;
        private Panel pnlSelectedDeviceCard;
        private Label lblSelectedDeviceSubtitle;
        private Panel pnlSettingsCard;
        private Label lblSettingsSubtitle;
    }
}