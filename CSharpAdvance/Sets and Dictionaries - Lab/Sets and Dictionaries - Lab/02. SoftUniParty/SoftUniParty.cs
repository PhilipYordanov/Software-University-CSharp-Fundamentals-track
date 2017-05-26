using System;
using System.Collections.Generic;
using System.Linq;

public class SoftUniParty
{
    public static void Main()
    {
        string input;

        SortedSet<string> people = new SortedSet<string>();
        SortedSet<string> checks = new SortedSet<string>();

        while ((input = Console.ReadLine()) != "PARTY")
        {
            people.Add(input);
        }

        while ((input = Console.ReadLine()) != "END")
        {
            checks.Add(input);
        }

        var result = people.Except(checks);
        Console.WriteLine(result.Count());
        foreach (var person in result)
        {
            Console.WriteLine(person);
        }
    }
}