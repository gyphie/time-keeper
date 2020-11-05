using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
		}

		public DialogResult ShowTimeDetail(string userID, IWin32Window owner)
		{
			try
			{
				DateTime now = DateTime.Now;
				DateTime beginDate = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0).AddDays(-(int)now.DayOfWeek);
				DateTime endDate = beginDate.AddDays(7);


				this.Text = "Week to Date Detail";

				this.timeDetailGrid.Visible = true;
				this.projectSummaryGrid.Visible = false;

				this.TimeDetailBindingSource.DataSource = TimeKeeper.RemoteData.GetTimeDetail(userID, beginDate, endDate);
			}
			catch (Exception ex)
			{
				MessageBox.Show("The Report could not be loaded. Report this please. Here are the details\n\n" + DAL.Utilities.Library.DataTypes.Strings.ExceptionToDetailText(ex), "TimeKeeper - Time Detail Report");
				return DialogResult.Abort;
			}

			this.StartPosition = FormStartPosition.CenterParent;
			return this.ShowDialog(owner);
		}

		public DialogResult ShowTimeSummary(string userID, IWin32Window owner)
		{
			try
			{
				DateTime now = DateTime.Now;
				DateTime beginDate = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0).AddDays(-(int)now.DayOfWeek);
				DateTime endDate = beginDate.AddDays(7);

				this.Text = "Week to Date Summary";
				this.timeDetailGrid.Visible = false;
				this.projectSummaryGrid.Visible = true;

				this.ProjectSummaryBindingSource.DataSource = TimeKeeper.RemoteData.GetProjectSummary(userID, beginDate, endDate);
			}
			catch (Exception ex)
			{
				MessageBox.Show("The Report could not be loaded. Report this please. Here are the details\n\n" + DAL.Utilities.Library.DataTypes.Strings.ExceptionToDetailText(ex), "TimeKeeper - Time Summary Report");
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
