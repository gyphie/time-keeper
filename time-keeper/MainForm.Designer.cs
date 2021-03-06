﻿namespace TimeKeeper
{
	partial class frmTimeKeeper
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimeKeeper));
			this.btnSave = new System.Windows.Forms.Button();
			this.timInterval = new System.Windows.Forms.Timer(this.components);
			this.niTimeKeeper = new System.Windows.Forms.NotifyIcon(this.components);
			this.cmsNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.timFlasher = new System.Windows.Forms.Timer(this.components);
			this.timOpened = new System.Windows.Forms.Timer(this.components);
			this.lblMinutes = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.dispName = new System.Windows.Forms.Label();
			this.lblProject = new System.Windows.Forms.Label();
			this.lblTime = new System.Windows.Forms.Label();
			this.lblDescription = new System.Windows.Forms.Label();
			this.cdButtonColor = new System.Windows.Forms.ColorDialog();
			this.dispMinutes = new System.Windows.Forms.Label();
			this.msMain = new System.Windows.Forms.MenuStrip();
			this.timeKeeperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.detailReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.summaryReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dailySummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resetTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.minutes15ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.minutes30ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hour1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hour2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hour8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clearPauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.prompToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.prompt5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.prompt10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.prompt15ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.prompt30ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.prompt60ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.windowTransparencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.trans0StripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.trans25StripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.trans50StripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.trans75StripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.buttonColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.llDiscardTime = new System.Windows.Forms.LinkLabel();
			this.timeBox7 = new System.Windows.Forms.TextBox();
			this.timeBox6 = new System.Windows.Forms.TextBox();
			this.timeBox5 = new System.Windows.Forms.TextBox();
			this.timeBox4 = new System.Windows.Forms.TextBox();
			this.timeBox3 = new System.Windows.Forms.TextBox();
			this.timeBox2 = new System.Windows.Forms.TextBox();
			this.descriptionBox7 = new System.Windows.Forms.TextBox();
			this.descriptionBox6 = new System.Windows.Forms.TextBox();
			this.descriptionBox5 = new System.Windows.Forms.TextBox();
			this.descriptionBox4 = new System.Windows.Forms.TextBox();
			this.descriptionBox3 = new System.Windows.Forms.TextBox();
			this.descriptionBox2 = new System.Windows.Forms.TextBox();
			this.descriptionBox1 = new System.Windows.Forms.TextBox();
			this.timeBox1 = new System.Windows.Forms.TextBox();
			this.projectBox7 = new GroupedComboBox();
			this.projectBox6 = new GroupedComboBox();
			this.projectBox5 = new GroupedComboBox();
			this.projectBox4 = new GroupedComboBox();
			this.projectBox3 = new GroupedComboBox();
			this.projectBox2 = new GroupedComboBox();
			this.projectBox1 = new GroupedComboBox();
			this.deleteBtn1 = new System.Windows.Forms.Label();
			this.deleteBtn2 = new System.Windows.Forms.Label();
			this.deleteBtn3 = new System.Windows.Forms.Label();
			this.deleteBtn4 = new System.Windows.Forms.Label();
			this.deleteBtn5 = new System.Windows.Forms.Label();
			this.deleteBtn6 = new System.Windows.Forms.Label();
			this.deleteBtn7 = new System.Windows.Forms.Label();
			this.removeUnusedRowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cmsNotifyIcon.SuspendLayout();
			this.msMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(399, 210);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 28);
			this.btnSave.TabIndex = 37;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// timInterval
			// 
			this.timInterval.Interval = 10000;
			this.timInterval.Tick += new System.EventHandler(this.timInterval_Tick);
			// 
			// niTimeKeeper
			// 
			this.niTimeKeeper.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.niTimeKeeper.BalloonTipText = "Keeping Time";
			this.niTimeKeeper.BalloonTipTitle = "Time Keeper";
			this.niTimeKeeper.ContextMenuStrip = this.cmsNotifyIcon;
			this.niTimeKeeper.Icon = ((System.Drawing.Icon)(resources.GetObject("niTimeKeeper.Icon")));
			this.niTimeKeeper.Text = "TimeKeeper";
			this.niTimeKeeper.Visible = true;
			this.niTimeKeeper.BalloonTipClicked += new System.EventHandler(this.niTimeKeeper_DoubleClick);
			this.niTimeKeeper.DoubleClick += new System.EventHandler(this.niTimeKeeper_DoubleClick);
			// 
			// cmsNotifyIcon
			// 
			this.cmsNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.cmsNotifyIcon.Name = "cmsNotifyIcon";
			this.cmsNotifyIcon.Size = new System.Drawing.Size(104, 48);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.openToolStripMenuItem.Text = "&Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// timFlasher
			// 
			this.timFlasher.Interval = 10;
			this.timFlasher.Tick += new System.EventHandler(this.timFlasher_Tick);
			// 
			// timOpened
			// 
			this.timOpened.Interval = 15000;
			this.timOpened.Tick += new System.EventHandler(this.timOpened_Tick);
			// 
			// lblMinutes
			// 
			this.lblMinutes.AutoSize = true;
			this.lblMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMinutes.Location = new System.Drawing.Point(16, 206);
			this.lblMinutes.Name = "lblMinutes";
			this.lblMinutes.Size = new System.Drawing.Size(55, 13);
			this.lblMinutes.TabIndex = 32;
			this.lblMinutes.Text = "Minutes:";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.Location = new System.Drawing.Point(16, 225);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(43, 13);
			this.lblName.TabIndex = 34;
			this.lblName.Text = "Name:";
			// 
			// dispName
			// 
			this.dispName.AutoSize = true;
			this.dispName.Location = new System.Drawing.Point(77, 225);
			this.dispName.Name = "dispName";
			this.dispName.Size = new System.Drawing.Size(53, 13);
			this.dispName.TabIndex = 35;
			this.dispName.Text = "Unknown";
			// 
			// lblProject
			// 
			this.lblProject.AutoSize = true;
			this.lblProject.Location = new System.Drawing.Point(16, 34);
			this.lblProject.Name = "lblProject";
			this.lblProject.Size = new System.Drawing.Size(40, 13);
			this.lblProject.TabIndex = 1;
			this.lblProject.Text = "Project";
			// 
			// lblTime
			// 
			this.lblTime.AutoSize = true;
			this.lblTime.Location = new System.Drawing.Point(226, 34);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(30, 13);
			this.lblTime.TabIndex = 2;
			this.lblTime.Text = "Time";
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.Location = new System.Drawing.Point(275, 34);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(60, 13);
			this.lblDescription.TabIndex = 3;
			this.lblDescription.Text = "Description";
			// 
			// cdButtonColor
			// 
			this.cdButtonColor.AnyColor = true;
			this.cdButtonColor.Color = System.Drawing.Color.LightCyan;
			this.cdButtonColor.FullOpen = true;
			// 
			// dispMinutes
			// 
			this.dispMinutes.AutoSize = true;
			this.dispMinutes.Location = new System.Drawing.Point(77, 206);
			this.dispMinutes.Name = "dispMinutes";
			this.dispMinutes.Size = new System.Drawing.Size(57, 17);
			this.dispMinutes.TabIndex = 33;
			this.dispMinutes.TabStop = true;
			this.dispMinutes.Text = "0 m of 0 m";
			this.dispMinutes.UseCompatibleTextRendering = true;
			// 
			// msMain
			// 
			this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeKeeperToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.settingsToolStripMenuItem});
			this.msMain.Location = new System.Drawing.Point(0, 0);
			this.msMain.Name = "msMain";
			this.msMain.Size = new System.Drawing.Size(494, 24);
			this.msMain.TabIndex = 0;
			this.msMain.Text = "Menu";
			// 
			// timeKeeperToolStripMenuItem
			// 
			this.timeKeeperToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem1});
			this.timeKeeperToolStripMenuItem.Name = "timeKeeperToolStripMenuItem";
			this.timeKeeperToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.timeKeeperToolStripMenuItem.Text = "&File";
			// 
			// projectToolStripMenuItem
			// 
			this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
			this.projectToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.projectToolStripMenuItem.Text = "&Projects...";
			this.projectToolStripMenuItem.Click += new System.EventHandler(this.newProjectToolStripMenuItem_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.aboutToolStripMenuItem.Text = "&About...";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem1
			// 
			this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
			this.exitToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
			this.exitToolStripMenuItem1.Text = "E&xit";
			this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// reportsToolStripMenuItem
			// 
			this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailReportToolStripMenuItem,
            this.summaryReportToolStripMenuItem,
            this.dailySummaryToolStripMenuItem});
			this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
			this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
			this.reportsToolStripMenuItem.Text = "Reports";
			// 
			// detailReportToolStripMenuItem
			// 
			this.detailReportToolStripMenuItem.Name = "detailReportToolStripMenuItem";
			this.detailReportToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.detailReportToolStripMenuItem.Text = "Log Detail...";
			this.detailReportToolStripMenuItem.Click += new System.EventHandler(this.detailReportToolStripMenuItem_Click);
			// 
			// summaryReportToolStripMenuItem
			// 
			this.summaryReportToolStripMenuItem.Name = "summaryReportToolStripMenuItem";
			this.summaryReportToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.summaryReportToolStripMenuItem.Text = "Project Summary...";
			this.summaryReportToolStripMenuItem.Click += new System.EventHandler(this.summaryReportToolStripMenuItem_Click);
			// 
			// dailySummaryToolStripMenuItem
			// 
			this.dailySummaryToolStripMenuItem.Name = "dailySummaryToolStripMenuItem";
			this.dailySummaryToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.dailySummaryToolStripMenuItem.Text = "Daily Summary...";
			this.dailySummaryToolStripMenuItem.Click += new System.EventHandler(this.dailySummaryToolStripMenuItem_Click);
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetTimeToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.clearToolStripMenuItem});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
			this.toolsToolStripMenuItem.Text = "&Tools";
			// 
			// resetTimeToolStripMenuItem
			// 
			this.resetTimeToolStripMenuItem.Name = "resetTimeToolStripMenuItem";
			this.resetTimeToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
			this.resetTimeToolStripMenuItem.Text = "&Reset Time";
			this.resetTimeToolStripMenuItem.Click += new System.EventHandler(this.btnDiscard_Click);
			// 
			// pauseToolStripMenuItem
			// 
			this.pauseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minutes15ToolStripMenuItem,
            this.minutes30ToolStripMenuItem,
            this.hour1ToolStripMenuItem,
            this.hour2ToolStripMenuItem,
            this.hour8ToolStripMenuItem,
            this.clearPauseToolStripMenuItem});
			this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
			this.pauseToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
			this.pauseToolStripMenuItem.Text = "&Pause Prompting";
			// 
			// minutes15ToolStripMenuItem
			// 
			this.minutes15ToolStripMenuItem.Name = "minutes15ToolStripMenuItem";
			this.minutes15ToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.minutes15ToolStripMenuItem.Text = "15 &minutes";
			this.minutes15ToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
			// 
			// minutes30ToolStripMenuItem
			// 
			this.minutes30ToolStripMenuItem.Name = "minutes30ToolStripMenuItem";
			this.minutes30ToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.minutes30ToolStripMenuItem.Text = "&30 minutes";
			this.minutes30ToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
			// 
			// hour1ToolStripMenuItem
			// 
			this.hour1ToolStripMenuItem.Name = "hour1ToolStripMenuItem";
			this.hour1ToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.hour1ToolStripMenuItem.Text = "&1 hour";
			this.hour1ToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
			// 
			// hour2ToolStripMenuItem
			// 
			this.hour2ToolStripMenuItem.Name = "hour2ToolStripMenuItem";
			this.hour2ToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.hour2ToolStripMenuItem.Text = "&2 hours";
			this.hour2ToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
			// 
			// hour8ToolStripMenuItem
			// 
			this.hour8ToolStripMenuItem.Name = "hour8ToolStripMenuItem";
			this.hour8ToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.hour8ToolStripMenuItem.Text = "&8 hours";
			this.hour8ToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
			// 
			// clearPauseToolStripMenuItem
			// 
			this.clearPauseToolStripMenuItem.Name = "clearPauseToolStripMenuItem";
			this.clearPauseToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.clearPauseToolStripMenuItem.Text = "&Resume Prompting";
			this.clearPauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
			// 
			// clearToolStripMenuItem
			// 
			this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
			this.clearToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
			this.clearToolStripMenuItem.Text = "&Clear Entries";
			this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prompToolStripMenuItem,
            this.windowTransparencyToolStripMenuItem,
            this.buttonColorToolStripMenuItem,
            this.nameToolStripMenuItem,
            this.removeUnusedRowsToolStripMenuItem});
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.settingsToolStripMenuItem.Text = "&Settings";
			// 
			// prompToolStripMenuItem
			// 
			this.prompToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prompt5ToolStripMenuItem,
            this.prompt10ToolStripMenuItem,
            this.prompt15ToolStripMenuItem,
            this.prompt30ToolStripMenuItem,
            this.prompt60ToolStripMenuItem});
			this.prompToolStripMenuItem.Name = "prompToolStripMenuItem";
			this.prompToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
			this.prompToolStripMenuItem.Text = "&Prompt Every";
			// 
			// prompt5ToolStripMenuItem
			// 
			this.prompt5ToolStripMenuItem.Name = "prompt5ToolStripMenuItem";
			this.prompt5ToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.prompt5ToolStripMenuItem.Text = "&5 minutes";
			this.prompt5ToolStripMenuItem.Click += new System.EventHandler(this.promptToolStripMenuItem_Click);
			// 
			// prompt10ToolStripMenuItem
			// 
			this.prompt10ToolStripMenuItem.Name = "prompt10ToolStripMenuItem";
			this.prompt10ToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.prompt10ToolStripMenuItem.Text = "&10 minutes";
			this.prompt10ToolStripMenuItem.Click += new System.EventHandler(this.promptToolStripMenuItem_Click);
			// 
			// prompt15ToolStripMenuItem
			// 
			this.prompt15ToolStripMenuItem.Name = "prompt15ToolStripMenuItem";
			this.prompt15ToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.prompt15ToolStripMenuItem.Text = "15 &minutes";
			this.prompt15ToolStripMenuItem.Click += new System.EventHandler(this.promptToolStripMenuItem_Click);
			// 
			// prompt30ToolStripMenuItem
			// 
			this.prompt30ToolStripMenuItem.Name = "prompt30ToolStripMenuItem";
			this.prompt30ToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.prompt30ToolStripMenuItem.Text = "&30 minutes";
			this.prompt30ToolStripMenuItem.Click += new System.EventHandler(this.promptToolStripMenuItem_Click);
			// 
			// prompt60ToolStripMenuItem
			// 
			this.prompt60ToolStripMenuItem.Name = "prompt60ToolStripMenuItem";
			this.prompt60ToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.prompt60ToolStripMenuItem.Text = "1 &hour";
			this.prompt60ToolStripMenuItem.Click += new System.EventHandler(this.promptToolStripMenuItem_Click);
			// 
			// windowTransparencyToolStripMenuItem
			// 
			this.windowTransparencyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trans0StripMenuItem,
            this.trans25StripMenuItem,
            this.trans50StripMenuItem,
            this.trans75StripMenuItem});
			this.windowTransparencyToolStripMenuItem.Name = "windowTransparencyToolStripMenuItem";
			this.windowTransparencyToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
			this.windowTransparencyToolStripMenuItem.Text = "&Window Transparency";
			// 
			// trans0StripMenuItem
			// 
			this.trans0StripMenuItem.Name = "trans0StripMenuItem";
			this.trans0StripMenuItem.Size = new System.Drawing.Size(96, 22);
			this.trans0StripMenuItem.Text = "&0%";
			this.trans0StripMenuItem.Click += new System.EventHandler(this.transToolStripMenuItem_Click);
			// 
			// trans25StripMenuItem
			// 
			this.trans25StripMenuItem.Name = "trans25StripMenuItem";
			this.trans25StripMenuItem.Size = new System.Drawing.Size(96, 22);
			this.trans25StripMenuItem.Text = "&25%";
			this.trans25StripMenuItem.Click += new System.EventHandler(this.transToolStripMenuItem_Click);
			// 
			// trans50StripMenuItem
			// 
			this.trans50StripMenuItem.Name = "trans50StripMenuItem";
			this.trans50StripMenuItem.Size = new System.Drawing.Size(96, 22);
			this.trans50StripMenuItem.Text = "&50%";
			this.trans50StripMenuItem.Click += new System.EventHandler(this.transToolStripMenuItem_Click);
			// 
			// trans75StripMenuItem
			// 
			this.trans75StripMenuItem.Name = "trans75StripMenuItem";
			this.trans75StripMenuItem.Size = new System.Drawing.Size(96, 22);
			this.trans75StripMenuItem.Text = "&75%";
			this.trans75StripMenuItem.Click += new System.EventHandler(this.transToolStripMenuItem_Click);
			// 
			// buttonColorToolStripMenuItem
			// 
			this.buttonColorToolStripMenuItem.Name = "buttonColorToolStripMenuItem";
			this.buttonColorToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
			this.buttonColorToolStripMenuItem.Text = "&Button Color...";
			this.buttonColorToolStripMenuItem.Click += new System.EventHandler(this.btnColor_Click);
			// 
			// nameToolStripMenuItem
			// 
			this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
			this.nameToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
			this.nameToolStripMenuItem.Text = "&Name...";
			this.nameToolStripMenuItem.Click += new System.EventHandler(this.nameToolStripMenuItem_Click);
			// 
			// llDiscardTime
			// 
			this.llDiscardTime.AutoSize = true;
			this.llDiscardTime.Location = new System.Drawing.Point(324, 218);
			this.llDiscardTime.Name = "llDiscardTime";
			this.llDiscardTime.Size = new System.Drawing.Size(69, 13);
			this.llDiscardTime.TabIndex = 36;
			this.llDiscardTime.TabStop = true;
			this.llDiscardTime.Text = "Discard Time";
			this.llDiscardTime.Click += new System.EventHandler(this.btnDiscard_Click);
			// 
			// timeBox7
			// 
			this.timeBox7.Location = new System.Drawing.Point(221, 170);
			this.timeBox7.Name = "timeBox7";
			this.timeBox7.Size = new System.Drawing.Size(45, 20);
			this.timeBox7.TabIndex = 29;
			// 
			// timeBox6
			// 
			this.timeBox6.Location = new System.Drawing.Point(221, 150);
			this.timeBox6.Name = "timeBox6";
			this.timeBox6.Size = new System.Drawing.Size(45, 20);
			this.timeBox6.TabIndex = 25;
			// 
			// timeBox5
			// 
			this.timeBox5.Location = new System.Drawing.Point(221, 130);
			this.timeBox5.Name = "timeBox5";
			this.timeBox5.Size = new System.Drawing.Size(45, 20);
			this.timeBox5.TabIndex = 21;
			// 
			// timeBox4
			// 
			this.timeBox4.Location = new System.Drawing.Point(221, 110);
			this.timeBox4.Name = "timeBox4";
			this.timeBox4.Size = new System.Drawing.Size(45, 20);
			this.timeBox4.TabIndex = 17;
			// 
			// timeBox3
			// 
			this.timeBox3.Location = new System.Drawing.Point(221, 90);
			this.timeBox3.Name = "timeBox3";
			this.timeBox3.Size = new System.Drawing.Size(45, 20);
			this.timeBox3.TabIndex = 13;
			// 
			// timeBox2
			// 
			this.timeBox2.Location = new System.Drawing.Point(221, 70);
			this.timeBox2.Name = "timeBox2";
			this.timeBox2.Size = new System.Drawing.Size(45, 20);
			this.timeBox2.TabIndex = 9;
			// 
			// descriptionBox7
			// 
			this.descriptionBox7.Location = new System.Drawing.Point(265, 170);
			this.descriptionBox7.Name = "descriptionBox7";
			this.descriptionBox7.Size = new System.Drawing.Size(194, 20);
			this.descriptionBox7.TabIndex = 30;
			// 
			// descriptionBox6
			// 
			this.descriptionBox6.Location = new System.Drawing.Point(265, 150);
			this.descriptionBox6.Name = "descriptionBox6";
			this.descriptionBox6.Size = new System.Drawing.Size(194, 20);
			this.descriptionBox6.TabIndex = 26;
			// 
			// descriptionBox5
			// 
			this.descriptionBox5.Location = new System.Drawing.Point(265, 130);
			this.descriptionBox5.Name = "descriptionBox5";
			this.descriptionBox5.Size = new System.Drawing.Size(194, 20);
			this.descriptionBox5.TabIndex = 22;
			// 
			// descriptionBox4
			// 
			this.descriptionBox4.Location = new System.Drawing.Point(265, 110);
			this.descriptionBox4.Name = "descriptionBox4";
			this.descriptionBox4.Size = new System.Drawing.Size(194, 20);
			this.descriptionBox4.TabIndex = 18;
			// 
			// descriptionBox3
			// 
			this.descriptionBox3.Location = new System.Drawing.Point(265, 90);
			this.descriptionBox3.Name = "descriptionBox3";
			this.descriptionBox3.Size = new System.Drawing.Size(194, 20);
			this.descriptionBox3.TabIndex = 14;
			// 
			// descriptionBox2
			// 
			this.descriptionBox2.Location = new System.Drawing.Point(265, 70);
			this.descriptionBox2.Name = "descriptionBox2";
			this.descriptionBox2.Size = new System.Drawing.Size(194, 20);
			this.descriptionBox2.TabIndex = 10;
			// 
			// descriptionBox1
			// 
			this.descriptionBox1.Location = new System.Drawing.Point(265, 50);
			this.descriptionBox1.Name = "descriptionBox1";
			this.descriptionBox1.Size = new System.Drawing.Size(194, 20);
			this.descriptionBox1.TabIndex = 6;
			// 
			// timeBox1
			// 
			this.timeBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.timeBox1.Location = new System.Drawing.Point(221, 50);
			this.timeBox1.Name = "timeBox1";
			this.timeBox1.Size = new System.Drawing.Size(45, 20);
			this.timeBox1.TabIndex = 5;
			// 
			// projectBox7
			// 
			this.projectBox7.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.projectBox7.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.projectBox7.DataSource = null;
			this.projectBox7.DisplayMember = "Name";
			this.projectBox7.DropDownHeight = 500;
			this.projectBox7.DropDownWidth = 350;
			this.projectBox7.FormattingEnabled = true;
			this.projectBox7.GroupMember = "Department";
			this.projectBox7.IntegralHeight = false;
			this.projectBox7.Location = new System.Drawing.Point(12, 170);
			this.projectBox7.Name = "projectBox7";
			this.projectBox7.Size = new System.Drawing.Size(210, 21);
			this.projectBox7.TabIndex = 28;
			this.projectBox7.ValueMember = "ProjectID";
			// 
			// projectBox6
			// 
			this.projectBox6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.projectBox6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.projectBox6.DataSource = null;
			this.projectBox6.DisplayMember = "Name";
			this.projectBox6.DropDownHeight = 500;
			this.projectBox6.DropDownWidth = 350;
			this.projectBox6.FormattingEnabled = true;
			this.projectBox6.GroupMember = "Department";
			this.projectBox6.IntegralHeight = false;
			this.projectBox6.Location = new System.Drawing.Point(12, 150);
			this.projectBox6.Name = "projectBox6";
			this.projectBox6.Size = new System.Drawing.Size(210, 21);
			this.projectBox6.TabIndex = 24;
			this.projectBox6.ValueMember = "ProjectID";
			// 
			// projectBox5
			// 
			this.projectBox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.projectBox5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.projectBox5.DataSource = null;
			this.projectBox5.DisplayMember = "Name";
			this.projectBox5.DropDownHeight = 500;
			this.projectBox5.DropDownWidth = 350;
			this.projectBox5.FormattingEnabled = true;
			this.projectBox5.GroupMember = "Department";
			this.projectBox5.IntegralHeight = false;
			this.projectBox5.Location = new System.Drawing.Point(12, 130);
			this.projectBox5.Name = "projectBox5";
			this.projectBox5.Size = new System.Drawing.Size(210, 21);
			this.projectBox5.TabIndex = 20;
			this.projectBox5.ValueMember = "ProjectID";
			// 
			// projectBox4
			// 
			this.projectBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.projectBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.projectBox4.DataSource = null;
			this.projectBox4.DisplayMember = "Name";
			this.projectBox4.DropDownHeight = 500;
			this.projectBox4.DropDownWidth = 350;
			this.projectBox4.FormattingEnabled = true;
			this.projectBox4.GroupMember = "Department";
			this.projectBox4.IntegralHeight = false;
			this.projectBox4.Location = new System.Drawing.Point(12, 110);
			this.projectBox4.Name = "projectBox4";
			this.projectBox4.Size = new System.Drawing.Size(210, 21);
			this.projectBox4.TabIndex = 16;
			this.projectBox4.ValueMember = "ProjectID";
			// 
			// projectBox3
			// 
			this.projectBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.projectBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.projectBox3.DataSource = null;
			this.projectBox3.DisplayMember = "Name";
			this.projectBox3.DropDownHeight = 500;
			this.projectBox3.DropDownWidth = 350;
			this.projectBox3.FormattingEnabled = true;
			this.projectBox3.GroupMember = "Department";
			this.projectBox3.IntegralHeight = false;
			this.projectBox3.Location = new System.Drawing.Point(12, 90);
			this.projectBox3.Name = "projectBox3";
			this.projectBox3.Size = new System.Drawing.Size(210, 21);
			this.projectBox3.TabIndex = 12;
			this.projectBox3.ValueMember = "ProjectID";
			// 
			// projectBox2
			// 
			this.projectBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.projectBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.projectBox2.DataSource = null;
			this.projectBox2.DisplayMember = "Name";
			this.projectBox2.DropDownHeight = 500;
			this.projectBox2.DropDownWidth = 350;
			this.projectBox2.FormattingEnabled = true;
			this.projectBox2.GroupMember = "Department";
			this.projectBox2.IntegralHeight = false;
			this.projectBox2.Location = new System.Drawing.Point(12, 70);
			this.projectBox2.Name = "projectBox2";
			this.projectBox2.Size = new System.Drawing.Size(210, 21);
			this.projectBox2.TabIndex = 8;
			this.projectBox2.ValueMember = "ProjectID";
			// 
			// projectBox1
			// 
			this.projectBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.projectBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.projectBox1.DataSource = null;
			this.projectBox1.DisplayMember = "Name";
			this.projectBox1.DropDownHeight = 500;
			this.projectBox1.DropDownWidth = 350;
			this.projectBox1.FormattingEnabled = true;
			this.projectBox1.GroupMember = "Department";
			this.projectBox1.IntegralHeight = false;
			this.projectBox1.Location = new System.Drawing.Point(12, 50);
			this.projectBox1.Name = "projectBox1";
			this.projectBox1.Size = new System.Drawing.Size(210, 21);
			this.projectBox1.TabIndex = 4;
			this.projectBox1.ValueMember = "ProjectID";
			// 
			// deleteBtn1
			// 
			this.deleteBtn1.BackColor = System.Drawing.Color.Transparent;
			this.deleteBtn1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.deleteBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deleteBtn1.ForeColor = System.Drawing.Color.DarkRed;
			this.deleteBtn1.Location = new System.Drawing.Point(460, 50);
			this.deleteBtn1.Name = "deleteBtn1";
			this.deleteBtn1.Size = new System.Drawing.Size(20, 20);
			this.deleteBtn1.TabIndex = 7;
			this.deleteBtn1.Text = "❌";
			this.deleteBtn1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// deleteBtn2
			// 
			this.deleteBtn2.BackColor = System.Drawing.Color.Transparent;
			this.deleteBtn2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.deleteBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deleteBtn2.ForeColor = System.Drawing.Color.DarkRed;
			this.deleteBtn2.Location = new System.Drawing.Point(460, 70);
			this.deleteBtn2.Name = "deleteBtn2";
			this.deleteBtn2.Size = new System.Drawing.Size(20, 20);
			this.deleteBtn2.TabIndex = 11;
			this.deleteBtn2.Text = "❌";
			this.deleteBtn2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// deleteBtn3
			// 
			this.deleteBtn3.BackColor = System.Drawing.Color.Transparent;
			this.deleteBtn3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.deleteBtn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deleteBtn3.ForeColor = System.Drawing.Color.DarkRed;
			this.deleteBtn3.Location = new System.Drawing.Point(460, 90);
			this.deleteBtn3.Name = "deleteBtn3";
			this.deleteBtn3.Size = new System.Drawing.Size(20, 20);
			this.deleteBtn3.TabIndex = 15;
			this.deleteBtn3.Text = "❌";
			this.deleteBtn3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// deleteBtn4
			// 
			this.deleteBtn4.BackColor = System.Drawing.Color.Transparent;
			this.deleteBtn4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.deleteBtn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deleteBtn4.ForeColor = System.Drawing.Color.DarkRed;
			this.deleteBtn4.Location = new System.Drawing.Point(460, 110);
			this.deleteBtn4.Name = "deleteBtn4";
			this.deleteBtn4.Size = new System.Drawing.Size(20, 20);
			this.deleteBtn4.TabIndex = 19;
			this.deleteBtn4.Text = "❌";
			this.deleteBtn4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// deleteBtn5
			// 
			this.deleteBtn5.BackColor = System.Drawing.Color.Transparent;
			this.deleteBtn5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.deleteBtn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deleteBtn5.ForeColor = System.Drawing.Color.DarkRed;
			this.deleteBtn5.Location = new System.Drawing.Point(460, 130);
			this.deleteBtn5.Name = "deleteBtn5";
			this.deleteBtn5.Size = new System.Drawing.Size(20, 20);
			this.deleteBtn5.TabIndex = 23;
			this.deleteBtn5.Text = "❌";
			this.deleteBtn5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// deleteBtn6
			// 
			this.deleteBtn6.BackColor = System.Drawing.Color.Transparent;
			this.deleteBtn6.Cursor = System.Windows.Forms.Cursors.Hand;
			this.deleteBtn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deleteBtn6.ForeColor = System.Drawing.Color.DarkRed;
			this.deleteBtn6.Location = new System.Drawing.Point(460, 150);
			this.deleteBtn6.Name = "deleteBtn6";
			this.deleteBtn6.Size = new System.Drawing.Size(20, 20);
			this.deleteBtn6.TabIndex = 27;
			this.deleteBtn6.Text = "❌";
			this.deleteBtn6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// deleteBtn7
			// 
			this.deleteBtn7.BackColor = System.Drawing.Color.Transparent;
			this.deleteBtn7.Cursor = System.Windows.Forms.Cursors.Hand;
			this.deleteBtn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deleteBtn7.ForeColor = System.Drawing.Color.DarkRed;
			this.deleteBtn7.Location = new System.Drawing.Point(460, 170);
			this.deleteBtn7.Name = "deleteBtn7";
			this.deleteBtn7.Size = new System.Drawing.Size(20, 20);
			this.deleteBtn7.TabIndex = 31;
			this.deleteBtn7.Text = "❌";
			this.deleteBtn7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// removeUnusedRowsToolStripMenuItem
			// 
			this.removeUnusedRowsToolStripMenuItem.CheckOnClick = true;
			this.removeUnusedRowsToolStripMenuItem.Name = "removeUnusedRowsToolStripMenuItem";
			this.removeUnusedRowsToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
			this.removeUnusedRowsToolStripMenuItem.Text = "&Remove Unused Rows";
			this.removeUnusedRowsToolStripMenuItem.Visible = false;
			this.removeUnusedRowsToolStripMenuItem.Click += new System.EventHandler(this.removeUnusedRowsToolStripMenuItem_Click);
			// 
			// frmTimeKeeper
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(494, 247);
			this.Controls.Add(this.deleteBtn7);
			this.Controls.Add(this.deleteBtn6);
			this.Controls.Add(this.deleteBtn5);
			this.Controls.Add(this.deleteBtn4);
			this.Controls.Add(this.deleteBtn3);
			this.Controls.Add(this.deleteBtn2);
			this.Controls.Add(this.deleteBtn1);
			this.Controls.Add(this.descriptionBox1);
			this.Controls.Add(this.timeBox7);
			this.Controls.Add(this.timeBox6);
			this.Controls.Add(this.timeBox5);
			this.Controls.Add(this.timeBox4);
			this.Controls.Add(this.timeBox3);
			this.Controls.Add(this.timeBox2);
			this.Controls.Add(this.descriptionBox7);
			this.Controls.Add(this.descriptionBox6);
			this.Controls.Add(this.descriptionBox5);
			this.Controls.Add(this.descriptionBox4);
			this.Controls.Add(this.descriptionBox3);
			this.Controls.Add(this.descriptionBox2);
			this.Controls.Add(this.timeBox1);
			this.Controls.Add(this.projectBox7);
			this.Controls.Add(this.projectBox6);
			this.Controls.Add(this.projectBox5);
			this.Controls.Add(this.projectBox4);
			this.Controls.Add(this.projectBox3);
			this.Controls.Add(this.projectBox2);
			this.Controls.Add(this.projectBox1);
			this.Controls.Add(this.llDiscardTime);
			this.Controls.Add(this.msMain);
			this.Controls.Add(this.dispMinutes);
			this.Controls.Add(this.lblDescription);
			this.Controls.Add(this.lblTime);
			this.Controls.Add(this.lblProject);
			this.Controls.Add(this.dispName);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.lblMinutes);
			this.Controls.Add(this.btnSave);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MainMenuStrip = this.msMain;
			this.MaximizeBox = false;
			this.Name = "frmTimeKeeper";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Time Keeper";
			this.Activated += new System.EventHandler(this.frmTimeKeeper_Activated);
			this.Deactivate += new System.EventHandler(this.frmTimeKeeper_Deactivate);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTimeKeeper_FormClosing);
			this.Load += new System.EventHandler(this.frmTimeKeeper_Load);
			this.cmsNotifyIcon.ResumeLayout(false);
			this.msMain.ResumeLayout(false);
			this.msMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Timer timInterval;
		private System.Windows.Forms.NotifyIcon niTimeKeeper;
		private System.Windows.Forms.ContextMenuStrip cmsNotifyIcon;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.Timer timFlasher;
		private System.Windows.Forms.Timer timOpened;
		private System.Windows.Forms.Label lblMinutes;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label dispName;
		private System.Windows.Forms.Label lblProject;
		private System.Windows.Forms.Label lblTime;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.ColorDialog cdButtonColor;
		private System.Windows.Forms.Label dispMinutes;
		private System.Windows.Forms.MenuStrip msMain;
		private System.Windows.Forms.ToolStripMenuItem timeKeeperToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem prompToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem prompt5ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem prompt10ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem prompt15ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem prompt30ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem prompt60ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem windowTransparencyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem trans0StripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem trans25StripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem trans50StripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem trans75StripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem resetTimeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem minutes15ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem minutes30ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hour1ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hour2ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hour8ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clearPauseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
		private System.Windows.Forms.LinkLabel llDiscardTime;
		private System.Windows.Forms.ToolStripMenuItem buttonColorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem detailReportToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem summaryReportToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
		private System.Windows.Forms.TextBox timeBox7;
		private System.Windows.Forms.TextBox timeBox6;
		private System.Windows.Forms.TextBox timeBox5;
		private System.Windows.Forms.TextBox timeBox4;
		private System.Windows.Forms.TextBox timeBox3;
		private System.Windows.Forms.TextBox timeBox2;
		private System.Windows.Forms.TextBox descriptionBox7;
		private System.Windows.Forms.TextBox descriptionBox6;
		private System.Windows.Forms.TextBox descriptionBox5;
		private System.Windows.Forms.TextBox descriptionBox4;
		private System.Windows.Forms.TextBox descriptionBox3;
		private System.Windows.Forms.TextBox descriptionBox2;
		private System.Windows.Forms.TextBox descriptionBox1;
		private System.Windows.Forms.TextBox timeBox1;
		private GroupedComboBox projectBox7;
		private GroupedComboBox projectBox6;
		private GroupedComboBox projectBox5;
		private GroupedComboBox projectBox4;
		private GroupedComboBox projectBox3;
		private GroupedComboBox projectBox2;
		private GroupedComboBox projectBox1;
		private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
		private System.Windows.Forms.Label deleteBtn1;
		private System.Windows.Forms.Label deleteBtn2;
		private System.Windows.Forms.Label deleteBtn3;
		private System.Windows.Forms.Label deleteBtn4;
		private System.Windows.Forms.Label deleteBtn5;
		private System.Windows.Forms.Label deleteBtn6;
		private System.Windows.Forms.Label deleteBtn7;
		private System.Windows.Forms.ToolStripMenuItem dailySummaryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removeUnusedRowsToolStripMenuItem;
	}
}

