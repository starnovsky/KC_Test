# Kool Code Demo
## Testing Frameworks and Runners

### Step 1

### Visual Studio and Environment Preparation
+ Open Visual Studio 2015 as an Administrator
> Install Chutzpah Test Runner and Adapter extensions  
> Install Wallaby Test Runner extension  
> Install Phantom JS  
> Install NCrunch  

+ Create Empty Visual Studio Solution 
+ Create (Perficient-preferred) Visual Studio Solution folders
+ Create empty ASP.NET Web Application named KC_Test  
+ Create empty class library named KC_Application  

### Step 2

+ Install QUnit-MVC NuGet Package into KC_Test  
> In the Package Manager Console type:  
>> `Install-Package QUnit-MVC`  

+ Add postalCodeValidatorTests_qunit.js  
+ Add postalCodeValidator.js in KC_Application  
+ Link to postalCodeValidator.js from KC_Test  
+ Add postalCodeValidatorTests_qunit.js  

### Step 3

+ Install Jasmine NuGet Package into KC_Test  
> In the Package Manager Console type:  
>> `Install-Package jasmine`  

+ Add postalCodeValidatorTests_jasmine.js  

### Step 4
+ Add wallaby-*.json files to KC_Test  

>NOTE:  Wallaby does not work correctly with 'linked' files so you have to physically copy the postalCodeValidator.js file into the test project... which is unfortunate!

+ Start Wallaby
+ Demo Wallaby code coverage  
+ Demo Chutzpah code coverage  

### Step 5
+ Install MS Test NuGet Extensions
> In the Package Manager Console type:  
> `Install-Package Microsoft.UnitTestFramework.Extensions`  

+ Install NUnit
> In the Package Manager Console type:  
>> `Install-Package NUnit`  

+ Install XUnit
> In the Package Manager Console type:  
>> `Install-Package XUnit`  

+ Install Fluent Assertions
> In the Package Manager Console type:  
>> `Install-Package FluentAssertions`  

+ Add `PostalCodeValidator` to KC_Application/cs  
+ Add `StringExtensions` to KC_Application/cs  
+ Add `PostalCodeValidatorTests` to KC_Test/csTest  
+ Demo Test with Visual Studio test runner
+ Demo Test with ReSharper
+ Demo Test with Chutzpah
+ Demo Test NCrunch

### Links

- [Chutzpah Test Runner Context Menu Extension](https://visualstudiogallery.msdn.microsoft.com/71a4e9bd-f660-448f-bd92-f5a65d39b7f0)
- [Chutzpah Test Adapter for the Test Explorer](https://visualstudiogallery.msdn.microsoft.com/f8741f04-bae4-4900-81c7-7c9bfb9ed1fe)
- [NCrunch - Continuous Test Runner for .net](http://www.ncrunch.net/)
- [Wallaby JS - Continuous Test Runner](https://wallabyjs.com)  
- [Chutzpah JS - Console-based JavaScript Test Runner](http://mmanela.github.io/chutzpah/)  
- [Phantom JS - 'Headless' WebKit](http://phantomjs.org/)  
- [Jasmine JS - A BDD-style Unit Testing Framework](http://jasmine.github.io/)
- [QUnit JS - JavaScript Unit Testing Framework](http://qunitjs.com/)
- [NUnit](http://www.nunit.org/)  
- [XUnit](https://xunit.github.io/)  
- [Fluent Assertions](http://www.fluentassertions.com/)  
- [NCrunch - Continuous Test Runner for .net](http://www.ncrunch.net/)
