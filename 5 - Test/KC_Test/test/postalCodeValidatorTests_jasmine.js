/*
 * If you do not include these references and get them exactly right your tests will fail!
 */
/// <reference path="../Scripts/jasmine/jasmine.js"/>
/// <reference path="../../../2 - Application/KC_Application/postalCodeValidator.js"/>

describe('Postal Code Validator Specifications', function () {

	// Execute this before each 'test' is executed
	beforeEach(function () {

		this.validator = new PostalCodeValidator();
	});

	it('expect 71104 to be a valid US zip code', function () {

		console.log('validating postal code 71104...');

		var isValid = this.validator.isValid('71104');

		expect(isValid).toBe(true);
	});
});