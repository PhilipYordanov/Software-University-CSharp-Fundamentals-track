using System;
using System.Collections.Generic;
using System.Linq;

public class StudentsByAge
{
    public static void Main()
    {
        string input;

        var stundets = new List<string>();

        while ((input = Console.ReadLine()) != "END")
        {
            stundets.Add(input);
        }

        var result = stundets
            .Select(s =>
            {
                var tokens = s.Split();
                var name = $"{tokens[0]} {tokens[1]}";
                var age = int.Parse(tokens[2]);
                return new { name, age };
            })
            .Where(a => a.age >= 18 && a.age <= 24)
            .ToList();

        foreach (var student in result)
        {
            Console.WriteLine($"{student.name} {student.age}");
        }
    }
}