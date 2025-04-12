# Module 7: Object Oriented Programming

- Classes enable Abstraction, Polymorphism, Inheritance, Encapsulation
  - Abstraction is the concept of hiding complex implementation details and exposing only the relevant features needed to use an object or system.
  - Polymorphism allows objects of different types to be accessed through a common interface or base class, enabling behavior to vary depending on the actual object type.
  - Inheritance is a mechanism that allows a derived class to reuse the members (fields and methods) of a base class, promoting code reuse and hierarchical relationships.
  - Encapsulation is the practice of combining data and the methods that operate on it within a single unit (class), while controlling access to that data through access modifiers like ```private```, ```public```, and ```protected```.
- In JetBrains Rider, create new console app but uncheck "Do not use top-level statements"
  - Unchecking this seems to mimic the same behavior as using ```dotnet new console``` from the command line
  - There is a single Program.cs file without the namespace, class, main method code (these are the top level statements)
  - Anything that goes into Program.cs is going to run in the main method now
- Moving forward, going to create separate class files to put methods, variables, etc.
- Keep Program.cs as clutter free as possible, only include objects and method calls

## Classes
- Blueprint that defines objects, what they are, how it works
- Allows creating instances of the object
- Created using keyword ```class```
- Example: Person class
- Members of the Class are Fields, Properties, Methods, and Constructors
- Components
  - Fields: variables within a class (camelCase), starts with ```_```
    - Private: used only within the class
    - Public: available to entire project
  - Properties: things that define the class (PascalCase); enforce data integrity or add logic when data is accessed or modified; provides access to fields
    ```public string Name { get; set; }
  - Methods: static or non-static, performs actions or operations
  - Constructor: special methods to call when an instance of a class is created, initializes the object
    - Default constuctor does not accept parameters
    - Custom constuctors intialize with specific values or performs any setup
- Call the constructor ```()``` to build an instance of the class
  ``Person jeff = new Persion();```

## Encapsulation
- A group of related properties, methods, and other members are treated as a single unit or object
- Provides code security, flexibility, and easy maintainability
- Encapsulation (information hiding) is useful in hiding the data (instance variables) of a class from illegal direct access
- Encapsulation involves bundling the data (attributes) and methods (functions) that operate on the data into a single unit or class, restricting access to some of the object's components
- Implement Encapsulation by using Access Modifiers. C# supports the following access modifiers:
  - public - access modifier makes the member accessible from outside of the class
  - private - makes members accessible only from within the class it was created in and hides the member from the outside
  - protected - the member can only be accessed by code in the same class or in a derived class
  - internal - the member can be accessed by any code in the same assembly, but not from another assembly
  - protected internal - the member can be accessed by any code in the same assembly, or by any derived class in another assembly