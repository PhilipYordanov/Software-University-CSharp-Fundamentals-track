using System;
using System.Collections.Generic;
using System.Linq;

public class WeakStudents
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
            .Select(x =>
            {
                var tokens = x.Split();
                var counter = 0;
                var names = new List<string>();
                var marks = tokens
                            .Skip(2)
                            .Select(int.Parse)
                            .ToArray();
                for (int i = 0; i < marks.Length; i++)
                {
                    if (marks[i] <= 3)
                    {
                        counter++;
                    }
                }
                if (counter >= 2)
                {
                    names.Add($"{tokens[0]} {tokens[1]}");
                }
                return new { names };
            })
            .Where(x => x.names.Count != 0)
            .ToList()
            .ForEach(x => Console.WriteLine(x.names[0]));
    }
}