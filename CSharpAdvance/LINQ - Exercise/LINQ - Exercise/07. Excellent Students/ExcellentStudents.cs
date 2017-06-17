using System;
using System.Collections.Generic;
using System.Linq;

public class ExcellentStudents
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
            .Select(currentStudent =>
            {
                var student = currentStudent;
                var names = new List<string>();
                if (currentStudent.Contains("6"))
                {
                    var studentTokens = currentStudent.Split();
                    var firstName = studentTokens[0];
                    var lastName = studentTokens[1];
                    names.Add($"{firstName} {lastName}");
                }
                return new { names };
            })
            .Where(x => x.names.Count != 0)
            .ToList()
            .ForEach(x => Console.WriteLine(x.names[0]));
    }
}