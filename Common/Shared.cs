using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
	public static class Shared
	{
		public static readonly string REPORT_DATE_FORMAT_STRING = "MMM d h:mm";

		public static string FormatReportDate(this DateTime dt)
		{
			return dt.ToString(REPORT_DATE_FORMAT_STRING) + (dt.Hour <= 12 ? "a" : "p");
		}
	}
}
