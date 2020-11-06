using System;

namespace Common
{
	public class TimeDetail
	{
		public TimeDetail() { }
		public long ProjectID { get; set; }
		public string ProjectName { get; set; }

		public string ProjectNameFormatted => $"{this.ProjectName} ({this.ProjectID})";
		public string UserName { get; set; }
		public DateTime EntryDate { get; set; }
		public string EntryDateFormatted => this.EntryDate.FormatReportDate();
		public long Minutes { get; set; }
		public string Description { get; set; }
	}
}
