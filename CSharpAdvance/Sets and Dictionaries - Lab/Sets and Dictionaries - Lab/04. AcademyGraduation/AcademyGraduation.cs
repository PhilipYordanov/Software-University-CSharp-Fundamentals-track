using System;
using System.Collections.Generic;
using System.Linq;

public class AcademyGraduation
{
    public static void Main()
    {
        var numberOfStudents = int.Parse(Console.ReadLine());
        var numberOfQueries = numberOfStudents * 2;
        string student = string.Empty;

        var name_avgGrades = new SortedDictionary<string, double>();

        for (int i = 0; i < numberOfQueries; i++)
        {
            var currentLine = Console.ReadLine();

            if (i % 2 == 0)
            {
                student = currentLine;
                if (!name_avgGrades.ContainsKey(currentLine))
                {
                    name_avgGrades[currentLine] = 0;
                }
            }
            else
            {
                var grades = currentLine
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray()
                    .Average();

                name_avgGrades[student] = grades;
            }
        }

        foreach (var kvp in name_avgGrades)
        {
            var name = kvp.Key;
            var averageGrades = kvp.Value;
            Console.WriteLine($"{name} is graduated with {averageGrades}");
        }
    }
}