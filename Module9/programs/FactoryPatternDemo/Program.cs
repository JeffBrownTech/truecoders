
using FactoryPatternDemo;

Console.WriteLine("What kind of phone do you have? ('iPhone/Apple', 'Android', 'Google')");
var phoneType = Console.ReadLine();

var phone = PhoneFactory.BuildPhone(phoneType);

phone.Call("155512345678");
phone.Text("15559876543", "Hello, World!");
