static string FizzBuzz(int number)
{
    var answer = string.Empty;
    if (number % 3 == 0)
    {
        answer = "fizz";
    }
    if (number % 5 == 0)
    {
        answer += "buzz";
    }

    return answer != string.Empty ? answer : number.ToString();
}

for (int n = 0; n <= 100; n++)
{
    Console.WriteLine(FizzBuzz(n));
}