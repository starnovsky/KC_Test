/// <reference path="../../KC_Test/src/postalCodeValidator.js"/>

QUnit.test('expect 12345 to be a valid US postal code', function (assert) {

	this.validator = new PostalCodeValidator();

	var isValid = this.validator.isValid('12345');

	assert.ok(isValid === true, 'expected 12345 to be a valid US postal code');
});

//QUnit.test('expect undefined to be an invalid postal code', function (assert) {

//	this.validator = new PostalCodeValidator();

//	var isValid = this.validator.isValid(undefined);

//	assert.ok(isValid === false, 'expected undefined to be an invalid postal code');
//});

//QUnit.test('expect 123 to be an invalid postal code', function (assert) {

//	this.validator = new PostalCodeValidator();

//	var isValid = this.validator.isValid('123');

//	assert.ok(isValid === false, 'Expected 123 to be an invalid postal code');
//});

//QUnit.test('expect AA11 1AA to be a valid postal code', function (assert) {

//	this.validator = new PostalCodeValidator();

//	var isValid = this.validator.isValid('AA11 1AA');

//	assert.ok(isValid === true, 'Expected AA11 1AA to be a valid postal code');
//});
