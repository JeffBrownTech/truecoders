using System;

namespace FactoryPatternDemo;

public interface IMobilePhone
{
    public void Call(string number);
    public void Text(string number, string message);
}
