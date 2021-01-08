using Common;
using Common.Helpers.DataTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TimeKeeper
{
	public partial class ManageProjects : Form
	{
		private bool hasModifiedProject = false;

		public ManageProjects()
		{
			InitializeComponent();
		}

		public DialogResult LoadAndShowDialog(IWin32Window owner)
		{
			this.hasModifiedProject = false;
			this.cbShowInactive.Checked = false;

			this.LoadListBox(this.cbShowInactive.Checked);

			this.btnAddProject.Focus();

			return this.ShowDialog(owner);
		}

		private void LoadListBox(bool showInactive, long selectedProjectID = 0)
		{
			var projects = showInactive ? TimeKeeperData.GetAllProjects() : TimeKeeperData.GetActiveProjects();
			projects.Sort();

			var previousSelectedIndex = this.lvProjects.SelectedIndices.Count > 0 ? this.lvProjects.SelectedIndices[0] : 0;
			
			this.lvProjects.Items.Clear();

			this.lvProjects.Items.AddRange(projects.Select(a => new ListViewItem(new string[] { a.Name, a.Department, a.IsActive ? "X" : "" }) { Tag = a }).ToArray());

			this.lvProjects.SelectedIndices.Clear();

			if (this.lvProjects.Items.Count > previousSelectedIndex)
			{
				this.lvProjects.Items[previousSelectedIndex].Selected = true;
			}
			else if (this.lvProjects.Items.Count > 0)
			{
				this.lvProjects.Items[0].Selected = true;
			}
		}

		private void OpenNewProjectWindow(Project project = null)
		{
			var frmNewProject = new AddEditProject();

			var diagResult = frmNewProject.LoadAndShowDialog(this, project);

			if (diagResult == DialogResult.OK)
			{
				this.hasModifiedProject = true;
				long projectID = (frmNewProject.Tag as Project)?.ProjectID ?? 0L;
				this.LoadListBox(this.cbShowInactive.Checked, projectID);
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnAddProject_Click(object sender, EventArgs e)
		{
			this.OpenNewProjectWindow();
		}

		private void lvProjects_DoubleClick(object sender, EventArgs e)
		{
			var project = this.lvProjects.SelectedItems[0].Tag as Project;
			if (project == null) return;

			this.OpenNewProjectWindow(project);
		}


		private void ManageProjects_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.DialogResult = this.hasModifiedProject ? DialogResult.OK : DialogResult.Cancel;
		}

		private void cbShowInactive_CheckedChanged(object sender, EventArgs e)
		{
			long projectID = 0;
			if (this.lvProjects.SelectedItems.Count > 0) {
				projectID = (this.lvProjects.SelectedItems[0].Tag as Project)?.ProjectID ?? 0;
			}
			this.LoadListBox(this.cbShowInactive.Checked, projectID);
		}

	}
}
