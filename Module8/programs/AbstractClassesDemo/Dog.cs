using System;

namespace AbstractClassesDemo;

public class Dog : Animal
{
    // Override keyword - use when implementing abstract or changing virtual methods
    public override void Move()
    {
        Console.WriteLine("Dog runs!");
    }
}
