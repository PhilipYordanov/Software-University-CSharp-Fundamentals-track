using System;
using System.Collections.Generic;
using System.Linq;

public class StudentsByGroup
{
    public static void Main()
    {
        string input;

        var students = new Dictionary<string, int>();

        while ((input = Console.ReadLine()) != "END")
        {
            var currentStudent = input.Split();

            students.Add($"{currentStudent[0]} {currentStudent[1]}", int.Parse(currentStudent[2]));
        }

        students
             .Where(x => x.Value == 2)
             .OrderBy(x => x.Key)
             .ToList()
             .ForEach(x => Console.WriteLine(x.Key));
    }
}