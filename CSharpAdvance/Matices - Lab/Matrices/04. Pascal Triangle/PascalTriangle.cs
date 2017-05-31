using System;

public class PascalTriangle
{
    public static void Main()
    {
        var numberOfRows = int.Parse(Console.ReadLine());

        var result = new long[numberOfRows][];

        for (int row = 0; row < result.GetLength(0); row++)
        {
            result[row] = new long[row + 1];
            result[row][0] = 1;
            result[row][result[row].Length - 1] = 1;

            if (row >= 2)
            {
                for (int col = 0; col < result[row].Length - 2; col++)
                {
                    result[row][col + 1] = result[row - 1][col + 1] + result[row - 1][col];
                }
            }
        }

        for (int row = 0; row < result.Length; row++)
        {
            for (int col = 0; col < result[row].Length; col++)
            {
                Console.Write($"{result[row][col]} ");
            }

            Console.WriteLine();
        }
    }
}