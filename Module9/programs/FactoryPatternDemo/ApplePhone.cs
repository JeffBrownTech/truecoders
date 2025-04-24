using System;

namespace FactoryPatternDemo;

public class ApplePhone : IMobilePhone
{
    public void Call(string number)
    {
        Console.WriteLine($"Calling {number} with an Apple phone.");
    }

    public void Text(string number, string message)
    {
        Console.WriteLine($"Texting {number} : {message} with an Apple phone.");
    }
}
