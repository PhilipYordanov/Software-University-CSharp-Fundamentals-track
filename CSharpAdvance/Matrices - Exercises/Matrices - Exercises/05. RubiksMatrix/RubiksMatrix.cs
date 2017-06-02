using System;
using System.Linq;

public class RubiksMatrix
{
    public static void Main()
    {
        var rubikParams = Console.ReadLine()
            .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var numberOfCommands = int.Parse(Console.ReadLine());

        var rubic = new int[rubikParams[0]][];
        var counter = 1;

        for (int row = 0; row < rubic.GetLength(0); row++)
        {
            rubic[row] = new int[rubikParams[1]];

            for (int col = 0; col < rubic[row].Length; col++)
            {
                rubic[row][col] = counter++;
            }
        }

        for (int i = 0; i < numberOfCommands; i++)
        {
            var currentCommand = Console.ReadLine().Split().ToArray();

            var startIndex = int.Parse(currentCommand[0]);
            var direction = currentCommand[1];
            var moves = int.Parse(currentCommand[2]);

            switch (direction)
            {
                case "up":
                    MoveUp(rubic, startIndex, moves);
                    break;
                case "down":
                    MoveDown(rubic, startIndex, moves);
                    break;
                case "left":
                    MoveLeft(rubic, startIndex, moves);
                    break;
                case "right":
                    MoveRight(rubic, startIndex, moves);
                    break;
            }
        }

        int numberToCheck = 1;

        for (int row = 0; row < rubic.Length; row++)
        {
            for (int col = 0; col < rubic.Length; col++)
            {
                if (rubic[row][col] == numberToCheck)
                {
                    Console.WriteLine("No swap required");
                }
                else
                {
                    int swapRow = 0;
                    int swapCol = 0;

                    for (int r = row; r < rubic.Length; r++)
                    {
                        for (int c = 0; c < rubic.Length; c++)
                        {
                            if (rubic[r][c] == numberToCheck)
                            {
                                swapRow = r;
                                swapCol = c;
                                int tempElement = rubic[r][c];
                                rubic[r][c] = rubic[row][col];
                                rubic[row][col] = tempElement;
                            }
                        }
                    }

                    Console.WriteLine($"Swap ({row}, {col}) with ({swapRow}, {swapCol})");
                }

                numberToCheck++;
            }
        }
    }

    private static void MoveRight(int[][] rubic, int startIndex, int moves)
    {
        for (int iterations = 0; iterations < moves % rubic.Length; iterations++)
        {
            for (int col = rubic.Length - 1; col > 0; col--)
            {
                var temp = rubic[startIndex][col];
                var next = rubic[startIndex][col - 1];
                rubic[startIndex][col - 1] = temp;
                rubic[startIndex][col] = next;
            }
        }
    }

    private static void MoveLeft(int[][] rubic, int startIndex, int moves)
    {
        for (int iterations = 0; iterations < moves % rubic.Length; iterations++)
        {
            for (int col = 0; col < rubic.Length - 1; col++)
            {
                var temp = rubic[startIndex][col];
                rubic[startIndex][col] = rubic[startIndex][col + 1];
                rubic[startIndex][col + 1] = temp;
            }
        }
    }

    private static void MoveDown(int[][] rubic, int startIndex, int moves)
    {
        for (int iterations = 0; iterations < moves % rubic.Length; iterations++)
        {
            for (int row = rubic.Length - 1; row > 0; row--)
            {
                var temp = rubic[row][startIndex];
                rubic[row][startIndex] = rubic[row - 1][startIndex];
                rubic[row - 1][startIndex] = temp;
            }
        }
    }

    private static void MoveUp(int[][] rubik, int startIndex, int moves)
    {
        for (int iterations = 0; iterations < moves % rubik.Length; iterations++)
        {
            for (int row = 0; row < rubik.Length - 1; row++)
            {
                var temp = rubik[row][startIndex];
                rubik[row][startIndex] = rubik[row + 1][startIndex];
                rubik[row + 1][startIndex] = temp;
            }
        }
    }
}