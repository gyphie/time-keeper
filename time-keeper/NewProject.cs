using Common.Helpers.DataTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TimeKeeper
{
	public partial class NewProject : Form
	{
		public NewProject()
		{
			InitializeComponent();
		}

		public DialogResult LoadAndShowDialog(IWin32Window owner)
		{
			// Reset the form fields
			this.txtProjectName.Text = string.Empty;
			this.dtpStartDate.Value = DateTime.Now.Date;
			// Note: End Date auto updated when start date value changes

			// Get the department list and update the combo box
			List<string> departments = TimeKeeperData.GetProjects().Select(a => a.Department).Distinct().ToList();
			departments.Sort((a, b) => a.CompareTo(b));
			departments.Insert(0, "");

			this.cmboDepartment.DataSource = departments;

			this.cmboDepartment.Text = string.Empty;

			this.txtProjectName.Focus();

			return this.ShowDialog(owner);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			var projectName = this.txtProjectName.Text.Trim();
			var departmentName = this.cmboDepartment.Text.Trim();
			var beginDate = this.dtpStartDate.Value;
			var endDate = this.dtpEndDate.Value;

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

			if (beginDate > DateTime.Now.AddYears(1) || beginDate < DateTime.Now.AddYears(-1) || beginDate > endDate)
			{
				errors.Add("Start Date is out of range");
			}
			if (endDate > DateTime.Now.AddYears(2) || endDate < beginDate)
			{
				errors.Add("End Date is out of range");
			}

			if (errors.Count > 0)
			{
				MessageBox.Show("The project could not be saved due to the following issues:\n\n" + string.Join("\n", errors), "Missing Values");
				return;
			}

			try
			{
				TimeKeeperData.SaveProject(0, projectName, departmentName, beginDate, endDate);
			}
			catch (Exception ex)
			{
				MessageBox.Show("There was an error saving the new project. Report this please. Here are the details\n\n" + ex.ToDetailText(), "TimeKeeper - New Project Error");
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

		private void dtpStartDate_ValueChanged(object sender, EventArgs e)
		{
			this.dtpEndDate.MinDate = this.dtpStartDate.Value;
			this.dtpEndDate.Value = this.dtpStartDate.Value.AddMonths(1);
		}
	}
}
