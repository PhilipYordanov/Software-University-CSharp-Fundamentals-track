using System;
using System.Linq;

public class MinEvenНumber
{
    public static void Main()
    {
        try
        {
            Console.WriteLine($@"{Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .Where(x => x % 2 == 0)
                .ToList()
                .Min():f2}");

        }
        catch (Exception)
        {

            Console.WriteLine("No match");
        }
    }
}