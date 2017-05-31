using System;
using System.Linq;

public class SumMatrixElements
{
    public static void Main()
    {
        var dimentions = Console.ReadLine()
            .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int[][] matrix = new int[dimentions[0]][];

        var len = 0;
        var sum = 0;

        for (int i = 0; i < matrix.Length; i++)
        {
            matrix[i] = Console.ReadLine()
            .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            len = matrix[i].Length;
            sum += matrix[i].Sum();
        }

        Console.WriteLine(dimentions[0]);
        Console.WriteLine(len);
        Console.WriteLine(sum);
    }
}