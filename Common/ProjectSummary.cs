using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Common
{
	public class ProjectSummary
	{
		public ProjectSummary() { }
		public long ProjectID { get; set; }
		public string ProjectName { get; set; }
		public string ProjectNameFormatted => $"{this.ProjectName} ({this.ProjectID})";
		public DateTime BeginDate { get; set; }
		public string BeginDateFormatted => this.BeginDate.FormatReportDate();
		public DateTime EndDate { get; set; }
		public string EndDateFormatted => this.EndDate.FormatReportDate();
		public long TotalMinutes { get; set; }


	}
}
