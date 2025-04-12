using System;

namespace ClassesDemo;

public class Classroom
{
    // Properties
    public List<Person> CodingClass { get; set;} = new List<Person>();

    // Methods
    public void GreetEveryone()
    {
        foreach (var student in CodingClass)
        {
            student.Greet();
        }
    }
}
