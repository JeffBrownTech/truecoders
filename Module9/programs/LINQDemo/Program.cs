using System.Linq;
using LINQDemo;

Console.WriteLine("Int Collections:");
var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// Filter collections using LINQ
// => Lambda notation
// numbers where the number is greater than 5
// Using LINQ returns the collection back to its base type (IEnumerable)
// Adding .ToList() converts it back to a list at the end
var numbersAboveFive = numbers.Where(n => n > 5).ToList();

// Lists have a built-in ForEach method, can use it to display contents
Console.WriteLine("Numbers above five:");
numbersAboveFive.ForEach(n => Console.WriteLine(n));

// Filter to get even numbers
var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
Console.WriteLine("\nEven Numbers:");
evenNumbers.ForEach(n => Console.WriteLine(n));

// Other methods
Console.WriteLine($"\nSum: {numbers.Sum()}");

Console.WriteLine($"\nAverage: {numbers.Average()}");

Console.WriteLine($"\nMin: {numbers.Min()}");

Console.WriteLine($"\nMax: {numbers.Max()}");

// Transforming with LINQ using Select
var squaredNumbers = numbers.Select(n => n * n).ToList();
Console.WriteLine("\nEach number squared:");
squaredNumbers.ForEach(n => Console.WriteLine(n));


Console.WriteLine("String Collections");
var names = new string[] { "Al", "Bob", "Charlie", "Diane", "Evelyn", "Frank", "Jeff" };

// Filter strings with LINQ
var longerNames = names.Where(x => x.Length > 4).ToArray();
Console.WriteLine("\nNames longer than 4 length:");
foreach (string n in longerNames)
{
    Console.WriteLine(n);
}

// Transforming with LINQ
var uppercaseNames = names.Select(x => x.ToUpper()).ToArray();
Console.WriteLine("\nUppercase Nmaes:");
foreach (string n in uppercaseNames)
{
    Console.WriteLine(n);
}


// Sorting/Ordering with LINQ
var orderByLength = names.OrderBy(x => x.Length).ToArray();
Console.WriteLine("\nNames ordered by length:");
foreach (string n in orderByLength)
{
    Console.WriteLine(n);
}

var dogOne = new Dog()
{
    Name = "Bingo",
    Age = 5
};

var dogTwo = new Dog()
{
    Name = "Fido",
    Age = 3
};

var dogThree = new Dog()
{
    Name = "Fido",
    Age = 8
};

var dogs = new List<Dog>() { dogOne, dogTwo, dogThree };

// Order by multiple properties by chaining methods
var dogsOrdered = dogs.OrderBy(d => d.Name).ThenBy(d => d.Age).ToList();
Console.WriteLine("\nDogs ordered by name, then age");
foreach (Dog dog in dogsOrdered)
{
    Console.WriteLine($"Name: {dog.Name}  |  Age: {dog.Age}");
}

var squares = Enumerable.Range(1,100).Average(x => x * x);
Console.WriteLine(squares);