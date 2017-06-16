using System;
using System.Linq;

public class CustomMinFunc
{
    public static void Main()
    {
        Console.WriteLine(Console.ReadLine()
            .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .Min());
    }
}