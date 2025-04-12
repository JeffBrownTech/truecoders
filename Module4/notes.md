# C# Advanced Part 2

## Syntax and Syntax Sugar

- Syntax is the grammar for programming
- Syntax sugar is syntax that is not required and not necessarily best practice, but it makes coding more convenient or concise
  - Syntax which allows writing more with less

- C# is a strongly and statically type language, meaning every variable must have a type in order to compile
- Once that type is given, it cannot change
- Declaring a type can be done explicitly or inferred
- Explicit: specifically naming the variable type
  ```string firstName = "Jeff";```

- Inferred: the compiler looks at the variable's value and infers what the most probably type is
  ```var firstName = "Jeff";```

- String interpolation
  ```csharp
  string personName = "Jerry";
    string petName = "Baxter";
    string favoriteSnack = "Chips";

    // Composite formatting:
    Console.WriteLine("Hello, {0}! Your pet's name is {1}, and your favorite snack is {2}.", personName, petName, favoriteSnack);

    // String Interpolation
    Console.WriteLine($"Hello, {personName}! Your pet's name is {petName}, and your favorite snack is {favoriteSnack}.");
    ```

## Iteration
- While loop - loops while an expression evaluates to true
- Do-While loop - executes at least once until expression evaluates to true
- For loop - specific number of times
- Foreach loop - arrays or lists
- Use break statement to exit a loop before it completes all iterations
- Use continue statemen to skip the current iteration and go to the next iteration