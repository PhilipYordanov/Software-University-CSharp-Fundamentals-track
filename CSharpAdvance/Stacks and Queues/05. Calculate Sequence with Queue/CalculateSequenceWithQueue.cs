using System;
using System.Collections.Generic;

//first 50 elements of 
//•	S1 = N
//•	S2 = S1 + 1
//•	S3 = 2* S1 + 1
//•	S4 = S1 + 2
//•	S5 = S2 + 1
//•	S6 = 2* S2 + 1
//•	S7 = S2 + 2
//•	.....

public class CalculateSequenceWithQueue
{
    public static void Main()
    {
        var inputNumber = long.Parse(Console.ReadLine());

        Queue<long> elementsInSequence = new Queue<long>();
        List<long> result = new List<long>();

        elementsInSequence.Enqueue(inputNumber);
        result.Add(inputNumber);

        while (result.Count < 50)
        {
            long currentElement = elementsInSequence.Dequeue();
            long firstNumber = currentElement + 1;
            long secondNumber = (currentElement * 2) + 1;
            long thirdNumber = currentElement + 2;

            elementsInSequence.Enqueue(firstNumber);
            elementsInSequence.Enqueue(secondNumber);
            elementsInSequence.Enqueue(thirdNumber);

            result.Add(firstNumber);
            result.Add(secondNumber);
            result.Add(thirdNumber);
        }

        for (int i = 0; i < 50; i++)
        {
            Console.Write(result[i] + " ");
        }
    }
}

