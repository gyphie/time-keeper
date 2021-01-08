using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeKeeper.Reports
{
	public class ListViewColumnSorter : IComparer
	{
		public ListViewColumnSorter(int startSortColumn)
		{
			this.ColumnIndex = startSortColumn;
		}

		public int ColumnIndex { get; set; } = 0;
		public SortOrder SortOrder { get; set; } = SortOrder.Ascending;

		public int Compare(object x, object y)
		{
			var item1 = x as ListViewItem;
			var item2 = y as ListViewItem;

			var compareResult = (item1.SubItems[this.ColumnIndex].Tag as string ?? item1.SubItems[this.ColumnIndex].Text)
				.CompareTo((item2.SubItems[this.ColumnIndex].Tag as string ?? item2.SubItems[this.ColumnIndex].Text));

			if (this.SortOrder == SortOrder.Ascending)
			{
				return compareResult;
			}
			else if (this.SortOrder == SortOrder.Descending)
			{
				return -compareResult;
			}
			else
			{
				return 0;
			}

		}
	}
}
