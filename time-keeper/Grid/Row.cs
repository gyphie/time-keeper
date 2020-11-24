using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Common;
using Common.Helpers.DataTypes;

namespace TimeKeeper.Grid
{
	public class Row
	{
		public GroupedComboBox ProjectBox { get; set; }
		public TextBox TimeBox { get; set; }
		public TextBox DescriptionBox { get; set; }
		private bool timeIsDirty = false;

		public Row(GroupedComboBox projectBox, TextBox timeBox, TextBox descriptionBox)
		{
			this.ProjectBox = projectBox;
			this.ProjectBox.DisplayMember = "DisplayName";
			this.ProjectBox.ValueMember = "ProjectID";
			this.ProjectBox.GroupMember = "Department";
			this.ProjectBox.AutoCompleteMode = AutoCompleteMode.Append;
			this.ProjectBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;

			this.TimeBox = timeBox;
			this.TimeBox.Tag = true;	// prevent TextChanged event
			this.TimeBox.Text = "";
			this.TimeBox.Enter += new EventHandler(TextBox_Enter);
			this.TimeBox.TextChanged += new EventHandler(TimeBox_TextChanged);

			this.DescriptionBox = descriptionBox;
			this.DescriptionBox.Enter += new EventHandler(TextBox_Enter);
		}
		
		void TextBox_Enter(object sender, EventArgs e)
		{
			TextBox me = sender as TextBox;
			if (me == null)
			{
				return;
			}

			me.Select(0, me.Text.Length);
		}

		void TimeBox_TextChanged(object sender, EventArgs e)
		{
			this.timeIsDirty = !string.IsNullOrEmpty(this.TimeBox.Text);
		}

		public void Refresh(List<Project> projects)
		{
			Project previousProject = this.ProjectBox.SelectedItem as Project;
			previousProject = previousProject == null ? null : projects.FirstOrDefault(p => p.ProjectID == previousProject.ProjectID);

			this.ProjectBox.Tag = true;	// Ignore change events
			this.ProjectBox.DataSource = projects;

			if (previousProject != null)
			{
				try
				{
					this.ProjectBox.Tag = true;	// Ignore change events
					this.ProjectBox.SelectedItem = previousProject;
				}
				catch { }
			}
			else
			{
				this.ProjectBox.Tag = true;	// Ignore change events
				this.ProjectBox.SelectedItem = null;
				this.ProjectBox.Text = "";
			}
		}

		public void SetTime(int minutes)
		{
			this.SetTime(minutes, this.timeIsDirty);
		}

		public void SetTime(int minutes, bool dirty)
		{
			this.TimeBox.Tag = true;	// prevent TextChanged event
			this.TimeBox.Text = Strings.ReformatTime(minutes);
			this.timeIsDirty = dirty;
		}

		public bool TimeIsDirty
		{
			get { return this.timeIsDirty; }
		}

		/// <summary>
		/// Return the parsed time from the TimeBox in minutes
		/// </summary>
		/// <returns></returns>
		public int GetTime()
		{
			return Row.GetTime(this.TimeBox.Text);
		}
		
		public static int GetTime(string timeString)
		{
			Match m = null;
			timeString = timeString.Trim();
			// h:mm (\d\d?):(\d\d?)?
			// # m (\d+) ?m?
			// # h (\d+) ?h
			// #h #m (\d+) ?h? ?(\d+) ?m?
			m = Regex.Match(timeString, @"^(\d\d?):(\d\d?)?$");
			if (m.Success)
			{
				return Integers.Parse(m.Groups[1].Value, 0) * 60 + Integers.Parse(m.Groups[2].Value, 0);
			}

			m = Regex.Match(timeString, @"^(\d+) ?m?$", RegexOptions.IgnoreCase);
			if (m.Success)
			{
				return Integers.Parse(m.Groups[1].Value, 0);
			}

			m = Regex.Match(timeString, @"^(\d+) ?h$", RegexOptions.IgnoreCase);
			if (m.Success)
			{
				return Integers.Parse(m.Groups[1].Value, 0) * 60;
			}

			m = Regex.Match(timeString, @"^(\d+) ?h? ?(\d+) ?m?$", RegexOptions.IgnoreCase);
			if (m.Success)
			{
				return Integers.Parse(m.Groups[1].Value, 0) * 60 + Integers.Parse(m.Groups[2].Value, 0);
			}
	
			return 0;
		}

	}
}
