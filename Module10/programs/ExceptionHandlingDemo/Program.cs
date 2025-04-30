var numbers = new int[] { 1, 2, 3, 4, 5 };

// Generate System.IndexOutOfRangeException
// Try-Catch Block
try
{
    Console.WriteLine(numbers[5]);
}
catch (IndexOutOfRangeException e)
{
    Console.WriteLine($"That index does not exist. {e.Message}");
}
catch (Exception e)
{
    Console.WriteLine($"Something else went wrong: {e.Message}");
}

Console.WriteLine("Continuing...");

try
{
    Console.Write("Give me a number: ");
    var userInput = int.Parse(Console.ReadLine());
    Console.WriteLine(userInput);

}
catch (FormatException e)
{
    Console.WriteLine($"Failed to parse. {e.Message}");
}
catch (Exception e)
{
    Console.WriteLine($"Something else went wrong: {e.Message}");
}
finally
{
    Console.WriteLine("Finally Block");
}

Console.WriteLine("Continuing...");

var numberStrings = new string[] { "12", "2", "ten", "9", "thirty", "four", "23" };
var realNumbers = new List<int>();

foreach (string num in numberStrings)
{
    try
    {
        realNumbers.Add(int.Parse(num));
    }
    catch (FormatException e)
    {
        Console.WriteLine($"Could not parse. {e.Message}");
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

Console.WriteLine("Correctly Parsed Numbers:");
realNumbers.ForEach(x => Console.Write($"{x} "));