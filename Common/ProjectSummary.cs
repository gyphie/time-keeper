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
		public int ProjectID { get; set; }
		public string ProjectName { get; set; }
		public DateTime BeginDate { get; set; }
		public DateTime EndDate { get; set; }
		public int TotalMinutes { get; set; }


	}
}
