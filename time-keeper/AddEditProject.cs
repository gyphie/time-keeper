using Common;
using Common.Helpers.DataTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TimeKeeper
{
	public partial class AddEditProject : Form
	{
		public AddEditProject()
		{
			InitializeComponent();
		}

		public DialogResult LoadAndShowDialog(IWin32Window owner, Project editProject = null)
		{
			// Get the department list and update the combo box
			List<string> departments = TimeKeeperData.GetProjects().Select(a => a.Department).Distinct().ToList();
			departments.Sort((a, b) => a.CompareTo(b));
			departments.Insert(0, "");

			this.cmboDepartment.DataSource = departments;

			if (editProject != null)
			{
				this.Text = "Edit Project";

				this.txtProjectName.Text = editProject.Name;
				this.cmboDepartment.Text = editProject.Department;
				this.cbIsActive.Checked = editProject.IsActive;
				this.Tag = editProject;
			}
			else
			{
				this.Text = "Add Project";

				// Reset the form fields
				this.txtProjectName.Text = string.Empty;
				this.cmboDepartment.Text = string.Empty;

				this.cbIsActive.Checked = true;

				this.Tag = null;
			}

			this.txtProjectName.Focus();

			return this.ShowDialog(owner);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			long projectID = (this.Tag as Project)?.ProjectID ?? 0L;

			var projectName = this.txtProjectName.Text.Trim();
			var departmentName = this.cmboDepartment.Text.Trim();
			var isActive = this.cbIsActive.Checked;
			var dateCreated = DateTime.Now;

			// Validate
			var errors = new List<string>();
			if (projectName.IsEmpty())
			{
				errors.Add("Project Name is required");
			}
			if (departmentName.IsEmpty())
			{
				errors.Add("Department is required");
			}
			if (projectID == 0 && !isActive)
			{
				errors.Add("New projects cannot be inactive");
			}


			if (errors.Count > 0)
			{
				MessageBox.Show("The project could not be saved due to the following issues:\n\n" + string.Join("\n", errors), "Missing Values");
				return;
			}

			try
			{
				
				TimeKeeperData.SaveProject(projectID, projectName, departmentName, dateCreated, isActive);
			}
			catch (Exception ex)
			{
				MessageBox.Show("There was an error saving the project. Report this please. Here are the details\n\n" + ex.ToDetailText(), "TimeKeeper - Save Project Error");
				return;
			}

			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}
