
using System;
using System.Runtime.Serialization;

namespace Common
{
	public class Project : IComparable<Project>
	{
		public int ProjectID { get; set; } = int.MinValue;
		public string Name { get; set; } = string.Empty;
		public string Department { get; set; } = string.Empty;
		public DateTime StartDate { get; set; } = DateTime.MinValue;
		public DateTime EndDate { get; set; } = DateTime.MinValue;

		public string Sort
		{
			get
			{
				return Department + "_" + Name;
			}
		}

		#region IComparable<Project> Members

		public int CompareTo(Project other)
		{
			return this.Sort.CompareTo(other.Sort);
		}

		#endregion
	}
}
