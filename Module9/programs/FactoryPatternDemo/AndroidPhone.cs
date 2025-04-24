using System;

namespace FactoryPatternDemo;

public class AndroidPhone : IMobilePhone
{
    public void Call(string number)
    {
        Console.WriteLine($"Calling {number} with an Android phone.");
    }

    public void Text(string number, string message)
    {
        Console.WriteLine($"Texting {number} : {message} with an Android phone.");
    }
}
