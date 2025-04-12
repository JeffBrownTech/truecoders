using System;

namespace EncapsulationDemo;

public class Person
{
    // Properties
    public string Name { get; set; }
    public int Age { get; set; }

    // Fields
    private double _wallet;

    // Use Methods (public) can access private fields
    // Methods can work with anything in the class
    public void AddMoney(double amount)
    {
        _wallet += amount;
    }

    public double CheckWallet()
    {
        return _wallet;
    }
}
