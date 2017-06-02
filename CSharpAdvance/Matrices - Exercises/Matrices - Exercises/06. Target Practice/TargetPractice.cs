using System;
using System.Collections.Generic;
using System.Linq;


class Problem2
{
    static void Main()
    {
        int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = dimensions[0];
        int m = dimensions[1];
        string snake = Console.ReadLine();

        char[,] stairs = new char[n, m];
        FillMatrix(stairs, snake, n, m);
        TakeAShot(stairs);
        FallingDown(stairs, n, m);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(stairs[i, j]);
            }
            Console.WriteLine();
        }

    }

    private static void FallingDown(char[,] stairs, int n, int m)
    {
        bool fallen = false;
        do
        {
            fallen = false;
            for (int row = 0; row < n - 1; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    if (stairs[row, col] != ' ' && stairs[row + 1, col] == ' ')
                    {
                        stairs[row + 1, col] = stairs[row, col];
                        stairs[row, col] = ' ';
                        fallen = true;
                    }
                }
            }
        } while (fallen);
    }

    private static void TakeAShot(char[,] stairs)
    {
        int[] shotParams = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int x = shotParams[0];
        int y = shotParams[1];
        int r = shotParams[2];
        for (int i = x - r; i <= x + r; i++)
        {
            for (int j = y - r; j <= y + r; j++)
            {
                try
                {
                    if (Math.Pow(x - i, 2) + Math.Pow(y - j, 2) <= r * r)
                    {
                        stairs[i, j] = ' ';
                    }
                }
                catch (Exception)
                {

                    continue;
                }
            }
        }
    }

    private static void FillMatrix(char[,] stairs, string snake, int n, int m)
    {
        int letter = 0;
        for (int i = n - 1; i >= 0; i--)
        {
            if ((n - 1 - i) % 2 == 0)
            {
                for (int j = m - 1; j >= 0; j--)
                {
                    stairs[i, j] = snake[letter % snake.Length];
                    letter++;
                }
            }
            else
            {
                for (int j = 0; j < m; j++)
                {
                    stairs[i, j] = snake[letter % snake.Length];
                    letter++;
                }
            }
        }
    }
}