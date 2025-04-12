using System;

namespace ClassesDemo;

public class Person
{
    // Fields - variables inside of class
    public int wallet;
    public string clothes;

    // Properties - things that define the class (e.g. Count, Length, etc.)
    public string Name { get; set; }
    public int Age { get; set; }

    // Methods
    public void Greet()
    {
        Console.WriteLine($"Hello! My name is {Name}.");
    }

    // Default Constructor
    public Person()
    {

    }

    // Custom Constuctor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
