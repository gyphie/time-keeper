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
