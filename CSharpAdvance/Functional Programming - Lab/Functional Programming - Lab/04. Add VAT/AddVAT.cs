using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AddVAT
{
    public static void Main()
    {
        Console.WriteLine(string.Join("\r\n", Console.ReadLine()
            .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => double.Parse(x))
            .ToArray()
            .Select(x => $"{x * 1.20:F2}"))
            .ToArray());
    }
}