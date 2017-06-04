using System;
using System.Collections.Generic;
using System.Linq;

public class RadioactiveBunnies
{
    public static void Main()
    {
        char[][] matrix;
        char[] commands;
        InputParams(out matrix, out commands);

        bool gameOver = false;
        var playerStatus = string.Empty;

        for (int currentCommand = 0; currentCommand < commands.Length; currentCommand++)
        {
            switch (commands[currentCommand])
            {
                case 'U':
                    MoveUp(matrix, ref gameOver, ref playerStatus);
                    playerStatus = MalkiteLaina(matrix, playerStatus);
                    break;
                case 'L':
                    MoveLeft(matrix, ref gameOver, ref playerStatus);
                    playerStatus = MalkiteLaina(matrix, playerStatus);
                    break;
                case 'R':
                    MoveRight(matrix, ref gameOver, ref playerStatus);
                    playerStatus = MalkiteLaina(matrix, playerStatus);
                    break;
                case 'D':
                    MoveDown(matrix, ref gameOver, ref playerStatus);
                    playerStatus = MalkiteLaina(matrix, playerStatus);
                    break;
            }

            if (playerStatus.Contains("dead"))
            {
                break;
            }
        }

        for (int row = 0; row < matrix.Length; row++)
        {
            for (int col = 0; col < matrix[row].Length; col++)
            {
                Console.Write($"{matrix[row][col]}");
            }

            Console.WriteLine();
        }

        Console.WriteLine($"{playerStatus}");
    }

    private static void InputParams(out char[][] matrix, out char[] commands)
    {
        var matrixParams = Console.ReadLine()
                    .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

        matrix = new char[matrixParams[0]][];
        for (int row = 0; row < matrix.Length; row++)
        {
            matrix[row] = Console.ReadLine()
            .ToCharArray();
        }

        commands = Console.ReadLine().ToCharArray();
    }

    private static string MalkiteLaina(char[][] matrix, string playerStatus)
    {
        var queue = new Queue<int[]>();

        for (int row = 0; row < matrix.Length; row++)
        {
            for (int col = 0; col < matrix[row].Length; col++)
            {
                if (matrix[row][col] == 'B')
                {
                    queue.Enqueue(new int[2] { row, col });
                }
            }
        }

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();
            var row = current[0];
            var col = current[1];
            try
            {
                if (matrix[row][col - 1] == 'P')
                {
                    if (playerStatus.Contains("dead"))
                    {
                    }
                    else
                    {
                        playerStatus = $"dead: {row - 1} {col}";
                    }
                }

                matrix[row][col - 1] = 'B';
            }
            catch (Exception)
            {
            }

            try
            {
                if (matrix[row][col + 1] == 'P')
                {
                    if (playerStatus.Contains("dead"))
                    {
                    }
                    else
                    {
                        playerStatus = $"dead: {row - 1} {col}";
                    }
                }

                matrix[row][col + 1] = 'B';
            }
            catch (Exception)
            {
            }

            try
            {
                if (matrix[row + 1][col] == 'P')
                {
                    if (playerStatus.Contains("dead"))
                    {
                    }
                    else
                    {
                        playerStatus = $"dead: {row - 1} {col}";
                    }
                }

                matrix[row + 1][col] = 'B';
            }
            catch (Exception)
            {
            }

            try
            {
                if (matrix[row - 1][col] == 'P')
                {
                    if (playerStatus.Contains("dead"))
                    {
                    }
                    else
                    {
                        playerStatus = $"dead: {row - 1} {col}";
                    }
                }

                matrix[row - 1][col] = 'B';
            }
            catch (Exception)
            {
            }
        }

        return playerStatus;
    }

    private static void MoveDown(char[][] matrix, ref bool gameOver, ref string playerStatus)
    {
        for (int row = matrix.Length - 1; row >= 0; row--)
        {
            for (int col = matrix[row].Length - 1; col >= 0; col--)
            {
                if (matrix[row][col] == 'P')
                {
                    try
                    {
                        if (matrix[row + 1][col] == '.')
                        {
                            matrix[row + 1][col] = 'P';
                            matrix[row][col] = '.';
                        }
                        else
                        {
                            gameOver = true;
                            playerStatus = $"dead: {row + 1} {col}";
                            break;
                        }
                    }
                    catch (Exception)
                    {
                        matrix[row][col] = '.';
                        gameOver = true;
                        playerStatus = $"won: {row} {col}";
                        break;
                    }
                }
            }
        }
    }

    private static void MoveRight(char[][] matrix, ref bool gameOver, ref string playerStatus)
    {
        for (int row = 0; row < matrix.Length; row++)
        {
            for (int col = matrix[row].Length - 1; col >= 0; col--)
            {
                if (matrix[row][col] == 'P')
                {
                    try
                    {
                        if (matrix[row][col + 1] == '.')
                        {
                            matrix[row][col + 1] = 'P';
                            matrix[row][col] = '.';
                        }
                        else
                        {
                            gameOver = true;
                            playerStatus = $"dead: {row} {col + 1}";
                            break;
                        }
                    }
                    catch (Exception)
                    {
                        matrix[row][col] = '.';
                        gameOver = true;
                        playerStatus = $"won: {row} {col}";
                        break;
                    }
                }
            }
        }
    }

    private static void MoveLeft(char[][] matrix, ref bool gameOver, ref string playerStatus)
    {
        for (int row = 0; row < matrix.Length; row++)
        {
            for (int col = 0; col < matrix[row].Length; col++)
            {
                if (matrix[row][col] == 'P')
                {
                    try
                    {
                        if (matrix[row][col - 1] == '.')
                        {
                            matrix[row][col - 1] = 'P';
                            matrix[row][col] = '.';
                        }
                        else
                        {
                            gameOver = true;
                            playerStatus = $"dead: {row} {col - 1}";
                            break;
                        }
                    }
                    catch (Exception)
                    {
                        matrix[row][col] = '.';
                        gameOver = true;
                        playerStatus = $"won: {row} {col}";
                        break;
                    }
                }
            }
        }
    }

    private static void MoveUp(char[][] matrix, ref bool gameOver, ref string playerStatus)
    {
        for (int row = 0; row < matrix.Length; row++)
        {
            for (int col = 0; col < matrix[row].Length; col++)
            {
                if (matrix[row][col] == 'P')
                {
                    try
                    {
                        if (matrix[row - 1][col] == '.')
                        {
                            matrix[row - 1][col] = 'P';
                            matrix[row][col] = '.';
                        }
                        else
                        {
                            gameOver = true;
                            playerStatus = $"dead: {row - 1} {col}";
                            break;
                        }
                    }
                    catch (Exception)
                    {
                        matrix[row][col] = '.';
                        gameOver = true;
                        playerStatus = $"won: {row} {col}";
                        break;
                    }
                }
            }
        }
    }
}