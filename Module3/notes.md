# Module 3: Advanced C#

## Methods
A method (or function) helps you separate your code into modules that perform a given task. You execute this code by calling the Method. In C#, a method consists of a few things.
- Access Modifiers
  - An optional list of keywords that give certain qualities to the method
  - And defines the scope and visibility
- Return Type
  - The type returned by the method or void when not returning anything
  - void is the absence of a return type
- Name
  - A descriptive method name
  - The PascalCase rule must be applied
- Parameters
  - An optional list of parameters to be passed into the method
- Scope / Body
  - The block of code to be executed when the method is called

Access Modifiers
In C#, there are four access modifiers: public, private, protected, and internal. The access modifiers can be used only in front of the following elements of the class: class declaration, fields, properties, and methods.

Access Modifiers
- Public: This element can be accessed from every class, no matter from the current project
- Private: Cannot be accessed from any other class except the class in which it is defined in.
- Internal: Used to limit the access to the elements of the class only to files from the same assembly
- Protected: The type or member can be accessed only by code in the same class or in a class that is derived from that class.

## Operators
- Ternary Operator: ```condition ? trueScope : falseSCope;```

- Null Coalescing Operator
  - Conditionally evaluate an expression and provide a fallback value in the event the expression is null
  - Syntax:
    ```var exampleValue = possiblyNullValue ?? some DefaultValue;```

- Null-Conditional Operator
  - Applies an operation to its operand only if that operand is non-null
  - Otherwise, the result of applying the operator is null
  - Example 1
    - Using conditional operator and non-null value:
      ```myList``` has been instantiated properly and is not null, so the operation is successful and ```myString``` will be added to ```myList```
        ```csharp
        List<string> myList = new List<string>();
        myList?.Add("myString");
        ```

  - Example 2
    - Using conditional operator and null value:
      ```myList``` has a ```null``` value, so the operation will not execute, and ```myString``` will not be added to ```myList```
        ```csharp
        List<string> myList = null;
        myList?.Add("myString");
        ```
 - The null conditional operator is used as a verification process. It will only execute an operation if the code is properly set up. Essentially, it acts as a null check at run-time.
 