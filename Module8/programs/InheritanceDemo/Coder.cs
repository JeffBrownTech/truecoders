using System;
using System.Dynamic;

namespace InheritanceDemo;

// Coder class inherits all the same properties, fields, and methods of the Person class
public class Coder : Person
{
    public string ProgrammingLanguage { get; set; }

    public void Code()
    {
        Console.WriteLine($"I can code in {ProgrammingLanguage}.");
    }
}
