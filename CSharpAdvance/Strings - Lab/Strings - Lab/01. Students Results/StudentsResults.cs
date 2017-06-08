using System;
using System.Collections.Generic;
using System.Linq;

public class StudentsResults
{
    public static void Main()
    {
        var numberOfStuddents = int.Parse(Console.ReadLine());
        var students = new List<Tuple<string, double, double, double>>();

        for (int i = 0; i < numberOfStuddents; i++)
        {
            var currentLine = Console.ReadLine()
                .Split(new[] { ' ', ',', '-' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            students.Add(Tuple.Create(
                currentLine[0],
                double.Parse(currentLine[1]),
                double.Parse(currentLine[2]),
                double.Parse(currentLine[3])));
        }

        Console.WriteLine("Name      |   CAdv|   COOP| AdvOOP|Average|");
        foreach (var student in students)
        {
            var avg = (student.Item2 + student.Item3 + student.Item4) / 3;
            Console.WriteLine($"{student.Item1, -10}|   {student.Item2:F2}|    {student.Item3:F2}|   {student.Item4:F2}| {avg:F4}|");
        }
    }
}