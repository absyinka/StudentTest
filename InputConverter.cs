using System;

namespace Umar
{
	public static class InputConverter
	{
		public static double ConvertInputToNumeric(string argInput)
		{
			if (!double.TryParse(argInput, out double convertedNumber))
				throw new ArgumentException("Expected a numeric value");

			return convertedNumber;
		}
	}
}
