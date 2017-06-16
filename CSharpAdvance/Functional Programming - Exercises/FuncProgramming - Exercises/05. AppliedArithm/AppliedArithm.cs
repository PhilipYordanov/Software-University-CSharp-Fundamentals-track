using System;
using System.Linq;

public class AppliedArithm
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        string command;

        while ((command = Console.ReadLine()) != "end")
        {
            switch (command)
            {
                case "add":
                    Func<int, int> add = n => n + 1;
                    ManipulateArray(numbers, add);
                    break;
                case "multiply":
                    Func<int, int> multiply = n => n * 2;
                    ManipulateArray(numbers, multiply);
                    break;
                case "subtract":
                    Func<int, int> subtract = n => n - 1;
                    ManipulateArray(numbers, subtract);
                    break;
                case "print":
                    Console.WriteLine(string.Join(" ", numbers));
                    break;
                default:
                    break;
            }
        }
    }

    private static void ManipulateArray(int[] numbers, Func<int, int> operation)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = operation(numbers[i]);
        }
    }
}