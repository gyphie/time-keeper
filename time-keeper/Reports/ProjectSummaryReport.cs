using Common;
using Common.Helpers.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TimeKeeper
{
	public partial class ProjectSummaryReport : Form
	{
		public ProjectSummaryReport()
		{
			InitializeComponent();
			this.clbProjects.Tag = this.btnProjects;
		}

		public DialogResult ShowReport(IWin32Window owner)
		{
			DateTime now = DateTime.Now;
			DateTime endDate = DateTime.Now.Date;
			DateTime beginDate = endDate.AddDays(Math.Min(0, -(int)endDate.DayOfWeek + 1)); // Move to Monday of this week

			this.dtpStartDate.Value = beginDate;
			this.dtpEndDate.Value = endDate;

			var projects = TimeKeeperData.GetActiveProjects().ToArray();

			this.clbProjects.Visible = false;

			this.clbProjects.Items.Clear();
			this.clbProjects.Items.AddRange(new ListBox.ObjectCollection(this.clbProjects, projects));
			this.clbProjects.Items.Insert(0, new Project { ProjectID = 0, Name = "All Projects" });

			this.clbProjects.SetItemChecked(0, true);   // Check all the items (the event will fire and check all the other items)

			this.StartPosition = FormStartPosition.CenterParent;
			return this.ShowDialog(owner);
		}

		private void btnProjects_Click(object sender, EventArgs e)
		{
			if (!clbProjects.Visible)
			{
				this.clbProjects.BringToFront();
				this.clbProjects.Visible = true;
				this.clbProjects.Focus();
			}
			else
			{
				this.clbProjects.Visible = false;
			}
		}

		private void btnUpdateReport_Click(object sender, EventArgs e)
		{
			var selectedProjects = new HashSet<long>();
			foreach (Project project in this.clbProjects.CheckedItems)
			{
				if (project.ProjectID != 0)
				{
					selectedProjects.Add(project.ProjectID);
				}
			}

			try
			{
				var data = TimeKeeperData.GetProjectSummary(this.dtpStartDate.Value, this.dtpEndDate.Value.Date.AddDays(1)).Where(a => selectedProjects.Contains(a.ProjectID));

				this.SuspendLayout();
				this.lvReportData.BeginUpdate();
				this.lvReportData.Items.Clear();

				long totalTime = 0;

				foreach (var row in data)
				{
					totalTime += row.TotalMinutes;
					this.lvReportData.Items.Add(new ListViewItem(new string[] { row.ProjectNameFormatted, row.Department, Strings.ReformatLongTime(row.TotalMinutes) }));
				}

				this.lblTotalTime.Text = Strings.ReformatLongTime(totalTime);
				this.lblTimeInReportPeriod.Text = Strings.ReformatLongTime(DateTimes.GetWorkingDayCount(this.dtpStartDate.Value.Date, this.dtpEndDate.Value.Date) * 8 * 60);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Report Error", "There was an error retrieving the report data:\n\n" + ex.Message);
				return;
			}
			finally
			{
				this.lvReportData.EndUpdate();
				this.ResumeLayout();
			}
		}

		private void clbProjects_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			this.SuspendLayout();
			this.clbProjects.BeginUpdate();

			this.clbProjects.ItemCheck -= clbProjects_ItemCheck;

			try
			{
				// If the "All" item gets checked then check everything else
				if (e.Index == 0 && e.NewValue == CheckState.Checked)
				{
					for (int i = 1; i < this.clbProjects.Items.Count; i++)
					{
						this.clbProjects.SetItemChecked(i, true);
					}
				}
				// If all items are checked and the "All" item gets unchecked then uncheck everything else
				else if (e.Index == 0 && e.NewValue == CheckState.Unchecked &&
					this.clbProjects.Items.Count == this.clbProjects.CheckedItems.Count)
				{
					for (int i = 1; i < this.clbProjects.Items.Count; i++)
					{
						this.clbProjects.SetItemChecked(i, false);
					}
				}
				// If any item gets unchecked then uncheck the "All" item
				else if (e.Index > 0 && e.NewValue == CheckState.Unchecked)
				{
					this.clbProjects.SetItemChecked(0, false);
				}
				// If checking this item causes all items to be checked then check the "All" item
				else if (e.Index > 0 && e.NewValue == CheckState.Checked &&
					this.clbProjects.Items.Count == this.clbProjects.CheckedItems.Count + 2)
				{
					this.clbProjects.SetItemChecked(0, true);
				}
			}
			finally
			{
				this.clbProjects.ItemCheck += clbProjects_ItemCheck;

				this.clbProjects.EndUpdate();
				this.ResumeLayout();
			}
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData == Keys.Escape)
			{
				this.Close();
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}

		#region CheckBoxList Focus logic
		// Technique from https://stackoverflow.com/a/17610347/5583585
		protected override void WndProc(ref Message m)
		{
			const int WM_LBUTTONDOWN = 0x201;
			const int WM_LBUTTONUP = 0x202;
			const int WM_LEFTDBLCLICK = 0x203;
			const int WM_PARENTNOTIFY = 0x210;

			var handleClick = false;

			switch (m.Msg)
			{
				case WM_LBUTTONDOWN:
					break;
				case WM_LBUTTONUP:
					handleClick = true;
					break;
				case WM_PARENTNOTIFY:
					if ((int)m.WParam == WM_LBUTTONDOWN)
					{
						handleClick = true;
					}

					break;
				case WM_LEFTDBLCLICK:
					handleClick = true;
					break;
			}

			if (handleClick)
			{
				var activationControl = this.clbProjects.Tag as Control;

				// Fix up to include the scrollbar in the ClientRectangle
				var fixedClientRectangle = new System.Drawing.Rectangle(this.clbProjects.ClientRectangle.X, this.clbProjects.ClientRectangle.Y, this.clbProjects.Bounds.Width, this.clbProjects.Bounds.Height);
				if (!fixedClientRectangle.Contains(this.clbProjects.PointToClient(Cursor.Position)))
				{

					// If the activating control was clicked then we let it handle showing/hiding the child control
					if (activationControl == null || !activationControl.ClientRectangle.Contains(activationControl.PointToClient(Cursor.Position)))
					{
						this.clbProjects.Visible = false;
					}
				}
			}

			base.WndProc(ref m);
		}
		#endregion

		private void dtpStartDate_ValueChanged(object sender, EventArgs e)
		{
			if (this.dtpStartDate.Value > this.dtpEndDate.Value)
			{
				this.dtpEndDate.Value = this.dtpStartDate.Value;
			}

		}

		private void dtpEndDate_ValueChanged(object sender, EventArgs e)
		{
			if (this.dtpStartDate.Value > this.dtpEndDate.Value)
			{
				this.dtpStartDate.Value = this.dtpEndDate.Value;
			}
		}
	}
}
