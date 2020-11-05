using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Utilities.Data;
using DAL.Utilities.Library.DataTypes;

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
			string projectName = this.txtProjectName.Text.Trim();
			string departmentName = this.cmboDepartment.Text.Trim();
			DateTime startDate = this.dtpStartDate.Value;
			DateTime endDate = this.dtpEndDate.Value;

			// Validate
			List<string> errors = new List<string>();
			if (Strings.IsEmpty(projectName))
			{
				errors.Add("Project Name is required");
			}
			if (Strings.IsEmpty(departmentName))
			{
				errors.Add("Department is required");
			}

			if (startDate > DateTime.Now.AddYears(1) || startDate < DateTime.Now.AddYears(-1) || startDate > endDate)
			{
				errors.Add("Start Date is out of range");
			}
			if (endDate > DateTime.Now.AddYears(2) || endDate < startDate)
			{
				errors.Add("End Date is out of range");
			}

			if (errors.Count > 0)
			{
				MessageBox.Show("The project could not be saved due to the following issues:\n\n" + Strings.Join("\n", errors), "Missing Values");
				return;
			}

			try
			{
				RemoteData.SaveProject(Constants.NullInt, projectName, departmentName, startDate, endDate);
			}
			catch (Exception ex)
			{
				MessageBox.Show("There was an error saving the new project. Report this please. Here are the details\n\n" + DAL.Utilities.Library.DataTypes.Strings.ExceptionToDetailText(ex), "TimeKeeper - New Project Error");
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
