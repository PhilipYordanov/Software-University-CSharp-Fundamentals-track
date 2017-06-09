using System;
using System.Collections.Generic;
using System.Linq;

public class StringMatrixRotation
{
    public static void Main()
    {
        var @params = Console.ReadLine()
            .Split(new[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

        var degrees = int.Parse(@params[1]);
        List<List<char>> matrix = InitializeMatrix();

        Rotate360(degrees, matrix);
        Rotate180(degrees, matrix);
        Rotate90(degrees, matrix);
        Rotate270(degrees, matrix);

    }

    private static List<List<char>> InitializeMatrix()
    {
        Queue<string> strings = new Queue<string>();

        string command;

        var max = 0;
        while ((command = Console.ReadLine()) != "END")
        {
            var len = command.Length;
            if (len > max)
            {
                max = len;
            }
            strings.Enqueue(command);
        }

        List<List<char>> matrix = new List<List<char>>();
        var current = new char[7];

        for (int row = 0; row < max; row++)
        {
            List<char> currentRow = new List<char>();
            if (strings.Count != 0)
            {
                current = strings.Dequeue().ToCharArray();
            }
            else
            {
                current = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
            }
            for (int col = 0; col < max; col++)
            {
                if (current.Length > col)
                {
                    currentRow.Add(current[col]);
                }
                else
                {
                    currentRow.Add(' ');
                }
            }
            matrix.Add(currentRow);
        }

        return matrix;
    }

    private static void Rotate270(int degrees, List<List<char>> matrix)
    {
        if (degrees % 360 == 270)
        {
            List<char> reversedCurrentRow = new List<char>();
            var reversedList = new List<List<char>>();
            for (int row = matrix.Count - 1; row >= 0; row--)
            {
                var currentChar = ' ';
                var currentRowList = new List<char>();
                for (int col = 0; col < matrix[row].Count; col++)
                {
                    currentChar = matrix[col][row];
                    currentRowList.Add(currentChar);
                    reversedCurrentRow = currentRowList.ToArray().Reverse().ToList();
                }
                reversedList.Add(reversedCurrentRow);
            }
            for (int index = 0; index < reversedList.Count; index++)
            {
                Console.WriteLine(string.Join("", reversedList[index].ToArray().Reverse()));
            }
        }
    }

    private static void Rotate90(int degrees, List<List<char>> matrix)
    {
        if (degrees % 360 == 90)
        {
            var reversedList = new List<List<char>>();

            for (int row = 0; row < matrix.Count; row++)
            {
                var currentChar = ' ';
                var currentRowList = new List<char>();
                for (int col = 0; col < matrix[row].Count; col++)
                {
                    currentChar = matrix[col][row];
                    currentRowList.Add(currentChar);
                }
                reversedList.Add(currentRowList);
                Console.WriteLine(string.Join("", reversedList[row].ToArray().Reverse()));
            }
        }
    }

    private static void Rotate180(int degrees, List<List<char>> matrix)
    {
        if (degrees % 360 == 180)
        {
            for (int row = matrix.Count - 1; row >= 0; row--)
            {
                var rowToReverse = matrix[row].ToArray().Reverse();
                Console.WriteLine(string.Join("", rowToReverse));
            }
        }
    }

    private static void Rotate360(int degrees, List<List<char>> matrix)
    {
        if (degrees % 360 == 0)
        {
            for (int row = 0; row < matrix.Count; row++)
            {
                Console.WriteLine(string.Join("", matrix[row]));
            }
        }
    }
}