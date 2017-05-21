using System;
using System.Collections.Generic;
using System.Linq;

public class ReverseNumbersWithStack
{
    public static void Main()
    {
        var number = Console.ReadLine();
        int[] numbersToManipulateWith;

        if (number != string.Empty)
        {
            numbersToManipulateWith = number
                .Split(new[] {' ' },StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            Stack<int> stackOfNumbers = new Stack<int>();

            for (int i = 0; i < numbersToManipulateWith.Length; i++)
            {
                var currentNumber = numbersToManipulateWith[i];
                stackOfNumbers.Push(currentNumber);
            }

            foreach (var num in stackOfNumbers)
            {
                Console.Write($"{num} ");
            }
        }
    }
}

