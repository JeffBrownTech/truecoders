# Module 9: Object Oriented Programming

## Interfaces

- An **interface** is a completely abstract type that defines a set of members (methods, properties, events, or indexers) that a class or struct must implement.
- Interfaces **cannot contain fields or constructors**.
- All members are **implicitly public and abstract** (until C# 8.0+ where default implementations are allowed).
- Interfaces **do not provide any implementation** — they only define *what* must be implemented, not *how*.
- Interfaces **define a contract** that multiple classes can implement, even if those classes are unrelated in the inheritance hierarchy.
- Interfaces are often used to enable **polymorphism**, where different objects can be treated the same way if they implement the same interface.
- A class or struct that implements an interface **must implement all of its members**.
- Interfaces allow a class to **inherit behavior from multiple sources**, since C# supports implementing **multiple interfaces** but only **one base class**.
- You **do not use the `override` keyword** when implementing interface members.
- Interfaces themselves can **inherit from other interfaces**, allowing contracts to be extended or composed.
- The **naming convention** is to prefix interface names with a capital **"I"** (e.g., `IAnimal`, `IBankAccount`).

### Example

```csharp
public interface IBankAccount
{
    void Deposit(decimal amount);
    decimal GetBalance();
}

public interface IPersonalInformation
{
    string Name { get; set; }
    string Email { get; set; }
}

public class CheckingAccount : IBankAccount, IPersonalInformation
{
    public string Name { get; set; }
    public string Email { get; set; }
    private decimal _balance;

    public void Deposit(decimal amount)
    {
        _balance += amount;
    }

    public decimal GetBalance()
    {
        return _balance;
    }
}
```
### 💡 Optional Addition for C# 8.0+
> In C# 8.0 and later, interfaces can contain **default implementations** using the `default` keyword, but this is not common in beginner-level code and is more advanced.

**Interfaces vs. Abstract Classes**
Use Case | Interface | Abstract Class
-|-|-
Unrelated classes share common behavior | ✅ | ❌
You need multiple inheritance | ✅ | ❌
You want to share code or fields | ❌ | ✅
You want a simple contract | ✅ | ✅


Feature | Abstract Class | Interface
-|-|-
Can contain fields | ✅ Yes | ❌ No
Can contain constructors | ✅ Yes | ❌ No
Can provide default implementation | ✅ Yes (concrete methods) | ✅ Yes (C# 8.0+) but limited
Can inherit multiple | ❌ No (only one base class) | ✅ Yes (multiple interfaces allowed)
Use when classes are related | ✅ Yes (e.g., all are Animals) | ❌ Not required
Defines a base "is-a" relationship | ✅ Yes | ❌ No (more about "can-do")
Supports encapsulated logic | ✅ Yes | ❌ No
Purpose | Code reuse + enforce shared structure | Contract for capabilities

## Factory Pattern
- A **design pattern** that encapsulates object creation logic in a **separate class**, often called a **factory**.
- This pattern **delegates the responsibility of creating objects** to another class instead of calling constructors directly in your main code.
- It helps **decouple object creation from usage**, allowing your program to stay flexible, clean, and maintainable.
- By centralizing object creation, changes to the instantiation logic only needs to be made in the factory, not in every place an object is created.

- **Encapsulation of object creation:** All the logic for creating specific types of objects is in one place.
- **Maintainability:** If the way objects are created changes (e.g., a new subclass or parameters), you only need to change the factory — not every place where the object is used.
- **DRY Principle:** Prevents duplicating `new` logic throughout your application.
- **Polymorphism in action:** The factory returns an object as a base type or interface, but at runtime, it's actually one of many possible derived types.

### How It Works (Simplified)
1. You define a **base type or interface** (e.g., `IVehicle`).
2. You create multiple **concrete implementations** (e.g., `Car`, `Truck`, `Motorcycle`).
3. You create a **factory class** that chooses **which concrete type to return** based on some input.

### Example Structure (Overview)

```csharp
public interface IVehicle { void Drive(); }

public class Car : IVehicle { public void Drive() => Console.WriteLine("Driving a car!"); }
public class Truck : IVehicle { public void Drive() => Console.WriteLine("Driving a truck!"); }

public static class VehicleFactory
{
    public static IVehicle CreateVehicle(string type)
    {
        return type switch
        {
            "Car" => new Car(),
            "Truck" => new Truck(),
            _ => throw new ArgumentException("Invalid vehicle type")
        };
    }
}
```

### Usage in `Main()`

```csharp
IVehicle myVehicle = VehicleFactory.CreateVehicle("Truck");
myVehicle.Drive();  // Output: Driving a truck!
```

| Benefit | Explanation |
|--------|-------------|
| **Polymorphism** | The factory returns `IVehicle`, but the actual object might be a `Car` or `Truck`. |
| **Clean code** | The rest of your app doesn't need to know how vehicles are created. |
| **Easier testing** | You can test object creation and behavior independently. |
| **Open/Closed Principle** | You can add new types (e.g., `Motorcycle`) without changing the rest of the app. |

### When *Not* to Use It
- For very simple object creation that will never change or expand.
- When the overhead of an extra class (the factory) adds unnecessary complexity.
- Example: [FactoryPatternDemo](./programs/FactoryPatternDemo/)

## LINQ
- Language Integrated Query
- Used for querying data; a programming language syntax that is used to query data
- Syntax for querying and manipulating data from various sources (collections, databases, XML documents, etc.)
- Add ```System.Linq``` in program
- Methods used in Linq:
  - Where, Select, OrderBy, OrderByDescending, Sum, Average, Count, Min, Max, Take, Append, ThenBy
- Methods can be chained together

### Lambda Expression
- Use like anonymous functions (methods without names)
- You don't need to specify the type of the value that you input
- Designated using ```=>```
  - Left side is the input
  - Right side is the expression
- Example: ```x => x.Age > 26```

### Method vs. Query Syntax

#### ✅ 1. **Method Syntax** (Also called fluent or lambda syntax)

This is the most commonly used in real-world code and relies on **method chaining** with **lambda expressions**.

##### 🔧 Example: Method Syntax

```csharp
var ordered = names.Where(name => name.Length > 5)
                   .OrderBy(name => name)
                   .ToList();
```

- Uses methods like `.Where()`, `.OrderBy()`, `.Select()`
- Uses lambda expressions like `name => name.Length > 5`
- Looks like a chain of function calls

#### ✅ 2. **Query Syntax** (SQL-like)

This style resembles SQL and uses keywords like `from`, `where`, `orderby`, and `select`.

##### 🔧 Example: Query Syntax

```csharp
var ordered = (from name in names
               where name.Length > 5
               orderby name
               select name).ToList();
```

- Often easier to read for people familiar with SQL
- Not all LINQ features are available in query syntax (e.g., `.ThenBy()`, `.DistinctBy()`)

#### 🧠 When to Use Which?

| Use Case | Method Syntax | Query Syntax |
|----------|---------------|--------------|
| Most common in practice | ✅ | |
| SQL-style readability | | ✅ |
| Complex transformations (grouping, joins) | ✅ | ✅ |
| Full LINQ method support | ✅ | ❌ (some methods not supported) |

#### ✅ TL;DR

| Syntax | Style | Example |
|--------|-------|---------|
| Method | `list.Where(x => x.Length > 5)` | ✅ Most used |
| Query  | `from x in list where x.Length > 5 select x` | Good for simple queries |

Both produce the **same result** — it’s just a matter of style and what makes your code more readable!

Let me know if you'd like to see side-by-side examples or challenges using both!