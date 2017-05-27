using System;

public class RecursiveFibonacci
{
    public static void Main()
    {

        var number = int.Parse(Console.ReadLine());

        Console.WriteLine(GetFibonacci(number));
    }

    public static int GetFibonacci(int number)
    {
        if (number <= 2)
        {
            return 1;
        }

        return GetFibonacci(number - 1) + GetFibonacci(number - 2);
    }
}

