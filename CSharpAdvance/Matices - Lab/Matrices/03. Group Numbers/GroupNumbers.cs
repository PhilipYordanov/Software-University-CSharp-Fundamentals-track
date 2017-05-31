using System;
using System.Collections.Generic;
using System.Linq;

public class GroupNumbers
{
    public static void Main()
    {
        var input = Console.ReadLine()
            .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var matrix = new int[3][];

        var dividedWithZeroRemainder = new List<int>();
        var dividedWithOneRemainder = new List<int>();
        var dividedWithTwoRemainder = new List<int>();

        for (int i = 0; i < input.Length; i++)
        {
            if (Math.Abs(input[i]) % 3 == 0)
            {
                dividedWithZeroRemainder.Add(input[i]);
            }

            if (Math.Abs(input[i]) % 3 == 1)
            {
                dividedWithOneRemainder.Add(input[i]);
            }

            if (Math.Abs(input[i]) % 3 == 2)
            {
                dividedWithTwoRemainder.Add(input[i]);
            }
        }

        List<int>[] numberArrays = new List<int>[3];
        numberArrays[0] = dividedWithZeroRemainder;
        numberArrays[1] = dividedWithOneRemainder;
        numberArrays[2] = dividedWithTwoRemainder;

        for (int i = 0; i < matrix.Length; i++)
        {
            matrix[i] = numberArrays[i].ToArray();
        }

        // matrix.GetLength(0) - брой редове
        // matrix[row].Length - дължината на всеки ред
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix[row].Length; col++)
            {
                Console.Write($"{matrix[row][col]} ");
            }

            Console.WriteLine();
        }
    }
}