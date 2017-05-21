using System;
using System.Collections.Generic;
using System.Linq;

public class MaximumElement
{
    public static void Main()
    {
        var lineOfCommands = int.Parse(Console.ReadLine());

        Stack<int> stackOFNUmbers = new Stack<int>();

        for (int i = 0; i < lineOfCommands; i++)
        {
            var currentLine = Console.ReadLine();

            switch (currentLine)
            {
                case "2":
                    stackOFNUmbers.Pop();
                    break;
                case "3":
                    Console.WriteLine(stackOFNUmbers.Max());
                    break;
                default:
                    var tokens = currentLine
                        .Split()
                        .ToArray();
                    stackOFNUmbers.Push(int.Parse(tokens[1]));
                    break;
            }
        }
    }
}

