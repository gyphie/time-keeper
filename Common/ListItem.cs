using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
	public class ListItem : IComparable<ListItem>
	{
		public ListItem(string text, object value)
		{
			this.Text = text;
			this.Value = value;
		}

		public string Text { get; set; }
		public object Value { get; set; }

		#region IComparable<ListItem> Members

		public int CompareTo(ListItem other)
		{
			return this.Text.CompareTo(other.Text);
		}

		#endregion
	}
}
