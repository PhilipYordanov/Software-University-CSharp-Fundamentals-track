using System;
using System.Linq;

public class MaximalSum
{
    public static void Main()
    {
        var matrixParams = Console.ReadLine()
            .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var matrix = new int[matrixParams[0]][];

        for (int row = 0; row < matrix.Length; row++)
        {
            matrix[row] = Console.ReadLine()
            .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        }

        var maxSum = int.MinValue;

        var matrixToPrint = new int[3, 3];

        for (int row = 0; row < matrix.Length - 2; row++)
        {
            for (int col = 0; col < matrix[row].Length - 2; col++)
            {
                var rowCol = matrix[row][col];
                var rowColPlusOne = matrix[row][col + 1];
                var rowColPlusTwo = matrix[row][col + 2];

                var rowPlusOneCol = matrix[row + 1][col];
                var rowPlusOneColPlusOne = matrix[row + 1][col + 1];
                var rowPlusOneColPlusTwo = matrix[row + 1][col + 2];

                var rowPlusTwoCol = matrix[row + 2][col];
                var rowPlusTwoColPlusOne = matrix[row + 2][col + 1];
                var rowPlusTwoColPlusTwo = matrix[row + 2][col + 2];

                var currentSUm = rowCol
                    + rowColPlusOne
                    + rowColPlusTwo
                    + rowPlusOneCol
                    + rowPlusOneColPlusOne
                    + rowPlusOneColPlusTwo
                    + rowPlusTwoCol
                    + rowPlusTwoColPlusOne
                    + rowPlusTwoColPlusTwo;

                if (maxSum < currentSUm)
                {
                    maxSum = currentSUm;

                    matrixToPrint = new int[3, 3]
                    {
                        { matrix[row][col], matrix[row][col + 1], matrix[row][col + 2] },
                        { matrix[row + 1][col], matrix[row + 1][col + 1], matrix[row + 1][col + 2] },
                        { matrix[row + 2][col], matrix[row + 2][col + 1], matrix[row + 2][col + 2] }
                    };
                }
            }
        }

        var matrixRowLength = matrixToPrint.GetLength(0);
        var matrixColLength = matrixToPrint.GetLength(1);

        Console.WriteLine($"Sum = {maxSum}");
        for (int row = 0; row < matrixRowLength; row++)
        {
            for (int col = 0; col < matrixColLength; col++)
            {
                Console.Write($"{matrixToPrint[row, col]} ");
            }

            Console.WriteLine();
        }
    }
}