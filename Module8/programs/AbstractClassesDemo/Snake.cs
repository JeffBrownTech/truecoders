using System;

namespace AbstractClassesDemo;

public class Snake : Animal
{
    public override void Move()
    {
        Console.WriteLine("Snake slithers!");
    }

    // Move() is not abstract but can override if needed
    public override void Breathe()
    {
        Console.WriteLine("Snake breathing...");
    }
}
