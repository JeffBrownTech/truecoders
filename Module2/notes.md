# Module 2: C#

Solution file (.sln):
A solution is a container used by Visual Studio to organize one or more related projects. When you open a solution in Visual Studio, it automatically loads all the projects the solution contains

Project file (.csproj):
Contains all the source code that is compiled. It also contains compiler settings and other configuration files

Structure:
- Solution files contain
- Project files which contain
- Source code

## Value and Reference Types
- C# is strongly and statically type object-oriented language
  - **Strongly** meaning you cannot change a variable's type after declaration
  - **Statically** meaning every variable must have a type at compile time

- **Stack**
  - Data ordered on top of each other
  - Used for static memory allocation with memory typically allocated at compile time
  - Fater due to its contiguous configuration and simpler allocation mechanism
- **Heap**
  - Dynamic memory allocation
  - Memory allocated at runtime
  - Slower due to overheard of managing free memory blocks and possible fragmentation

### Value Type
- Value types actually hold values. Assigning one value type to another actually copies the value into the new variable.
- Examples: structs, enums, bools, chars, numeric types
- Value types are stored in the **stack** (memory)
- The stack is used for static memory allocation and uses a Last In/First Out procedure
- Queue: The last item that enters the stack is the first item that leaves
  - ***Push*** items on the stack
  - ***Pop*** items off the stack
- Value types require a value when creating the variable
- Value types can be set to null/nullable if needed using ```?```
  - Example: ```int? myInteger = null;```

- Signed vs. Unsigned
  - **Signed** integers can be positive or negative
  - **Unsigned** integers are assumed to be positive

### Reference Type
- Storing the actual data (object) in memory and storing a reference to the object within a variable
- Reference types in C# automatically support being set to ```null```
- Example: classes, interfaces, objects, arrays, strings
- Referenced types are store din the **heap** or dynamic memory allocation
- The heap stores custom objects that may require additional memory during program runtime

## Recap
- **Value** types actually hold values, and assigning one value type to another copies the value
- **Reference** types are objects that store references to the actual data

