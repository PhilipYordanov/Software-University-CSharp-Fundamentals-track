using System;
using System.Collections.Generic;
using System.Linq;

public class SortStudents
{
    public static void Main()
    {
        string input;

        var stundets = new List<string>();

        while ((input = Console.ReadLine()) != "END")
        {
            stundets.Add(input);
        }

        stundets
            .Select(s =>
            {
                var tokens = s.Split();
                var firstname = tokens[0];
                var lastName = tokens[1];
                return new { firstname, lastName };
            })
            .OrderBy(x => x.lastName)
            .ThenByDescending(x => x.firstname)
            .ToList()
            .ForEach(x => Console.WriteLine($"{x.firstname} {x.lastName}"));
    }
}