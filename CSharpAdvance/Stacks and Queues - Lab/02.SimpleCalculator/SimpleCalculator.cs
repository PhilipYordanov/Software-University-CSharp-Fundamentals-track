using System;
using System.Collections.Generic;
using System.Linq;

public class SimpleCalculator
{
    public static void Main()
    {
        var input = Console.ReadLine();
        var remainder = input.Split(' ');
        var stack = new Stack<string>(remainder.Reverse());

        while (stack.Count > 1)
        {
            var firstNumber = int.Parse(stack.Pop());
            var @operator = stack.Pop();
            var secondNumber = int.Parse(stack.Pop());

            if (@operator == "+")
            {
                stack.Push((firstNumber + secondNumber).ToString());
            }
            else
            {
                stack.Push((firstNumber - secondNumber).ToString());
            }
        }
        Console.WriteLine(stack.Pop());
    }
}