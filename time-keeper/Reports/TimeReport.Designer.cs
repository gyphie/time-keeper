namespace TimeKeeper
{
	partial class TimeReport
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
			Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeReport));
			this.rvTimeKeeper = new Microsoft.Reporting.WinForms.ReportViewer();
			this.TimeDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ProjectSummaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.TimeDetailBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjectSummaryBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// rvTimeKeeper
			// 
			this.rvTimeKeeper.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rvTimeKeeper.Dock = System.Windows.Forms.DockStyle.Fill;
			reportDataSource1.Name = "DataSet1";
			reportDataSource1.Value = this.ProjectSummaryBindingSource;
			this.rvTimeKeeper.LocalReport.DataSources.Add(reportDataSource1);
			this.rvTimeKeeper.LocalReport.ReportEmbeddedResource = "TimeKeeper.Reports.TimeSummary.rdlc";
			this.rvTimeKeeper.Location = new System.Drawing.Point(0, 0);
			this.rvTimeKeeper.Name = "rvTimeKeeper";
			this.rvTimeKeeper.ServerReport.BearerToken = null;
			this.rvTimeKeeper.ShowToolBar = false;
			this.rvTimeKeeper.Size = new System.Drawing.Size(710, 385);
			this.rvTimeKeeper.TabIndex = 0;
			// 
			// TimeDetailBindingSource
			// 
			this.TimeDetailBindingSource.DataMember = "TimeDetail";
			// 
			// ProjectSummaryBindingSource
			// 
			this.ProjectSummaryBindingSource.DataMember = "ProjectSummary";
			// 
			// TimeReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(710, 385);
			this.Controls.Add(this.rvTimeKeeper);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(300, 200);
			this.Name = "TimeReport";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Week To Date Detail";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TimeReport_FormClosing);
			this.Load += new System.EventHandler(this.TimeReport_Load);
			((System.ComponentModel.ISupportInitialize)(this.TimeDetailBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjectSummaryBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private Microsoft.Reporting.WinForms.ReportViewer rvTimeKeeper;
		private System.Windows.Forms.BindingSource TimeDetailBindingSource;
		private System.Windows.Forms.BindingSource ProjectSummaryBindingSource;
	}
}