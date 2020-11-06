using Common.Helpers.DataTypes;
using System;
using System.Windows.Forms;

namespace TimeKeeper
{
	public partial class TimeReport : Form
	{
		public TimeReport()
		{
			InitializeComponent();
		}

		private void TimeReport_Load(object sender, EventArgs e)
		{
			this.rvTimeKeeper.RefreshReport();
		}

		public DialogResult ShowTimeDetail(IWin32Window owner)
		{
			try
			{
				DateTime now = DateTime.Now;
				DateTime beginDate = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0).AddDays(-(int)now.DayOfWeek);
				DateTime endDate = beginDate.AddDays(40);


				this.Text = "40 Day Detail";

				this.TimeDetailBindingSource.DataSource = TimeKeeperData.GetTimeDetail(beginDate, endDate);

				var dataSource = new Microsoft.Reporting.WinForms.ReportDataSource
				{
					Name = "DataSet1",
					Value = this.TimeDetailBindingSource
				};
				this.rvTimeKeeper.LocalReport.DataSources.Clear();
				this.rvTimeKeeper.LocalReport.DataSources.Add(dataSource);
				this.rvTimeKeeper.LocalReport.ReportEmbeddedResource = "TimeKeeper.Reports.TimeDetail.rdlc";
				this.rvTimeKeeper.RefreshReport();

			}
			catch (Exception ex)
			{
				MessageBox.Show("The Report could not be loaded. Report this please. Here are the details\n\n" + ex.ToDetailText(), "TimeKeeper - Time Detail Report");
				return DialogResult.Abort;
			}

			this.StartPosition = FormStartPosition.CenterParent;
			return this.ShowDialog(owner);
		}

		public DialogResult ShowTimeSummary(IWin32Window owner)
		{
			try
			{
				DateTime now = DateTime.Now;
				DateTime beginDate = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0).AddDays(-(int)now.DayOfWeek);
				DateTime endDate = beginDate.AddDays(40);

				this.Text = "40 Day Summary";

				this.ProjectSummaryBindingSource.DataSource = TimeKeeperData.GetProjectSummary(beginDate, endDate);

				var dataSource = new Microsoft.Reporting.WinForms.ReportDataSource
				{
					Name = "DataSet1",
					Value = this.ProjectSummaryBindingSource
				};
				this.rvTimeKeeper.LocalReport.DataSources.Clear();
				this.rvTimeKeeper.LocalReport.DataSources.Add(dataSource);
				this.rvTimeKeeper.LocalReport.ReportEmbeddedResource = "TimeKeeper.Reports.TimeSummary.rdlc";
				this.rvTimeKeeper.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("The Report could not be loaded. Report this please. Here are the details\n\n" + ex.ToDetailText(), "TimeKeeper - Time Summary Report");
				return DialogResult.Abort;
			}

			this.StartPosition = FormStartPosition.CenterParent;
			return this.ShowDialog(owner);
		}

		private void TimeReport_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}
	}
}
