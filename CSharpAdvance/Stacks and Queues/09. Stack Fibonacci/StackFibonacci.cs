using System;
using System.Collections.Generic;

public class StackFibonacci
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Stack<long> stackFibonacci = new Stack<long>();
        stackFibonacci.Push(1);
        stackFibonacci.Push(1);

        for (int i = 2; i < number; i++)
        {
            long fibPrev = stackFibonacci.Pop();
            long fibNext = stackFibonacci.Peek() + fibPrev;
            stackFibonacci.Push(fibPrev);
            stackFibonacci.Push(fibNext);
        }

        Console.WriteLine(stackFibonacci.Peek());
    }
}

