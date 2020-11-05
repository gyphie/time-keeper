using System;

namespace Common
{
	public class TimeDetail
	{
		public TimeDetail() { }
		public int ProjectID { get; set; }

		private string projectName = "";
		public string ProjectName
		{
			get
			{
				return string.Format("{0} ({1})", this.projectName, this.ProjectID);
			}
			set
			{
				this.projectName = value;
			}
		}
		public DateTime EnteredDate { get; set; }
		public int Minutes { get; set; }
		public string Comments { get; set; }
	}
}
