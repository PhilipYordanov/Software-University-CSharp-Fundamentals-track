using System;
using System.Collections.Generic;
using System.Linq;

public class BasicQueueOperations
{
    public static void Main()
    {
        var tokens = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

        var elementsToEnqueue = tokens[0];
        var elementsToDqueue = tokens[1];
        var numberToCheck = tokens[2];

        var inputString = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

        if (elementsToEnqueue == inputString.Count())
        {
            Queue<int> numbers = new Queue<int>();

            for (int i = 0; i < inputString.Length; i++)
            {
                numbers.Enqueue(inputString[i]);
            }

            for (int i = 0; i < elementsToDqueue; i++)
            {
                numbers.Dequeue();
            }

            if (numbers.Contains(numberToCheck))
            {
                Console.WriteLine("true");
            }
            else if (!numbers.Any())
            {
                Console.WriteLine(0);
            }
            else 
            {
                Console.WriteLine(numbers.Min());
            }
        }
    }
}

