# C# Advanced Part 3

## Method Overloading

- Creating methods with the same name but different signatures (parameters)
- Enables using methods for different situations
- Cannot overload methods that differ only in return type; the parameters must also differ
- If a parameter represents that same value in another method, the parameters should have the same name

- Example:
```csharp
internal class WithMethodOverloading
public static int Add(int a, int b)
{
	return a + b;
}
public static int Add(int a, int b, int c)
{
	return a + b + c;
}
public static int Add(int a, int b, int c, int d)
{
	return a + b + c + d;
}
```

## Arrays
- Store multiple values in a single variable instead of declaring separate variable for each value
- Good for a fixed number of strongly-typed objects
- In C#, arrays are objects and not just addressable regions of contiguous memory, like C and C++
- Declaring arrays examples:
    ```csharp
    // Example 1 – Declaring an array of size 3
    int[] myArray01 = new int[3];

    myArray01[0] = 1; // Initializing index 0 with the value of 1
    myArray01[1] = 2; // Initializing index 1 with the value of 2
    myArray01[2] = 3; // Initializing index 2 with the value of 3

    // Example 2 – Declaring and Initializing an array
    int[] myArray02 = new int[5] { 5, 8, 22, 11, 27 }; // Declaring and initializing the array at creation

    int[] myArray03 = new int[] { 5, 8, 22, 11, 27 }; // You can omit the "[5]" if you initialize right away

    // Example 3 – Shorthand
    var myArray04 = new int[] { 5, 8, 22, 11, 27 }; // Same as above but using var (inferred typing)

    // Example 4 – Shorthand
    string[] cars = { "Tesla", "Civic", "Camry" }; // Short-hand syntax
    ```

## Lists (Collections)
- Have more flexibility, can grow and shrink dynamically as needed
- Some collections support assigning a key to any object put into the collection so you can retrieve the object using the key
- Collections are classes, so you must declare an instance of the class before adding elements to that collectio
- Use ```System.Collections.Generic``` when the collection contains elements of only one data type
- Declare a list of ints
    ```csharp
    var numbers = new List<int>();
    var myIntList = new List<int>() { 1, 2, 3, 4, 5 };
    ```
- The ```.Count``` property retrieves number of elements in the list
- The ```.Capacity``` property indicating how much space has been allocated to the list by the compiler

---

## Arrays vs. Lists/Collections in C#

| Feature | **Array (`T[]`)** | **List (`List<T>`)** |
|--------|------------------|---------------------|
| **Fixed Size** | ✅ Yes – size is set at creation | ❌ No – resizable dynamically |
| **Performance** | ✅ Faster for fixed-size data | ⚠️ Slightly slower due to resizing and overhead |
| **Syntax Simplicity** | ✅ Very simple | ✅ Also simple, but with more features |
| **Mutability** | Elements can be changed, size cannot | Both elements and size can be changed |
| **Indexing** | ✅ Supports `array[0]` style access | ✅ Same as arrays (`list[0]`) |
| **Initial Declaration** | `int[] arr = new int[3];` or `int[] arr = {1,2,3};` | `List<int> list = new List<int> {1,2,3};` |
| **Adding/Removing** | ❌ Not allowed after initialization | ✅ `list.Add()`, `list.Remove()` |
| **Use in APIs** | Common in low-level and performance-critical code | Common in business logic and LINQ-heavy code |
| **LINQ Support** | ✅ Fully supported | ✅ Fully supported |
| **Thread-Safety** | ❌ Not thread-safe | ❌ Not thread-safe (unless using `ConcurrentBag<T>`, etc.) |
| **Resizing** | ❌ Requires creating a new array | ✅ Automatic resizing when adding elements |

### ✅ Use **Arrays** when:
- You know the **exact number of elements**
- You want **better performance** (e.g., in tight loops or game dev)
- You're working with **low-level interop** or APIs that require arrays

### ✅ Use **List<T>** when:
- You need to **dynamically add or remove items**
- You want to take advantage of **LINQ**, filtering, searching
- You're writing **business logic** or working with **collections of unknown size**
