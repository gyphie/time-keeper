namespace TimeKeeper
{
	partial class TimeDetailReport
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeDetailReport));
			this.lvReportData = new System.Windows.Forms.ListView();
			this.chEntryDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chProject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chDepartment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
			this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
			this.lblStartDate = new System.Windows.Forms.Label();
			this.lblEndDate = new System.Windows.Forms.Label();
			this.btnUpdateReport = new System.Windows.Forms.Button();
			this.clbProjects = new System.Windows.Forms.CheckedListBox();
			this.btnProjects = new System.Windows.Forms.Button();
			this.lblTotalTimeLabel = new System.Windows.Forms.Label();
			this.lblTotalTime = new System.Windows.Forms.Label();
			this.lblTimeInReportPeriod = new System.Windows.Forms.Label();
			this.lblTiRPLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lvReportData
			// 
			this.lvReportData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvReportData.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lvReportData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chEntryDate,
            this.chProject,
            this.chDepartment,
            this.chTime,
            this.chDescription});
			this.lvReportData.FullRowSelect = true;
			this.lvReportData.GridLines = true;
			this.lvReportData.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvReportData.HideSelection = false;
			this.lvReportData.Location = new System.Drawing.Point(0, 38);
			this.lvReportData.Name = "lvReportData";
			this.lvReportData.ShowGroups = false;
			this.lvReportData.Size = new System.Drawing.Size(993, 330);
			this.lvReportData.TabIndex = 7;
			this.lvReportData.TabStop = false;
			this.lvReportData.UseCompatibleStateImageBehavior = false;
			this.lvReportData.View = System.Windows.Forms.View.Details;
			// 
			// chEntryDate
			// 
			this.chEntryDate.Text = "Entry Date";
			this.chEntryDate.Width = 105;
			// 
			// chProject
			// 
			this.chProject.Text = "Project";
			this.chProject.Width = 257;
			// 
			// chDepartment
			// 
			this.chDepartment.Text = "Department";
			this.chDepartment.Width = 178;
			// 
			// chTime
			// 
			this.chTime.Text = "Time";
			// 
			// chDescription
			// 
			this.chDescription.Text = "Description";
			this.chDescription.Width = 379;
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
			this.btnUpdateReport.Location = new System.Drawing.Point(885, 8);
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
			// lblTotalTimeLabel
			// 
			this.lblTotalTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTotalTimeLabel.AutoSize = true;
			this.lblTotalTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalTimeLabel.Location = new System.Drawing.Point(501, 374);
			this.lblTotalTimeLabel.Name = "lblTotalTimeLabel";
			this.lblTotalTimeLabel.Size = new System.Drawing.Size(40, 13);
			this.lblTotalTimeLabel.TabIndex = 9;
			this.lblTotalTimeLabel.Text = "Total:";
			this.lblTotalTimeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblTotalTime
			// 
			this.lblTotalTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTotalTime.AutoSize = true;
			this.lblTotalTime.Location = new System.Drawing.Point(544, 374);
			this.lblTotalTime.Name = "lblTotalTime";
			this.lblTotalTime.Size = new System.Drawing.Size(13, 13);
			this.lblTotalTime.TabIndex = 10;
			this.lblTotalTime.Text = "0";
			// 
			// lblTimeInReportPeriod
			// 
			this.lblTimeInReportPeriod.AutoSize = true;
			this.lblTimeInReportPeriod.Location = new System.Drawing.Point(407, 374);
			this.lblTimeInReportPeriod.Name = "lblTimeInReportPeriod";
			this.lblTimeInReportPeriod.Size = new System.Drawing.Size(24, 13);
			this.lblTimeInReportPeriod.TabIndex = 12;
			this.lblTimeInReportPeriod.Text = "0 m";
			// 
			// lblTiRPLabel
			// 
			this.lblTiRPLabel.AutoSize = true;
			this.lblTiRPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTiRPLabel.Location = new System.Drawing.Point(267, 374);
			this.lblTiRPLabel.Name = "lblTiRPLabel";
			this.lblTiRPLabel.Size = new System.Drawing.Size(134, 13);
			this.lblTiRPLabel.TabIndex = 11;
			this.lblTiRPLabel.Text = "Time in Report Period:";
			// 
			// TimeDetailReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(994, 396);
			this.Controls.Add(this.lblTimeInReportPeriod);
			this.Controls.Add(this.lblTiRPLabel);
			this.Controls.Add(this.lblTotalTimeLabel);
			this.Controls.Add(this.lblTotalTime);
			this.Controls.Add(this.clbProjects);
			this.Controls.Add(this.btnProjects);
			this.Controls.Add(this.btnUpdateReport);
			this.Controls.Add(this.dtpEndDate);
			this.Controls.Add(this.dtpStartDate);
			this.Controls.Add(this.lvReportData);
			this.Controls.Add(this.lblEndDate);
			this.Controls.Add(this.lblStartDate);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(585, 435);
			this.Name = "TimeDetailReport";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Log Detail Report";
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
		private System.Windows.Forms.ColumnHeader chEntryDate;
		private System.Windows.Forms.ColumnHeader chProject;
		private System.Windows.Forms.ColumnHeader chDepartment;
		private System.Windows.Forms.ColumnHeader chTime;
		private System.Windows.Forms.ColumnHeader chDescription;
		private System.Windows.Forms.Label lblTotalTimeLabel;
		private System.Windows.Forms.Label lblTotalTime;
		private System.Windows.Forms.Label lblTimeInReportPeriod;
		private System.Windows.Forms.Label lblTiRPLabel;
	}
}