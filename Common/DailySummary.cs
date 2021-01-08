using Common.Helpers.DataTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Common
{
	public class DailySummary
	{
		public DailySummary() { }

		public DateTime Date { get; set; }
		public string DateFormatted => this.Date.FormatReportDate();
		public string DateSortable => this.Date.FormatSortableDateTime();
		public long ProjectID { get; set; }
		public string ProjectName { get; set; }
		public string ProjectNameFormatted => $"{this.ProjectName} ({this.ProjectID})";
		public string Department { get; set; }
		public long TotalMinutes { get; set; }
		public string TotalMinutesSortable => this.TotalMinutes.FormatSortable();


	}
}
