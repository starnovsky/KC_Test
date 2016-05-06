
function PostalCodeValidator() {

	function isValidForUK(postalCode) {

		// The UK structure of a postal code is a one or two-letter postcode area code
		// named for a local town or area of London, one or two digits signifying a district
		// in that region, a space, and then an arbitrary code of one number and two letters

		postalCode = postalCode.replace(/\s/g, '');

		return /^[A-Z]{1,2}[0-9]{1,2} ?[0-9][A-Z]{2}$/i.test(postalCode);
	}

	function isValidForUS(postalCode) {

		// Simple validation:  5 numbers.

		return /(^\d{5}$)|(^\d{5}-\d{4}$)/.test(postalCode);
	}

	PostalCodeValidator.prototype.isValid = function (postalCode) {

		if (!postalCode)
			return false;

		if (isValidForUS(postalCode))
			return true;

		if (isValidForUK(postalCode))
			return true;

		return false;
	}

	return {

		isValid: this.isValid
	};
}