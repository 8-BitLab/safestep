namespace SafeStep___Desktop__WinForms_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend skDefaultLegend1 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            LiveChartsCore.Drawing.Padding padding1 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip skDefaultTooltip1 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip();
            LiveChartsCore.Drawing.Padding padding2 = new LiveChartsCore.Drawing.Padding();
            pnlHeader = new Panel();
            lblHeaderSubtitle = new Label();
            lblHeaderTitle = new Label();
            btnOptions = new Button();
            pnlConnectionCard = new Panel();
            lblBaudTitle = new Label();
            cmbBaudRate = new ComboBox();
            comPortText = new Label();
            cmbPorts = new ComboBox();
            btnRefresh = new Button();
            btnConnect = new Button();
            btnDisconnect = new Button();
            pnlQuickActions = new Panel();
            lblQuickActions = new Label();
            btnSos = new Button();
            btnStatus = new Button();
            btnPing = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblAlarmTitle = new Label();
            lblAlarm = new Label();
            pnlAlarm = new Panel();
            lblAlarmDetail = new Label();
            lblAlarmBadge = new Label();
            lblAlarmIcon = new Label();
            lblTemperatureCaption = new Label();
            lblTemperature = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            lblDistanceTitle = new Label();
            lblDistance = new Label();
            lblDistanceTime = new Label();
            distanceChart = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            flowLayoutPanel3 = new FlowLayoutPanel();
            lblBatteryTitle = new Label();
            lblBattery = new Label();
            progressBattery = new ProgressBar();
            pnlMessages = new Panel();
            lblMessagesSubtitle = new Label();
            lblMessagesTitle = new Label();
            lstMessages = new ListBox();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            pnlHeader.SuspendLayout();
            pnlConnectionCard.SuspendLayout();
            pnlQuickActions.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            pnlAlarm.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            pnlMessages.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblHeaderSubtitle);
            pnlHeader.Controls.Add(lblHeaderTitle);
            pnlHeader.Controls.Add(btnOptions);
            pnlHeader.Location = new Point(20, 18);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1200, 78);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderSubtitle
            // 
            lblHeaderSubtitle.AutoSize = true;
            lblHeaderSubtitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblHeaderSubtitle.Location = new Point(24, 43);
            lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            lblHeaderSubtitle.Size = new Size(336, 17);
            lblHeaderSubtitle.TabIndex = 1;
            lblHeaderSubtitle.Text = "Live safety monitoring for tags, zones, and device health";
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeaderTitle.ForeColor = Color.FromArgb(31, 41, 55);
            lblHeaderTitle.Location = new Point(20, 8);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(231, 37);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "SafeStep Desktop";
            // 
            // btnOptions
            // 
            btnOptions.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOptions.BackColor = Color.FromArgb(31, 41, 55);
            btnOptions.Cursor = Cursors.Hand;
            btnOptions.FlatAppearance.BorderSize = 0;
            btnOptions.FlatStyle = FlatStyle.Flat;
            btnOptions.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOptions.ForeColor = Color.White;
            btnOptions.Location = new Point(1067, 20);
            btnOptions.Name = "btnOptions";
            btnOptions.Size = new Size(109, 38);
            btnOptions.TabIndex = 2;
            btnOptions.Text = "Options";
            btnOptions.UseVisualStyleBackColor = false;
            btnOptions.Click += btnOptions_Click;
            // 
            // pnlConnectionCard
            // 
            pnlConnectionCard.BackColor = Color.White;
            pnlConnectionCard.Controls.Add(lblBaudTitle);
            pnlConnectionCard.Controls.Add(cmbBaudRate);
            pnlConnectionCard.Controls.Add(comPortText);
            pnlConnectionCard.Controls.Add(cmbPorts);
            pnlConnectionCard.Controls.Add(btnRefresh);
            pnlConnectionCard.Controls.Add(btnConnect);
            pnlConnectionCard.Controls.Add(btnDisconnect);
            pnlConnectionCard.Location = new Point(20, 114);
            pnlConnectionCard.Name = "pnlConnectionCard";
            pnlConnectionCard.Size = new Size(704, 96);
            pnlConnectionCard.TabIndex = 1;
            // 
            // lblBaudTitle
            // 
            lblBaudTitle.AutoSize = true;
            lblBaudTitle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBaudTitle.ForeColor = Color.FromArgb(55, 65, 81);
            lblBaudTitle.Location = new Point(231, 21);
            lblBaudTitle.Name = "lblBaudTitle";
            lblBaudTitle.Size = new Size(70, 17);
            lblBaudTitle.TabIndex = 3;
            lblBaudTitle.Text = "Baud Rate";
            // 
            // cmbBaudRate
            // 
            cmbBaudRate.BackColor = Color.FromArgb(249, 250, 251);
            cmbBaudRate.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBaudRate.FlatStyle = FlatStyle.Flat;
            cmbBaudRate.FormattingEnabled = true;
            cmbBaudRate.Location = new Point(231, 42);
            cmbBaudRate.Name = "cmbBaudRate";
            cmbBaudRate.Size = new Size(132, 25);
            cmbBaudRate.TabIndex = 4;
            cmbBaudRate.SelectedIndexChanged += cmbBaudRate_SelectedIndexChanged;
            // 
            // comPortText
            // 
            comPortText.AutoSize = true;
            comPortText.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comPortText.ForeColor = Color.FromArgb(55, 65, 81);
            comPortText.Location = new Point(22, 21);
            comPortText.Name = "comPortText";
            comPortText.Size = new Size(68, 17);
            comPortText.TabIndex = 0;
            comPortText.Text = "COM Port";
            // 
            // cmbPorts
            // 
            cmbPorts.BackColor = Color.FromArgb(249, 250, 251);
            cmbPorts.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPorts.FlatStyle = FlatStyle.Flat;
            cmbPorts.FormattingEnabled = true;
            cmbPorts.Location = new Point(22, 42);
            cmbPorts.Name = "cmbPorts";
            cmbPorts.Size = new Size(190, 25);
            cmbPorts.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(243, 244, 246);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.FromArgb(31, 41, 55);
            btnRefresh.Location = new Point(383, 32);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(90, 36);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.FromArgb(34, 197, 94);
            btnConnect.Cursor = Cursors.Hand;
            btnConnect.FlatAppearance.BorderSize = 0;
            btnConnect.FlatStyle = FlatStyle.Flat;
            btnConnect.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConnect.ForeColor = Color.White;
            btnConnect.Location = new Point(489, 32);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(92, 36);
            btnConnect.TabIndex = 6;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.BackColor = Color.FromArgb(31, 41, 55);
            btnDisconnect.Cursor = Cursors.Hand;
            btnDisconnect.FlatAppearance.BorderSize = 0;
            btnDisconnect.FlatStyle = FlatStyle.Flat;
            btnDisconnect.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDisconnect.ForeColor = Color.White;
            btnDisconnect.Location = new Point(591, 32);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(92, 36);
            btnDisconnect.TabIndex = 7;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = false;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // pnlQuickActions
            // 
            pnlQuickActions.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlQuickActions.BackColor = Color.White;
            pnlQuickActions.Controls.Add(lblQuickActions);
            pnlQuickActions.Controls.Add(btnSos);
            pnlQuickActions.Controls.Add(btnStatus);
            pnlQuickActions.Controls.Add(btnPing);
            pnlQuickActions.Location = new Point(743, 114);
            pnlQuickActions.Name = "pnlQuickActions";
            pnlQuickActions.Size = new Size(477, 96);
            pnlQuickActions.TabIndex = 2;
            // 
            // lblQuickActions
            // 
            lblQuickActions.AutoSize = true;
            lblQuickActions.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuickActions.ForeColor = Color.FromArgb(55, 65, 81);
            lblQuickActions.Location = new Point(22, 21);
            lblQuickActions.Name = "lblQuickActions";
            lblQuickActions.Size = new Size(91, 17);
            lblQuickActions.TabIndex = 0;
            lblQuickActions.Text = "Quick Actions";
            // 
            // btnSos
            // 
            btnSos.BackColor = Color.FromArgb(239, 68, 68);
            btnSos.Cursor = Cursors.Hand;
            btnSos.FlatAppearance.BorderSize = 0;
            btnSos.FlatStyle = FlatStyle.Flat;
            btnSos.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSos.ForeColor = Color.White;
            btnSos.Location = new Point(22, 41);
            btnSos.Name = "btnSos";
            btnSos.Size = new Size(124, 36);
            btnSos.TabIndex = 1;
            btnSos.Text = "SOS";
            btnSos.UseVisualStyleBackColor = false;
            btnSos.Click += btnSos_Click;
            // 
            // btnStatus
            // 
            btnStatus.BackColor = Color.FromArgb(59, 130, 246);
            btnStatus.Cursor = Cursors.Hand;
            btnStatus.FlatAppearance.BorderSize = 0;
            btnStatus.FlatStyle = FlatStyle.Flat;
            btnStatus.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStatus.ForeColor = Color.White;
            btnStatus.Location = new Point(162, 41);
            btnStatus.Name = "btnStatus";
            btnStatus.Size = new Size(124, 36);
            btnStatus.TabIndex = 2;
            btnStatus.Text = "Status";
            btnStatus.UseVisualStyleBackColor = false;
            btnStatus.Click += btnStatus_Click;
            // 
            // btnPing
            // 
            btnPing.BackColor = Color.FromArgb(15, 118, 110);
            btnPing.Cursor = Cursors.Hand;
            btnPing.FlatAppearance.BorderSize = 0;
            btnPing.FlatStyle = FlatStyle.Flat;
            btnPing.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPing.ForeColor = Color.White;
            btnPing.Location = new Point(302, 41);
            btnPing.Name = "btnPing";
            btnPing.Size = new Size(124, 36);
            btnPing.TabIndex = 3;
            btnPing.Text = "Ping";
            btnPing.UseVisualStyleBackColor = false;
            btnPing.Click += btnPing_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(lblAlarmTitle);
            flowLayoutPanel1.Controls.Add(lblAlarm);
            flowLayoutPanel1.Controls.Add(pnlAlarm);
            flowLayoutPanel1.Controls.Add(lblTemperatureCaption);
            flowLayoutPanel1.Controls.Add(lblTemperature);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(20, 229);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(18, 16, 18, 18);
            flowLayoutPanel1.Size = new Size(308, 285);
            flowLayoutPanel1.TabIndex = 3;
            flowLayoutPanel1.WrapContents = false;
            // 
            // lblAlarmTitle
            // 
            lblAlarmTitle.AutoSize = true;
            lblAlarmTitle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlarmTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblAlarmTitle.Location = new Point(21, 16);
            lblAlarmTitle.Name = "lblAlarmTitle";
            lblAlarmTitle.Size = new Size(86, 17);
            lblAlarmTitle.TabIndex = 0;
            lblAlarmTitle.Text = "Alarm Status";
            // 
            // lblAlarm
            // 
            lblAlarm.AutoSize = true;
            lblAlarm.Font = new Font("Segoe UI Semibold", 19F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlarm.ForeColor = Color.FromArgb(31, 41, 55);
            lblAlarm.Location = new Point(21, 33);
            lblAlarm.Margin = new Padding(3, 0, 3, 10);
            lblAlarm.Name = "lblAlarm";
            lblAlarm.Size = new Size(195, 36);
            lblAlarm.TabIndex = 1;
            lblAlarm.Text = "System Normal";
            // 
            // pnlAlarm
            // 
            pnlAlarm.BackColor = Color.FromArgb(220, 252, 231);
            pnlAlarm.BorderStyle = BorderStyle.FixedSingle;
            pnlAlarm.Controls.Add(lblAlarmDetail);
            pnlAlarm.Controls.Add(lblAlarmBadge);
            pnlAlarm.Controls.Add(lblAlarmIcon);
            pnlAlarm.Location = new Point(21, 82);
            pnlAlarm.Name = "pnlAlarm";
            pnlAlarm.Size = new Size(250, 140);
            pnlAlarm.TabIndex = 2;
            // 
            // lblAlarmDetail
            // 
            lblAlarmDetail.ForeColor = Color.FromArgb(22, 101, 52);
            lblAlarmDetail.Location = new Point(18, 101);
            lblAlarmDetail.Name = "lblAlarmDetail";
            lblAlarmDetail.Size = new Size(212, 24);
            lblAlarmDetail.TabIndex = 2;
            lblAlarmDetail.Text = "No active alarms";
            lblAlarmDetail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAlarmBadge
            // 
            lblAlarmBadge.AutoSize = true;
            lblAlarmBadge.BackColor = Color.FromArgb(34, 197, 94);
            lblAlarmBadge.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlarmBadge.ForeColor = Color.White;
            lblAlarmBadge.Location = new Point(16, 14);
            lblAlarmBadge.Name = "lblAlarmBadge";
            lblAlarmBadge.Padding = new Padding(10, 4, 10, 4);
            lblAlarmBadge.Size = new Size(54, 23);
            lblAlarmBadge.TabIndex = 1;
            lblAlarmBadge.Text = "SAFE";
            // 
            // lblAlarmIcon
            // 
            lblAlarmIcon.Font = new Font("Segoe UI Emoji", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAlarmIcon.ForeColor = Color.FromArgb(22, 101, 52);
            lblAlarmIcon.Location = new Point(74, 38);
            lblAlarmIcon.Name = "lblAlarmIcon";
            lblAlarmIcon.Size = new Size(96, 58);
            lblAlarmIcon.TabIndex = 0;
            lblAlarmIcon.Text = "✓";
            lblAlarmIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTemperatureCaption
            // 
            lblTemperatureCaption.AutoSize = true;
            lblTemperatureCaption.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTemperatureCaption.ForeColor = Color.FromArgb(107, 114, 128);
            lblTemperatureCaption.Location = new Point(21, 225);
            lblTemperatureCaption.Name = "lblTemperatureCaption";
            lblTemperatureCaption.Size = new Size(85, 17);
            lblTemperatureCaption.TabIndex = 3;
            lblTemperatureCaption.Text = "Temperature";
            // 
            // lblTemperature
            // 
            lblTemperature.AutoSize = true;
            lblTemperature.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTemperature.ForeColor = Color.FromArgb(31, 41, 55);
            lblTemperature.Location = new Point(21, 242);
            lblTemperature.Name = "lblTemperature";
            lblTemperature.Size = new Size(58, 32);
            lblTemperature.TabIndex = 4;
            lblTemperature.Text = "--°C";
            lblTemperature.Click += lblTemperature_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel2.BackColor = Color.White;
            flowLayoutPanel2.Controls.Add(lblDistanceTitle);
            flowLayoutPanel2.Controls.Add(lblDistance);
            flowLayoutPanel2.Controls.Add(lblDistanceTime);
            flowLayoutPanel2.Controls.Add(distanceChart);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(347, 229);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(18, 16, 18, 18);
            flowLayoutPanel2.Size = new Size(540, 285);
            flowLayoutPanel2.TabIndex = 4;
            flowLayoutPanel2.WrapContents = false;
            // 
            // lblDistanceTitle
            // 
            lblDistanceTitle.AutoSize = true;
            lblDistanceTitle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDistanceTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblDistanceTitle.Location = new Point(21, 16);
            lblDistanceTitle.Name = "lblDistanceTitle";
            lblDistanceTitle.Size = new Size(98, 17);
            lblDistanceTitle.TabIndex = 0;
            lblDistanceTitle.Text = "Distance / RSSI";
            // 
            // lblDistance
            // 
            lblDistance.AutoSize = true;
            lblDistance.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDistance.ForeColor = Color.FromArgb(31, 41, 55);
            lblDistance.Location = new Point(21, 33);
            lblDistance.Name = "lblDistance";
            lblDistance.Size = new Size(85, 37);
            lblDistance.TabIndex = 1;
            lblDistance.Text = "0.0 m";
            // 
            // lblDistanceTime
            // 
            lblDistanceTime.AutoSize = true;
            lblDistanceTime.ForeColor = Color.FromArgb(107, 114, 128);
            lblDistanceTime.Location = new Point(21, 70);
            lblDistanceTime.Margin = new Padding(3, 0, 3, 10);
            lblDistanceTime.Name = "lblDistanceTime";
            lblDistanceTime.Size = new Size(114, 17);
            lblDistanceTime.TabIndex = 2;
            lblDistanceTime.Text = "Last updated: --:--";
            // 
            // distanceChart
            // 
            distanceChart.AutoUpdateEnabled = true;
            distanceChart.BackColor = Color.FromArgb(249, 250, 251);
            distanceChart.ChartTheme = null;
            skDefaultLegend1.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultLegend1.Content = null;
            skDefaultLegend1.IsValid = false;
            skDefaultLegend1.Opacity = 1F;
            padding1.Bottom = 0F;
            padding1.Left = 0F;
            padding1.Right = 0F;
            padding1.Top = 0F;
            skDefaultLegend1.Padding = padding1;
            skDefaultLegend1.RemoveOnCompleted = false;
            skDefaultLegend1.RotateTransform = 0F;
            skDefaultLegend1.X = 0F;
            skDefaultLegend1.Y = 0F;
            distanceChart.Legend = skDefaultLegend1;
            distanceChart.Location = new Point(21, 100);
            distanceChart.MatchAxesScreenDataRatio = false;
            distanceChart.Name = "distanceChart";
            distanceChart.Size = new Size(480, 140);
            distanceChart.TabIndex = 3;
            skDefaultTooltip1.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultTooltip1.Content = null;
            skDefaultTooltip1.IsValid = false;
            skDefaultTooltip1.Opacity = 1F;
            padding2.Bottom = 0F;
            padding2.Left = 0F;
            padding2.Right = 0F;
            padding2.Top = 0F;
            skDefaultTooltip1.Padding = padding2;
            skDefaultTooltip1.RemoveOnCompleted = false;
            skDefaultTooltip1.RotateTransform = 0F;
            skDefaultTooltip1.Wedge = 10;
            skDefaultTooltip1.X = 0F;
            skDefaultTooltip1.Y = 0F;
            distanceChart.Tooltip = skDefaultTooltip1;
            distanceChart.TooltipFindingStrategy = LiveChartsCore.Measure.TooltipFindingStrategy.Automatic;
            distanceChart.UpdaterThrottler = TimeSpan.Parse("00:00:00.0500000");
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            flowLayoutPanel3.BackColor = Color.White;
            flowLayoutPanel3.Controls.Add(lblBatteryTitle);
            flowLayoutPanel3.Controls.Add(lblBattery);
            flowLayoutPanel3.Controls.Add(progressBattery);
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(906, 229);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Padding = new Padding(18, 16, 18, 18);
            flowLayoutPanel3.Size = new Size(314, 285);
            flowLayoutPanel3.TabIndex = 5;
            flowLayoutPanel3.WrapContents = false;
            // 
            // lblBatteryTitle
            // 
            lblBatteryTitle.AutoSize = true;
            lblBatteryTitle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBatteryTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblBatteryTitle.Location = new Point(21, 16);
            lblBatteryTitle.Name = "lblBatteryTitle";
            lblBatteryTitle.Size = new Size(97, 17);
            lblBatteryTitle.TabIndex = 0;
            lblBatteryTitle.Text = "Battery Health";
            // 
            // lblBattery
            // 
            lblBattery.AutoSize = true;
            lblBattery.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBattery.ForeColor = Color.FromArgb(31, 41, 55);
            lblBattery.Location = new Point(21, 33);
            lblBattery.Margin = new Padding(3, 0, 3, 14);
            lblBattery.Name = "lblBattery";
            lblBattery.Size = new Size(60, 41);
            lblBattery.TabIndex = 1;
            lblBattery.Text = "0%";
            // 
            // progressBattery
            // 
            progressBattery.ForeColor = Color.FromArgb(34, 197, 94);
            progressBattery.Location = new Point(21, 91);
            progressBattery.Name = "progressBattery";
            progressBattery.Size = new Size(250, 26);
            progressBattery.Style = ProgressBarStyle.Continuous;
            progressBattery.TabIndex = 2;
            // 
            // pnlMessages
            // 
            pnlMessages.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlMessages.BackColor = Color.White;
            pnlMessages.Controls.Add(lblMessagesSubtitle);
            pnlMessages.Controls.Add(lblMessagesTitle);
            pnlMessages.Controls.Add(lstMessages);
            pnlMessages.Location = new Point(20, 530);
            pnlMessages.Name = "pnlMessages";
            pnlMessages.Size = new Size(1200, 172);
            pnlMessages.TabIndex = 6;
            // 
            // lblMessagesSubtitle
            // 
            lblMessagesSubtitle.AutoSize = true;
            lblMessagesSubtitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblMessagesSubtitle.Location = new Point(22, 37);
            lblMessagesSubtitle.Name = "lblMessagesSubtitle";
            lblMessagesSubtitle.Size = new Size(296, 17);
            lblMessagesSubtitle.TabIndex = 1;
            lblMessagesSubtitle.Text = "Realtime device updates, warnings, and sync logs";
            // 
            // lblMessagesTitle
            // 
            lblMessagesTitle.AutoSize = true;
            lblMessagesTitle.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMessagesTitle.ForeColor = Color.FromArgb(31, 41, 55);
            lblMessagesTitle.Location = new Point(20, 14);
            lblMessagesTitle.Name = "lblMessagesTitle";
            lblMessagesTitle.Size = new Size(89, 20);
            lblMessagesTitle.TabIndex = 0;
            lblMessagesTitle.Text = "Activity Log";
            // 
            // lstMessages
            // 
            lstMessages.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstMessages.BackColor = Color.FromArgb(249, 250, 251);
            lstMessages.BorderStyle = BorderStyle.None;
            lstMessages.ForeColor = Color.FromArgb(31, 41, 55);
            lstMessages.FormattingEnabled = true;
            lstMessages.Location = new Point(22, 66);
            lstMessages.Name = "lstMessages";
            lstMessages.Size = new Size(1157, 85);
            lstMessages.TabIndex = 2;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(0, 717);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1241, 22);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(86, 17);
            lblStatus.Text = "Disconnected";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1241, 739);
            Controls.Add(pnlMessages);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pnlQuickActions);
            Controls.Add(pnlConnectionCard);
            Controls.Add(pnlHeader);
            Controls.Add(statusStrip1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(1257, 778);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SafeStep Desktop";
            Load += Form1_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlConnectionCard.ResumeLayout(false);
            pnlConnectionCard.PerformLayout();
            pnlQuickActions.ResumeLayout(false);
            pnlQuickActions.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            pnlAlarm.ResumeLayout(false);
            pnlAlarm.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            pnlMessages.ResumeLayout(false);
            pnlMessages.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label comPortText;
        private Button btnRefresh;
        private Button btnConnect;
        private Button btnDisconnect;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label lblAlarm;
        private Panel pnlAlarm;
        private Label lblAlarmDetail;
        private Label lblAlarmBadge;
        private Label lblAlarmIcon;
        private Label lblDistance;
        private Label lblDistanceTime;
        private Label lblBattery;
        private ProgressBar progressBattery;
        private ComboBox cmbPorts;
        private ComboBox cmbBaudRate;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private ListBox lstMessages;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart distanceChart;
        private Button btnOptions;
        private Button btnSos;
        private Button btnStatus;
        private Button btnPing;
        private Label lblTemperature;
        private Panel pnlHeader;
        private Label lblHeaderSubtitle;
        private Label lblHeaderTitle;
        private Panel pnlConnectionCard;
        private Label lblBaudTitle;
        private Panel pnlQuickActions;
        private Label lblQuickActions;
        private Label lblAlarmTitle;
        private Label lblTemperatureCaption;
        private Label lblDistanceTitle;
        private Label lblBatteryTitle;
        private Panel pnlMessages;
        private Label lblMessagesSubtitle;
        private Label lblMessagesTitle;
    }
}