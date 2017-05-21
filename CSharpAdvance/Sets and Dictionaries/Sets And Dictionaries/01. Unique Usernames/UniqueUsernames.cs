using System;
using System.Collections.Generic;

public class UniqueUsernames
{
    public static void Main()
    {
        var numberOfInputs = int.Parse(Console.ReadLine());

        HashSet<string> names = new HashSet<string>();

        for (int i = 0; i < numberOfInputs; i++)
        {
            var currentName = Console.ReadLine();
            names.Add(currentName);
        }

        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}