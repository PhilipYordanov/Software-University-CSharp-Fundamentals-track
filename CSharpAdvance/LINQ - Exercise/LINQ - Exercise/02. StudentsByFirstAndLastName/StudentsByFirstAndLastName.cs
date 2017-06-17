using System;
using System.Collections.Generic;
using System.Linq;

public class StudentsByFirstAndLastName
{
    public static void Main()
    {
        string input;

        var students = new List<string>();

        while ((input = Console.ReadLine()) != "END")
        {
            var tokens = input
                .Split();

            students.Add($"{tokens[0]} {tokens[1]}");
        }

        var filtredNames = students
            .Select(s =>
            {
                var tokens = s.Split();
                var firstName = tokens[0];
                var secondName = tokens[1];
                return new { firstName, secondName };
            })
            .Where(x => x.firstName.CompareTo(x.secondName) == -1)
            .ToList();

        foreach (var student in filtredNames)
        {
            Console.WriteLine($"{student.firstName} {student.secondName}");
        }
    }
}