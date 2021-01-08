namespace TimeKeeper.Reports
{
	partial class DailySummaryReport
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailySummaryReport));
			this.lvReportData = new System.Windows.Forms.ListView();
			this.chProject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chDepartment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
			this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
			this.lblStartDate = new System.Windows.Forms.Label();
			this.lblEndDate = new System.Windows.Forms.Label();
			this.btnUpdateReport = new System.Windows.Forms.Button();
			this.clbProjects = new System.Windows.Forms.CheckedListBox();
			this.btnProjects = new System.Windows.Forms.Button();
			this.lblTotalTime = new System.Windows.Forms.Label();
			this.lblTotalTimeLabel = new System.Windows.Forms.Label();
			this.lblTiRPLabel = new System.Windows.Forms.Label();
			this.lblTimeInReportPeriod = new System.Windows.Forms.Label();
			this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// lvReportData
			// 
			this.lvReportData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvReportData.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lvReportData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDate,
            this.chProject,
            this.chDepartment,
            this.chTime});
			this.lvReportData.FullRowSelect = true;
			this.lvReportData.GridLines = true;
			this.lvReportData.HideSelection = false;
			this.lvReportData.Location = new System.Drawing.Point(0, 38);
			this.lvReportData.MultiSelect = false;
			this.lvReportData.Name = "lvReportData";
			this.lvReportData.ShowGroups = false;
			this.lvReportData.Size = new System.Drawing.Size(748, 330);
			this.lvReportData.TabIndex = 7;
			this.lvReportData.TabStop = false;
			this.lvReportData.UseCompatibleStateImageBehavior = false;
			this.lvReportData.View = System.Windows.Forms.View.Details;
			this.lvReportData.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvReportData_ColumnClick);
			// 
			// chProject
			// 
			this.chProject.Text = "Project";
			this.chProject.Width = 289;
			// 
			// chDepartment
			// 
			this.chDepartment.Text = "Department";
			this.chDepartment.Width = 292;
			// 
			// chTime
			// 
			this.chTime.Text = "Time";
			this.chTime.Width = 88;
			// 
			// dtpStartDate
			// 
			this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpStartDate.Location = new System.Drawing.Point(73, 9);
			this.dtpStartDate.Name = "dtpStartDate";
			this.dtpStartDate.Size = new System.Drawing.Size(113, 20);
			this.dtpStartDate.TabIndex = 1;
			this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
			// 
			// dtpEndDate
			// 
			this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpEndDate.Location = new System.Drawing.Point(261, 9);
			this.dtpEndDate.Name = "dtpEndDate";
			this.dtpEndDate.Size = new System.Drawing.Size(107, 20);
			this.dtpEndDate.TabIndex = 3;
			this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
			// 
			// lblStartDate
			// 
			this.lblStartDate.AutoSize = true;
			this.lblStartDate.Location = new System.Drawing.Point(12, 12);
			this.lblStartDate.Name = "lblStartDate";
			this.lblStartDate.Size = new System.Drawing.Size(58, 13);
			this.lblStartDate.TabIndex = 0;
			this.lblStartDate.Text = "&Start Date:";
			// 
			// lblEndDate
			// 
			this.lblEndDate.AutoSize = true;
			this.lblEndDate.Location = new System.Drawing.Point(202, 12);
			this.lblEndDate.Name = "lblEndDate";
			this.lblEndDate.Size = new System.Drawing.Size(55, 13);
			this.lblEndDate.TabIndex = 2;
			this.lblEndDate.Text = "&End Date:";
			// 
			// btnUpdateReport
			// 
			this.btnUpdateReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnUpdateReport.Location = new System.Drawing.Point(639, 8);
			this.btnUpdateReport.Name = "btnUpdateReport";
			this.btnUpdateReport.Size = new System.Drawing.Size(97, 23);
			this.btnUpdateReport.TabIndex = 6;
			this.btnUpdateReport.Text = "&Update Report";
			this.btnUpdateReport.UseVisualStyleBackColor = true;
			this.btnUpdateReport.Click += new System.EventHandler(this.btnUpdateReport_Click);
			// 
			// clbProjects
			// 
			this.clbProjects.CheckOnClick = true;
			this.clbProjects.Location = new System.Drawing.Point(381, 29);
			this.clbProjects.Name = "clbProjects";
			this.clbProjects.Size = new System.Drawing.Size(232, 214);
			this.clbProjects.TabIndex = 5;
			this.clbProjects.Visible = false;
			this.clbProjects.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbProjects_ItemCheck);
			// 
			// btnProjects
			// 
			this.btnProjects.Location = new System.Drawing.Point(381, 8);
			this.btnProjects.Name = "btnProjects";
			this.btnProjects.Size = new System.Drawing.Size(75, 23);
			this.btnProjects.TabIndex = 4;
			this.btnProjects.Text = "&Projects...";
			this.btnProjects.UseVisualStyleBackColor = true;
			this.btnProjects.Click += new System.EventHandler(this.btnProjects_Click);
			// 
			// lblTotalTime
			// 
			this.lblTotalTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblTotalTime.AutoSize = true;
			this.lblTotalTime.Location = new System.Drawing.Point(263, 371);
			this.lblTotalTime.Name = "lblTotalTime";
			this.lblTotalTime.Size = new System.Drawing.Size(24, 13);
			this.lblTotalTime.TabIndex = 8;
			this.lblTotalTime.Text = "0 m";
			// 
			// lblTotalTimeLabel
			// 
			this.lblTotalTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblTotalTimeLabel.AutoSize = true;
			this.lblTotalTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalTimeLabel.Location = new System.Drawing.Point(217, 371);
			this.lblTotalTimeLabel.Name = "lblTotalTimeLabel";
			this.lblTotalTimeLabel.Size = new System.Drawing.Size(40, 13);
			this.lblTotalTimeLabel.TabIndex = 8;
			this.lblTotalTimeLabel.Text = "Total:";
			this.lblTotalTimeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblTiRPLabel
			// 
			this.lblTiRPLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblTiRPLabel.AutoSize = true;
			this.lblTiRPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTiRPLabel.Location = new System.Drawing.Point(12, 371);
			this.lblTiRPLabel.Name = "lblTiRPLabel";
			this.lblTiRPLabel.Size = new System.Drawing.Size(134, 13);
			this.lblTiRPLabel.TabIndex = 9;
			this.lblTiRPLabel.Text = "Time in Report Period:";
			// 
			// lblTimeInReportPeriod
			// 
			this.lblTimeInReportPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblTimeInReportPeriod.AutoSize = true;
			this.lblTimeInReportPeriod.Location = new System.Drawing.Point(152, 371);
			this.lblTimeInReportPeriod.Name = "lblTimeInReportPeriod";
			this.lblTimeInReportPeriod.Size = new System.Drawing.Size(24, 13);
			this.lblTimeInReportPeriod.TabIndex = 10;
			this.lblTimeInReportPeriod.Text = "0 m";
			// 
			// chDate
			// 
			this.chDate.Text = "Date";
			// 
			// DailySummaryReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(748, 391);
			this.Controls.Add(this.lblTimeInReportPeriod);
			this.Controls.Add(this.lblTiRPLabel);
			this.Controls.Add(this.lblTotalTimeLabel);
			this.Controls.Add(this.lblTotalTime);
			this.Controls.Add(this.btnProjects);
			this.Controls.Add(this.btnUpdateReport);
			this.Controls.Add(this.dtpEndDate);
			this.Controls.Add(this.dtpStartDate);
			this.Controls.Add(this.lblEndDate);
			this.Controls.Add(this.lblStartDate);
			this.Controls.Add(this.lvReportData);
			this.Controls.Add(this.clbProjects);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(585, 305);
			this.Name = "DailySummaryReport";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Daily Summary Report";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView lvReportData;
		private System.Windows.Forms.DateTimePicker dtpStartDate;
		private System.Windows.Forms.DateTimePicker dtpEndDate;
		private System.Windows.Forms.Label lblStartDate;
		private System.Windows.Forms.Label lblEndDate;
		private System.Windows.Forms.Button btnUpdateReport;
		private System.Windows.Forms.CheckedListBox clbProjects;
		private System.Windows.Forms.Button btnProjects;
		private System.Windows.Forms.ColumnHeader chProject;
		private System.Windows.Forms.ColumnHeader chDepartment;
		private System.Windows.Forms.ColumnHeader chTime;
		private System.Windows.Forms.Label lblTotalTime;
		private System.Windows.Forms.Label lblTotalTimeLabel;
		private System.Windows.Forms.Label lblTiRPLabel;
		private System.Windows.Forms.Label lblTimeInReportPeriod;
		private System.Windows.Forms.ColumnHeader chDate;
	}
}