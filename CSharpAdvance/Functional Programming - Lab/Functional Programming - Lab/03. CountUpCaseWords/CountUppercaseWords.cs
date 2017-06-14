using System;
using System.Linq;

public class CountUppercaseWords
{
    public static void Main()
    {
        Console.WriteLine(string.Join("\r\n", Console.ReadLine()
      .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
      .Where(x => char.IsUpper(x[0]))
      .ToList()));
    }
}