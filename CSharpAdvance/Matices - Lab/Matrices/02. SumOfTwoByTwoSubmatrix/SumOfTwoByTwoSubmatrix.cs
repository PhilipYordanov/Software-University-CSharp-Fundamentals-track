using System;
using System.Linq;

public class SumOfTwoByTwoSubmatrix
{
    public static void Main()
    {
        var dimentions = Console.ReadLine()
             .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
             .Select(int.Parse)
             .ToArray();

        int[][] matrix = new int[dimentions[0]][];
        var sum = int.MinValue;
        int[,] matrixToPrint = new int[2, 2];

        for (int i = 0; i < matrix.Length; i++)
        {
            matrix[i] = Console.ReadLine()
            .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        }

        for (int rowIndex = 0; rowIndex < matrix.Length - 1; rowIndex++)
        {
            for (int colIndex = 0; colIndex < matrix[rowIndex].Length - 1; colIndex++)
            {
                var newSquareSum = matrix[rowIndex][colIndex] +
                                   matrix[rowIndex + 1][colIndex] +
                                   matrix[rowIndex][colIndex + 1] +
                                   matrix[rowIndex + 1][colIndex + 1];

                if (sum < newSquareSum)
                {
                    sum = newSquareSum;
                    matrixToPrint = new int[2, 2]
                    {
                        { matrix[rowIndex][colIndex], matrix[rowIndex + 1][colIndex] },
                        { matrix[rowIndex][colIndex + 1], matrix[rowIndex + 1][colIndex + 1] }
                    };
                }
            }
        }

        for (int rowIndex = 0; rowIndex < matrixToPrint.GetLength(0); rowIndex++)
        {
            for (int colIndex = 0; colIndex < matrixToPrint.GetLength(1); colIndex++)
            {
                Console.Write($"{matrixToPrint[colIndex, rowIndex]} ");
            }

            Console.WriteLine();
        }

        Console.WriteLine(sum);
    }
}