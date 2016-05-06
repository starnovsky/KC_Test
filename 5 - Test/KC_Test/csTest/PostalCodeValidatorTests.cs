using FluentAssertions;
using KC_Application.cs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Xunit;

namespace KC_Test.csTest
{
	// MS Test
	[TestClass]
	public class PostalCodeValidatorTests_MSTest
	{
		[TestMethod]
		public void ExpectPostalCodeValidatorToReturnTrue_WhenGiven12345()
		{
			"12345".IsValidPostalCode().Should().BeTrue();
		}
	}

	// NUnit
	[TestFixture]
	public class PostalCodeValidatorTests_NUnit
	{
		[Test]
		public void ExpectPostalCodeValidatorToReturnTrue_WhenGiven12345()
		{
			"12345".IsValidPostalCode().Should().BeTrue();
		}

		[NUnit.Framework.Theory] // Theories use the [Datapoint] members as tet parameters
		public void ExpectPostalCodeValidatorToReturnTrue_WhenDataPointsAreValid(string value)
		{
			value.IsValidPostalCode().Should().BeTrue();
		}

		[Datapoint] public string PostalCode_12345 = "12345";

		[TestCase("12345", ExpectedResult = true)]
		[TestCase("55555", ExpectedResult = true)]
		[TestCase("78534", ExpectedResult = true)]
		[TestCase(null, ExpectedResult = false)]
		[TestCase("", ExpectedResult = false)]
		[TestCase("123", ExpectedResult = false)]
		public bool ExpectPostalCodeValidatorToReturnTrue_WhenGivenValidData(string value)
		{
			return value.IsValidPostalCode();
		}
	}

	// XUnit
	public class PostalCodeValidatorTests_XUnit
	{
		// Facts are tests which are always true. They test invariant conditions.
		[Fact] 
		public void ExpectPostalCodeValidatorToReturnTrue_WhenGiven12345()
		{
			"12345".IsValidPostalCode().Should().BeTrue();
		}

		// Theories are tests which are only true for a particular set of data.
		[Xunit.Theory] // NUnit now also supports Thories (they stole it)
		[InlineData("12345")]
		[InlineData("55555")]
		[InlineData("78534")]
		public void ExpectPostalCodeValidatorToReturnTrue_WhenGivenValidData(string postalCode)
		{
			postalCode.IsValidPostalCode().Should().BeTrue();
		}
	}
}