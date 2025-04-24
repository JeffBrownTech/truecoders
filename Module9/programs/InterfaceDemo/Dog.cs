using System;

namespace InterfaceDemo;

public class Dog : IAnimal, IDog  // Interfaces allow for multiple inheritance
{
    public int Age { get; set; }
    public string Diet { get; set; }
    public string Owner { get; set; }
    public string Breed { get; set; }

    public void Breath()
    {
        Console.WriteLine("Dog is panting.");
    }

    public void Move()
    {
        Console.WriteLine("Dog is running");
    }
}
