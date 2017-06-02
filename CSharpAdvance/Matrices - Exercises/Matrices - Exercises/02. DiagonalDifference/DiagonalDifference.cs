using System;
using System.Linq;

public class DiagonalDifference
{
    public static void Main()
    {
        var matrixSize = int.Parse(Console.ReadLine());

        var matrix = new int[matrixSize][];

        var primaryDiagonal = 0;
        var secondDiagonal = 0;

        for (int row = 0; row < matrix.Length; row++)
        {
            matrix[row] = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }

        for (int row = 0; row < matrix.Length; row++)
        {
            primaryDiagonal += matrix[row][row];
            secondDiagonal += matrix[row][matrix.Length - row - 1];
        }

        var difference = primaryDiagonal - secondDiagonal;
        Console.WriteLine(Math.Abs(difference));
    }
}