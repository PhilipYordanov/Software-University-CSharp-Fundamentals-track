using System;
using System.Collections.Generic;
using System.Linq;

public class Crossfire
{
    public static void Main()
    {
        var initializeMatrixToPrint = new Queue<int[]>();

        var matrixParams = Console.ReadLine()
            .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        var counter = 1;

        var matrix = new int[Math.Abs(matrixParams[0])][];

        for (int row = 0; row < matrix.Length; row++)
        {
            matrix[row] = new int[Math.Abs(matrixParams[1])];

            for (int col = 0; col < matrix[row].Length; col++)
            {
                matrix[row][col] = counter;
                counter++;
            }
        }

        string input;

        while ((input = Console.ReadLine()) != "Nuke it from orbit")
        {
            var targetParams = input
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var targetRow = targetParams[0];
            var targetCol = targetParams[1];
            var range = targetParams[2];

            try
            {
                var currentRow = matrix[targetRow].ToList();
                currentRow[targetCol] = 0;
                ShootRight(targetCol, range, currentRow);
                ShootLeft(targetCol, range, currentRow);
                matrix[targetRow] = currentRow.ToArray();
                ShootNextRows(matrix, targetRow, targetCol, range);
                ShootPreviousRows(matrix, targetRow, targetCol, range);

                for (int row = 0; row < matrix.Length; row++)
                {
                    var arr = matrix[row];
                    arr = arr.Where(s => s != 0).ToArray();

                    int areAllZeros = 0;

                    // check if the whole row is zeros
                    bool allEqual = arr
                      .All(currentRowToCheck => int.Equals(areAllZeros, currentRowToCheck));
                    // if the row contains elements different from zeros  
                    if (!allEqual)
                    {
                        initializeMatrixToPrint.Enqueue(arr);
                    }
                }
                matrix = new int[initializeMatrixToPrint.Count][];
                for (int i = 0; i < matrix.Length; i++)
                {
                    matrix[i] = initializeMatrixToPrint.Dequeue();
                }
            }
            catch (Exception)
            {
                try
                {
                    if (targetRow >= 0 && targetRow < matrix[0].Length)
                    {
                        if (targetCol - range >= 0 && targetCol - range < matrix[0].Length)
                        {
                            for (int i = targetCol - range; i < matrix[0].Length; i++)
                            {
                                matrix[targetRow][i] = 0;
                            }
                        }
                        if (targetCol - range < 0 && targetCol > 0)
                        {
                            for (int i = 0; i < matrix[0].Length; i++)
                            {
                                matrix[targetRow][i] = 0;
                            }
                        }
                    }
                }
                catch (Exception)
                {
                }

                try
                {
                    if (targetRow >= 0 && targetRow < matrix[0].Length)
                    {
                        if (targetCol + range >= 0 && targetCol + range <= matrix[0].Length)
                        {
                            for (var i = targetCol + range - 1; i >= 0; i--)
                            {
                                matrix[targetRow][i] = 0;
                            }
                        }
                        if (targetCol + range > matrix[0].Length && targetCol < 0)
                        {
                            for (int i = matrix[0].Length - 1; i >= 0; i--)
                            {
                                matrix[targetRow][i] = 0;
                            }
                        }
                    }
                }
                catch (Exception)
                {
                }

                try
                {
                    if (targetCol >= 0 && targetCol < matrix[0].Length)
                    {
                        if (targetRow - range >= 0 && targetRow - range < matrix.Length)
                        {
                            for (var i = targetRow - range; i < matrix.Length; i++)
                            {
                                matrix[i][targetCol] = 0;
                            }
                        }
                        if (targetRow - range < 0 && targetRow > 0)
                        {
                            for (int i = 0; i < matrix.Length; i++)
                            {
                                var asd = matrix[i].ToList();
                                asd.RemoveAt(targetCol);
                                matrix[i] = asd.ToArray();
                            }
                        }
                    }
                }
                catch (Exception)
                {
                }
                try
                {
                    if (targetCol >= 0 && targetCol < matrix[0].Length)
                    {
                        if (targetRow + range >= 0 && targetRow + range <= matrix.Length)
                        {
                            for (var i = targetRow + range; i > 0; i--)
                            {
                                matrix[i - 1][targetCol] = 0;
                            }
                        }
                        if (targetRow + range > matrix.Length && targetRow < 0)
                        {
                            for (int i = matrix.Length; i > 0; i--)
                            {
                                var asd = matrix[i - 1].ToList();
                                asd.RemoveAt(targetCol);
                                matrix[i - 1] = asd.ToArray();
                            }
                        }
                    }
                }
                catch (Exception)
                {
                }
                for (int row = 0; row < matrix.Length; row++)
                {
                    var arr = matrix[row];
                    arr = arr.Where(s => s != 0).ToArray();

                    int areAllZeros = 0;

                    // check if the whole row is zeros
                    bool allEqual = arr
                      .All(currentRowToCheck => int.Equals(areAllZeros, currentRowToCheck));
                    // if the row contains elements different from zeros  
                    if (!allEqual)
                    {
                        initializeMatrixToPrint.Enqueue(arr);
                    }
                }
                matrix = new int[initializeMatrixToPrint.Count][];
                for (int i = 0; i < matrix.Length; i++)
                {
                    matrix[i] = initializeMatrixToPrint.Dequeue();
                }
            }
        }
        for (int row = 0; row < matrix.Length; row++)
        {
            for (int col = 0; col < matrix[row].Length; col++)
            {
                Console.Write($"{matrix[row][col]} ");
            }
            Console.WriteLine();
        }
    }

    private static void ShootPreviousRows(int[][] matrix, int targetRow, int targetCol, int range)
    {
        for (int i = 1; i <= range; i++)
        {
            try
            {
                var nextRow = matrix[targetRow - i].ToList();
                nextRow.RemoveAt(targetCol);
                matrix[targetRow - i] = nextRow.ToArray();
            }
            catch (Exception)
            {
            }
        }
    }

    private static void ShootNextRows(int[][] matrix, int targetRow, int targetCol, int range)
    {
        for (int i = 1; i <= range; i++)
        {
            try
            {
                var nextRow = matrix[targetRow + i].ToList();
                nextRow.RemoveAt(targetCol);
                matrix[targetRow + i] = nextRow.ToArray();
            }
            catch (Exception)
            {

            }
        }
    }

    private static void ShootLeft(int targetCol, int range, List<int> currentRow)
    {
        for (int i = 0; i < range; i++)
        {
            try
            {
                currentRow[targetCol - 1 - i] = 0;
            }
            catch (Exception)
            {
            }
        }
    }

    private static void ShootRight(int targetCol, int range, List<int> currentRow)
    {
        for (int i = 0; i < range; i++)
        {
            try
            {
                currentRow[targetCol + 1 + i] = 0;
            }
            catch (Exception)
            {
            }
        }
    }
}