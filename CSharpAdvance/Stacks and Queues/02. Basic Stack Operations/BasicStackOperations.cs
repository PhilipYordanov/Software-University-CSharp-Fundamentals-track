using System;
using System.Collections.Generic;
using System.Linq;

public class BasicStackOperations
{
    public static void Main()
    {
        var tokens = Console.ReadLine()
            .Split()
            .Select(x => int.Parse(x))
            .ToArray();

        var elementsToPush = tokens[0];
        var elementsToPop = tokens[1];
        var numberToCheck = tokens[2];

        Stack<int> stackOFNumbers = new Stack<int>();

        var inputNUmbers = Console.ReadLine()
            .Split()
            .Select(x => int.Parse(x))
            .ToArray();

        if (elementsToPush == inputNUmbers.Count())
        {
            foreach (var num in inputNUmbers)
            {
                stackOFNumbers.Push(num);
            }
        }

        if (stackOFNumbers.Count() >= elementsToPop)
        {
            for (int i = 0; i < elementsToPop; i++)
            {
                stackOFNumbers.Pop();
            }
        }

        if (stackOFNumbers.Any())
        {
            for (int i = 0; i < stackOFNumbers.Count(); i++)
            {
                if (stackOFNumbers.Contains(numberToCheck))
                {
                    Console.WriteLine("true");
                    break;
                }
                else
                {
                    Console.WriteLine(stackOFNumbers.Min());
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}

