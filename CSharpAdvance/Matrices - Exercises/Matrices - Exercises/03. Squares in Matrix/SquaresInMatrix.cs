using System;
using System.Linq;

public class SquaresInMatrix
{
    public static void Main()
    {
        var matrixParams = Console.ReadLine()
            .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var matrix = new string[matrixParams[0]][];

        for (int row = 0; row < matrix.Length; row++)
        {
            matrix[row] = Console.ReadLine()
            .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        }

        var counter = 0;

        for (int row = 0; row < matrix.Length - 1; row++)
        {
            for (int col = 0; col < matrix[row].Length - 1; col++)
            {
                var rowCol = matrix[row][col];
                var rowColPlusOne = matrix[row][col + 1];
                var rowPlusOneCol = matrix[row + 1][col];
                var rowPlusOneColPlusOne = matrix[row + 1][col + 1];

                if (rowCol == rowColPlusOne
                    && rowColPlusOne == rowPlusOneCol
                    && rowPlusOneCol == rowPlusOneColPlusOne)
                {
                    counter++;
                }
            }
        }

        Console.WriteLine(counter);
    }
}