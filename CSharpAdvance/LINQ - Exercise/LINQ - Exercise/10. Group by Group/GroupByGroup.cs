using System;
using System.Collections.Generic;
using System.Linq;

public class GroupByGroup
{
    public static void Main()
    {
        string input;

        var stundets = new List<Person>();

        while ((input = Console.ReadLine()) != "END")
        {
            var tokens = input.Split();

            var currentPerson = new Person()
            {
                Name = $"{tokens[0]} {tokens[1]}",
                Group = int.Parse(tokens[2])
            };
            stundets.Add(currentPerson);
        }

        stundets
            .GroupBy(
                    p => p.Group,
                    p => p.Name,
                    (key, g) => new { Group = key, Students = g.ToList() })
            .OrderBy(x => x.Group)
            .ToList()
            .ForEach(x => Console.WriteLine($"{x.Group} - {string.Join(", ", x.Students)}"));
    }
}

public class Person
{
    public string Name { get; set; }

    public int Group { get; set; }
}