using System;
using System.Collections.Generic;

public class MultiplyBigNumber
{
    public static void Main()
    {
        var remainder = 0;
        var bigNum = Console.ReadLine().ToCharArray();
        var multiplier = int.Parse(Console.ReadLine());
        var resultNumber = new Stack<int>();
        if (multiplier == 0)
        {
            Console.WriteLine("0");
            return;
        }
        for (int i = bigNum.Length - 1; i >= 0; i--)
        {
            var currentNumber=Char.GetNumericValue(bigNum[i]);
            var currentResult = ((currentNumber * multiplier) + remainder).ToString().ToCharArray();
            if (currentResult.Length > 1)
            {
                remainder= (int)Char.GetNumericValue(currentResult[0]);
                resultNumber.Push((int)Char.GetNumericValue(currentResult[1]));
                if (bigNum.Length == 1)
                {
                    resultNumber.Push(remainder);
                    Console.WriteLine(string.Join("",resultNumber));
                    return;
                }
            }
            else
            {
                resultNumber.Push((int)Char.GetNumericValue(currentResult[0]));
                remainder = 0;
            }
        }

        if (remainder != 0)
        {
            resultNumber.Push(remainder);
        }
        var finalResult = string.Join("", resultNumber);
        Console.WriteLine(finalResult.TrimStart('0'));
    }
}