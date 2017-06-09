using System;
using System.Linq;

public class FormattingNumbers
{
    public static void Main()
    {
        var input = Console.ReadLine()
            .Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
           .ToArray();

        var firstNum = int.Parse(input[0]);
        var secondNum = double.Parse(input[1]);
        var thirdNum = double.Parse(input[2]);

        string firstNumToString = firstNum.ToString("X");
        var firstNumToBinary = Convert.ToString(firstNum, 2).PadLeft(10, '0');
        if (firstNumToBinary.Length > 10)
        {
            var secondNumberWithFormat = $"{secondNum:f2}";
            var thirdNumberWithFormat = $"{thirdNum:f3}";
            var binaryWithMoreThanTenDigits = firstNumToBinary.Substring(0, 10);
            Console.WriteLine("|{0,-10}|{1,-10}|{2,10}|{3,-10}|", firstNumToString, binaryWithMoreThanTenDigits, secondNumberWithFormat, thirdNumberWithFormat);
        }
        else
        {
            firstNumToBinary = Convert.ToString(firstNum, 2).PadLeft(10, '0');
            var secondNumberWithFormat = $"{secondNum:f2}";
            var thirdNumberWithFormat = $"{thirdNum:f3}";
            Console.WriteLine("|{0,-10}|{1,-10}|{2,10}|{3,-10}|", firstNumToString, firstNumToBinary, secondNumberWithFormat, thirdNumberWithFormat);
        }
    }
}