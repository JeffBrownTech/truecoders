using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Add(10, 5, 7, 4, 9, 12));
        Console.WriteLine(Subtract(50, 3, 9, 12, 4));
        Console.WriteLine(Multiply(10, 5, 2, 3, 9));
        Console.WriteLine(Divide(100, 5, 3));
    }

    static int Add(params int[] values)
    {
        int answer = values[0];

        for (int n = 1; n < values.Length; n++)
        {
            answer += values[n];
        }

        return answer;
    }

    static int Subtract(params int[] values)
    {
        int answer = values[0];

        for (int n = 1; n < values.Length; n++)
        {
            answer -= values[n];
        }

        return answer;
    }

    static int Multiply(params int[] values)
    {
        int answer = values[0];

        for (int n = 1; n < values.Length; n++)
        {
            answer *= values[n];
        }

        return answer;
    }

    static int Divide(params int[] values)
    {
        int answer = values[0];

        for (int n = 1; n < values.Length; n++)
        {
            answer /= values[n];
        }

        return answer;
    }
}