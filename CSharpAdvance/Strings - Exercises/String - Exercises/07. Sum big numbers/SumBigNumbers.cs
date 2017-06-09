using System;
using System.Numerics;

public class SumBigNumbers
{
    public static void Main()
    {
        var firstnumber = BigInteger.Parse(Console.ReadLine());
        var secondNumber = BigInteger.Parse(Console.ReadLine());
        Console.WriteLine(firstnumber + secondNumber);
    }
}