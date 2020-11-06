
using System;
using System.Runtime.Serialization;

namespace Common
{
	public class Project : IComparable<Project>
	{
		public long ProjectID { get; set; } = 0;
		public string Name { get; set; } = string.Empty;
		public string Department { get; set; } = string.Empty;
		public DateTime BeginDate { get; set; } = DateTime.MinValue;
		public DateTime EndDate { get; set; } = DateTime.MinValue;

		public string Sort => $"{this.Department}_{this.Name}";

		#region IComparable<Project> Members
		public int CompareTo(Project other)
		{
			return this.Sort.CompareTo(other.Sort);
		}
		#endregion
	}
}
