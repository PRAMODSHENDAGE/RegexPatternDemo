// See https://aka.ms/new-console-template for more information
using RegexPatternDemo;
Patterns patterns = new Patterns();
Console.WriteLine(patterns.validatePinCode("410218"));

Patterns patterns1 = new Patterns();
Console.WriteLine(patterns1.validatePhoneNumber("+91-9898989898"));

Patterns patterns2 = new Patterns();
Console.WriteLine(patterns2.validateEmail("adh212au.parag64@gmail.co.in"));

Patterns patterns3 = new Patterns();
Console.WriteLine(patterns3.validatePassword("Pqr@2123"));
