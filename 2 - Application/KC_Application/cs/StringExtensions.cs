namespace KC_Application.cs
{
	public static class StringExtensions
	{
		public static bool IsValidPostalCode(this string postalCode)
		{
			if (PostalCodeValidator.IsValidForUK(postalCode))
				return true;

			if (PostalCodeValidator.IsValidForUS(postalCode))
				return true;

			return false;
		}
	}
}