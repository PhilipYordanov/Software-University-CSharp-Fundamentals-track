using System;
using System.Linq;

public class FindAndSumIntegers
{
    public static void Main()
    {
        var nums = Console.ReadLine()
             .Split()
             .Select(w =>
             {
                 long value;
                 bool sucsess = long.TryParse(w, out value);
                 return new { value, sucsess };
             })
             .Where(n => n.sucsess)
             .Select(n => n.value)
             .ToList();

        if (!(nums.Count == 0))
        {
            Console.WriteLine(nums.Sum());
        }
        else
        {
            Console.WriteLine("No match");
        }
    }
}