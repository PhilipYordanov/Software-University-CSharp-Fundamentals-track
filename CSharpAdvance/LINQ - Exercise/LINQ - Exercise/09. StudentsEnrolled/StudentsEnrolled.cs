using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class StudentsEnrolled
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
                var marks = new List<string>();
                if (tokens[0].EndsWith("14") || tokens[0].EndsWith("15"))
                {
                    var sb = new StringBuilder();
                    for (int i = 1; i < tokens.Length; i++)
                    {
                        sb.Append(tokens[i]).Append(" ");
                    }
                    marks.Add($"{sb}");
                }
                return new { marks };
            })
            .Where(x => x.marks.Count != 0)
            .ToList()
            .ForEach(x => Console.WriteLine(x.marks[0]));
    }
}