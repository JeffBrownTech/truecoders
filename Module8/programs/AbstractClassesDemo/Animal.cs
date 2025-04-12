using System;
using System.Data;

namespace AbstractClassesDemo;

// Use abstract keyword to make it a template
// Cannot instantiate an object from this class, only inherited by other classes
// Any abstract members must be defined in inherited classes
public abstract class Animal
{
    public int Age { get; set; }
    public string Diet { get; set; }

    // Abstract methods (stubbed out methods)(not sure how they'll quite work yet)
    public abstract void Move();

    // Virtual methods (non-stubbed out methods)(define as normal)
    public virtual void Breathe()
    {
        Console.WriteLine("Breathe in, breathe out");
    }
}
