# Module 8: Object Oriented Programming

## Inheritance
- Create new classes that reuse, extend, and modify all the behavior that is defined in other classes.
- Members are inherited from the base class (except constructors and finalizers)
  - A finalizer is a special method used for cleaning up resources just before an object is destroyed
- Derived class can reuse the code in the base class without having to re-implement it
- Example: base class Animal can be used to derive Cat and Dog classes

## Static Keyword
- Static, when applied to class members, means the class member belongs to the type/class itself and not to individual object instances
- Class can be non-static but have static members
  - Static properties are the same and exist across all instances of the class
  - You would not be able to access the static property across individual objects
  - Instead, refer to the class and property (e.g. ```Classroom.Subject```)
- Example
  Here is a Teacher class with two properties, one static and one non-static
  ```csharp
  class Teacher
  {
    public string Name { get; set; }
    public static string Subject { get; set; }
  }
  ```

  The non-static property is accessed normally as a property of the instantiated object.
  However, for ```Subject```, it is accessed as a property of the class.

  ```csharp
  Teacher jeff = new Teacher();
  jeff.Name = "Jeff";
  Teacher.Subject = "C#";
  ```

- Static members allow data or functionality to be shared among all instances of the class
  - Useful for maintaining global state or providing utility functions
- Classes, Fields or Variables, Properties, Methods, Constructors can all be static
- When a member is static, there is only one copy of that member

- Example of a ```BankAccount`` non-static class with static members
  - Static properties like ```InterestRate``` are shared across all instances of the class
  - Static methods like ```CalculateIntereset``` is shared among all instances of the class
  - Non-static members like ```_balance```, ```Deposit()```, and ```GetBalance()``` are unique to each object created from the class

    ```csharp
    public class BankAccount
    {
        private decimal _balance;

        // Static field shared by ALL accounts
        public static decimal InterestRate { get; set; } = 0.03m;

        public void Deposit(decimal amount)
        {
            _balance += amount;
        }

        public decimal GetBalance()
        {
            return _balance;
        }

        // Static method for interest calculation — doesn't depend on a specific instance
        public static decimal CalculateInterest(decimal amount)
        {
            return amount * InterestRate;
        }
    }
    ```

### Static Classes
- An entire class can also be static
- Static classes are sealed, meaning you cannot have a child class that inherits from the static class
- All members in the class must be static also
- You cannot instantiate an object from a static class (can't use ```new```); you access the members of a static class by using the class name
- Static classes are convenient for utility functions as they don't require instantiation and members are access directly through the class name
- An example of statis class and its static class members is ```System.Math```
  - It is inefficient to create a new instance of the Math class every time you need it
  - Instead, you just class methods from the class
    ```csharp
    Math.Pow(3,2)
    Math.Sqrt(144)
    ```

- Static classes are a toolbox - it holds tools (methods) but you don't need to create a new toolbox to use the tools
- Use static classes when you don't need to maintain state (no fields or instance data)
- Example: Static Utility Class
  
    ```csharp
    public static class MathHelper
    {
        public static double Square(double number)
        {
            return number * number;
        }

        public static double Cube(double number)
        {
            return number * number * number;
        }

        public static double InchesToCentimeters(double inches)
        {
            return inches * 2.54;
        }
    }
    ```

## Abstract Classes
- Creating a base class for other classes to inherit from
- Serve as templates or base objects (blueprint) for other classes that can customize or extend implementations
- Features
  - Abstract classes cannot be instantiated as an object
  - Abstract classes may contain abstract methods and accessors
  - Non-abstract derived classes must include actual implementations of all inherited *abstract* methods and accessors.

- Declare abstract class:
  ```csharp
  public abstract class Animal
  ```

- Use keyword ```abstract``` to declare any abstract members that must be implemented in child class
  ```csharp
  public abstract void Move();
  ```

- Virtual Keyword
  - Use to mark a property or method where the base class will provide an implementation of the member but the derived class can override the implementation
  - Example: ```public virtual void Breathe()```
  - In derived class, use ```override``` to provide a specific implementation for a method or property
    ```public override void Move()```

### Concrete Class
- Any class that provides a complete implementation, meaning in includes all the members and properties necessary to be instantiated as an object
- Abstract classes are *not* concrete, but the derived class is

### Polymorphism
- Dynamic Polymorphism
  - Allows objects of a derived class to be treated as objects of a base class at runtime, enabling flexible and interchangeable behavior
  - Enforces common behavior across multiple subclasses

- Declaring a variable as a base type (e.g. ```Vehicle``` abstract class) leverages polymorphism
  ```csharp
  Vehicle carThree = new Car();
  ```

  - Allows treating objects created from derived classes as the same common type
  - For example, creating a ```List<Vehicle>``` allows adding both Cars and Motorcycles
    ```csharp
    List<Vehicle> vehicles = new List<Vehicle>();
    vehicles.Add(new Car());
    vehicles.Add(new Motorcycle());
    ```

- Static Polymorphism
  - Method overloading, where the correct method to call is determined at compile time

### Abstract Example: PaymentProcessor
- Need to process payments but using different methods (credit cads, PayPal, bank transfers)
- Each method has unique processing logic while sharing common behaviors

**Abstract Base Class Implementation**
- Properties ```MerchantId``` and ```Currency``` are common among all transactions
- Method ```LogTransaction``` to implement a common logging method
- Abstract method ```ProcessPayment``` must be implement in each child class for its unique processing method

```csharp
public abstract class PaymentProcessor
{
    public string MerchantId { get; set; }
    public string Currency { get; set; }

    // A concrete method that logs transactions.
    public void LogTransaction(decimal amount)
    {
        Console.WriteLine($"Transaction of {amount:C} in {Currency} processed for merchant {MerchantId}.");
    }

    // An abstract method that each processor must implement.
    public abstract bool ProcessPayment(decimal amount);
}
```

**Concrete Class: CreditCardProcess***
```csharp
public class CreditCardProcessor : PaymentProcessor
{
    // Implementation of processing a credit card payment.
    public override bool ProcessPayment(decimal amount)
    {
        // Simulate credit card payment processing logic.
        Console.WriteLine($"Processing credit card payment for {amount:C}...");
        
        // For example, check card validity, authorize the amount, etc.
        // If successful:
        LogTransaction(amount);
        return true;
    }
}
```

**Concrete Class: PayPalProcessor**
```csharp
public class PayPalProcessor : PaymentProcessor
{
    public string PayPalAccountEmail { get; set; }

    public override bool ProcessPayment(decimal amount)
    {
        // Simulate PayPal payment processing logic.
        Console.WriteLine($"Processing PayPal payment for {amount:C}...");
        Console.WriteLine($"Using account: {PayPalAccountEmail}");

        // If successful:
        LogTransaction(amount);
        return true;
    }
}
```

### Additional Real-World Examples
- Shape Hierarchy:
  An abstract Shape class with abstract methods like CalculateArea() and Draw(). Derived classes such as Circle, Rectangle, and Triangle provide specific implementations.

- Employee Hierarchy:
  An abstract Employee class that includes properties like Name and an abstract method CalculateSalary(). Derived classes (FullTimeEmployee, PartTimeEmployee, Contractor) implement salary calculation differently.