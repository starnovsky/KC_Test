/// <reference path="../../../2 - Application/KC_Application/postalCodeValidator.js"/>

QUnit.test('expect 12345 to be a valid US postal code', function (assert) {

	this.validator = new PostalCodeValidator();

	var isValid = this.validator.isValid('12345');

	assert.ok(isValid === true, 'expected 12345 to be a valid US postal code');
});
