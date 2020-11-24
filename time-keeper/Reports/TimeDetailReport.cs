using Common;
using Common.Helpers.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TimeKeeper
{
	public partial class TimeDetailReport : Form
	{
		public TimeDetailReport()
		{
			InitializeComponent();
		}

		public DialogResult ShowReport(IWin32Window owner)
		{
			DateTime now = DateTime.Now;
			DateTime endDate = DateTime.Now.Date;
			DateTime beginDate = endDate.AddDays(Math.Max(0, -(int)endDate.DayOfWeek)); // Move to Monday of this week

			this.dtpStartDate.Value = beginDate;
			this.dtpEndDate.Value = endDate;

			var projects = TimeKeeperData.GetProjects().Where(a => a.IsActive).ToArray();

			this.clbProjects.Visible = false;

			this.clbProjects.Items.Clear();
			this.clbProjects.Items.AddRange(new ListBox.ObjectCollection(this.clbProjects, projects));
			this.clbProjects.Items.Insert(0, new Project { ProjectID = 0, Name = "All Projects" });

			this.clbProjects.SetItemChecked(0, true);	// Check all the items (the event will fire and check all the other items)

			this.StartPosition = FormStartPosition.CenterParent;
			return this.ShowDialog(owner);
		}

		private void btnProjects_Click(object sender, EventArgs e)
		{
			this.clbProjects.Visible = true;
			this.clbProjects.Focus();
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
				var data = TimeKeeperData.GetTimeDetail(this.dtpStartDate.Value, this.dtpEndDate.Value.Date.AddDays(1)).Where(a => selectedProjects.Contains(a.ProjectID));

				this.SuspendLayout();
				this.lvReportData.Items.Clear();

				foreach (var row in data)
				{
					this.lvReportData.Items.Add(new ListViewItem(new string[] { row.EntryDateFormatted, row.ProjectNameFormatted, row.Department, row.Minutes.ToString(), row.Description }));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Report Error", "There was an error retrieving the report data:\n\n" + ex.Message);
				return;
			}
			finally
			{
				this.ResumeLayout();
			}
		}

		private void clbProjects_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			this.SuspendLayout();

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
			}

			this.ResumeLayout();
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

			switch (m.Msg)
			{
				case WM_LBUTTONDOWN:
					break;
				case WM_LBUTTONUP:
					if (!this.clbProjects.ClientRectangle.Contains(this.clbProjects.PointToClient(Cursor.Position)))
					{
						this.clbProjects.Visible = false;
					}
					break;
				case WM_LEFTDBLCLICK:
					break;
			}

			base.WndProc(ref m);
		}
		#endregion

	}
}
