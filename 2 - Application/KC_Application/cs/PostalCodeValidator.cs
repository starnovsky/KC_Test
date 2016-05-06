using System.Text.RegularExpressions;

namespace KC_Application.cs
{
	public class PostalCodeValidator
	{
		public static bool IsValidForUK(string postalCode)
		{
			return IsValid(postalCode, POSTAL_CODE_REGEX_UK);
		}

		public static bool IsValidForUS(string postalCode)
		{
			return IsValid(postalCode, POSTAL_CODE_REGEX_US);
		}

		private static bool IsValid(string postalCode, string pattern)
		{
			if (string.IsNullOrEmpty(postalCode))
				return false;

			return new Regex(pattern).Match(postalCode).Success;
		}

		private const string POSTAL_CODE_REGEX_UK = @"/^[A-Z]{1,2}[0-9]{1,2} ?[0-9][A-Z]{2}$/i";
		private const string POSTAL_CODE_REGEX_US = @"^\d{5}(?:[-\s]\d{4})?$";
	}
}