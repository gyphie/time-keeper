using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Helpers.DataTypes
{
	public static class Integers
	{
		public static int Parse(string value, int defaultValue)
		{
			if (!int.TryParse(value, out int result))
			{
				result = defaultValue;
			}

			return result;
		}
	}

	public static class Longs
	{
		/// <summary>
		/// Formts long to a string with leading zeros up to 6 characters long
		/// </summary>
		public static string FormatSortable(this long value)
		{
			return value.ToString("000000");
		}
	}

	public static class DateTimes
	{
		/// Credit: https://stackoverflow.com/a/1646396/5583585
		public static long GetWorkingDayCount(DateTime startDate, DateTime endDate)
		{
			double calcBusinessDays =
				1 + ((endDate - startDate).TotalDays * 5 -
				(startDate.DayOfWeek - endDate.DayOfWeek) * 2) / 7;

			if (endDate.DayOfWeek == DayOfWeek.Saturday) calcBusinessDays--;
			if (startDate.DayOfWeek == DayOfWeek.Sunday) calcBusinessDays--;

			return (long)calcBusinessDays;
		}

		public static readonly string REPORT_DATE_FORMAT_STRING = "MMM d";
		public static readonly string REPORT_DATETIME_FORMAT_STRING = "MMM d h:mm";
		public static readonly string SORTABLE_DATE_FORMAT_STRING = "yyyyMMddHHmmssffff";

		public static string FormatReportDate(this DateTime dt)
		{
			return dt.ToString(REPORT_DATE_FORMAT_STRING);
		}
		public static string FormatReportDateTime(this DateTime dt)
		{
			return dt.ToString(REPORT_DATETIME_FORMAT_STRING) + (dt.Hour <= 12 ? "a" : "p");
		}

		public static string FormatSortableDateTime(this DateTime dt)
		{
			return dt.ToString(SORTABLE_DATE_FORMAT_STRING);
		}

	}


	public static class Strings
	{
		public static string ReformatTime(int minutes)
		{
			string format = minutes > 0 ? "{0}:{1:00}" : "";
			return String.Format(format, minutes / 60, minutes % 60);
		}
		public static string ReformatLongTime(long minutes)
		{
			var isNeg = minutes < 0;
			minutes = Math.Abs(minutes);
			string format = (isNeg ? "-" : "") + (minutes % 60 == 0 && minutes > 0 ? "{0} h" : (minutes > 60 ? "{0} h {1} m" : "{1} m"));
			return String.Format(format, minutes / 60, minutes % 60);
		}


		public static bool IsEmpty(this string value, bool orWhiteSpace = true)
		{
			return orWhiteSpace ? string.IsNullOrWhiteSpace(value) : string.IsNullOrEmpty(value);
		}
	}

	public static class ExceptionExtension
	{
		public static string ToDetailText(this Exception value)
		{
			var exceptionText = new StringBuilder();

			int depth = 0;
			while (value != null && value != value.InnerException && depth < 10)
			{
				exceptionText.Append(value.GetType().Name);
				exceptionText.Append(": ");
				exceptionText.AppendLine(value.Message);
				exceptionText.AppendLine();

				value = value.InnerException;
				depth++;
			}

			return exceptionText.ToString();
		}
	}

}
