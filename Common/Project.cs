
using Common.Helpers.DataTypes;
using System;
using System.Runtime.Serialization;

namespace Common
{
	public class Project : IComparable<Project>
	{
		public long ProjectID { get; set; } = 0;
		public string Name { get; set; } = string.Empty;
		public string Department { get; set; } = string.Empty;
		public DateTime DateCreated { get; set; } = DateTime.MinValue;

		public bool IsActive { get; set; } = true;
		public string Sort => $"{this.Department}_{this.Name}";

		public string DisplayName
		{
			get
			{
				return this.Name + (this.Department.IsEmpty() ? "" : $" ({this.Department})");
			}
		}

		#region IComparable<Project> Members
		public int CompareTo(Project other)
		{
			return this.Sort.CompareTo(other.Sort);
		}
		#endregion

		public override string ToString()
		{
			return this.DisplayName;
		}
	}
}
