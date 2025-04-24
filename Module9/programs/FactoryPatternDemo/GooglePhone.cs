using System;

namespace FactoryPatternDemo;

public class GooglePhone : IMobilePhone
{
    public void Call(string number)
    {
        Console.WriteLine($"Calling {number} with an Google phone.");
    }

    public void Text(string number, string message)
    {
        Console.WriteLine($"Texting {number} : {message} with a Google phone.");
    }
}
