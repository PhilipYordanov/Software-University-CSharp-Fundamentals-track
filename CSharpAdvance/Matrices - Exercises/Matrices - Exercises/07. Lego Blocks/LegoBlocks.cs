using System;
using System.Linq;

public class LegoBlocks
{
    public static void Main()
    {
        var rowParam = int.Parse(Console.ReadLine());
        
        var firstMatrix = new int[rowParam][];
        var secondMatrix = new int[rowParam][];

        FirstMatrix(firstMatrix);
        SecondMatrix(secondMatrix);
        RevarsedSecondMatrix(secondMatrix);

        var firstRowLen = firstMatrix[0].Length + secondMatrix[0].Length;
        var countFirst = 0;
        bool isEqual = false;

        var combined = new int[rowParam][];
        isEqual = MatchCheck(rowParam, firstMatrix, secondMatrix, firstRowLen, isEqual);
        countFirst = PrintOutput(rowParam, firstMatrix, secondMatrix, countFirst, isEqual, combined);
    }

    private static bool MatchCheck(int rowParam, int[][] firstMatrix, int[][] secondMatrix, int firstRowLen, bool isQeual)
    {
        for (int i = 1; i < rowParam; i++)
        {
            var currentLength = firstMatrix[i].Length + secondMatrix[i].Length;

            if (firstRowLen != currentLength)
            {
                isQeual = true;
                break;
            }
        }

        return isQeual;
    }

    private static int PrintOutput(int rowParam, int[][] firstMatrix, int[][] secondMatrix, int countFirst, bool isQeual, int[][] combined)
    {
        if (isQeual)
        {
            for (int row = 0; row < firstMatrix.Length; row++)
            {
                countFirst += firstMatrix[row].Length + secondMatrix[row].Length;
            }

            Console.WriteLine($"The total number of cells is: {countFirst}");
        }
        else
        {
            for (int j = 0; j < rowParam; j++)
            {
                combined[j] = firstMatrix[j].Concat(secondMatrix[j]).ToArray();
            }

            for (int row = 0; row < combined.Length; row++)
            {
                Console.WriteLine($"[{string.Join(", ", combined[row])}]");
            }
        }

        return countFirst;
    }

    private static void RevarsedSecondMatrix(int[][] secondMatrix)
    {
        for (int row = 0; row < secondMatrix.Length; row++)
        {
            secondMatrix[row] = secondMatrix[row].Reverse().ToArray();
        }
    }

    private static void SecondMatrix(int[][] secondMatrix)
    {
        for (int row = 0; row < secondMatrix.Length; row++)
        {
            secondMatrix[row] = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }

    private static void FirstMatrix(int[][] firstMatrix)
    {
        for (int row = 0; row < firstMatrix.Length; row++)
        {
            firstMatrix[row] = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}