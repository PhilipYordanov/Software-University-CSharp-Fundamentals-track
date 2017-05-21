using System;
using System.Collections.Generic;
using System.Text;

public class PeriodicTable
{
    public static void Main()
    {
        var numberOfElements = int.Parse(Console.ReadLine());
        HashSet<string> elements = new HashSet<string>();

        for (int i = 0; i < numberOfElements; i++)
        {
            var currentLine = Console.ReadLine()
                .Split();

            for (int j = 0; j < currentLine.Length; j++)
            {
                elements.Add(currentLine[j]);
            }
        }

        SortedSet<string> sortedElements = new SortedSet<string>();
        foreach (var element in elements)
        {
            sortedElements.Add(element);
        }

        StringBuilder builder = new StringBuilder();
        foreach (var element in sortedElements)
        {
            builder.Append(element).Append(" ");
        }

        Console.WriteLine(builder);
    }
}