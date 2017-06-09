using System;
using System.Linq;
using System.Collections.Generic;

namespace hackerRankk
{
    class Program
    {
        static void Main()
        {
            var size = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var dict = new Dictionary<int, HashSet<int>>();
            for (int row = 0; row < size[0]; row++)
            {
                dict.Add(row, new HashSet<int>());
            }
            var line = Console.ReadLine();
            while (line != "stop")
            {
                var input = line
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int enterRow = input[0];
                int enterCol = 0;
                int parkRow = input[1];
                int parkCol = input[2];
                bool parked = false;
                if (dict.ContainsKey(parkRow))
                {
                    if ((!dict[parkRow].Contains(parkCol)))
                    {
                        dict[parkRow].Add(parkCol);
                        parked = true;
                    }
                    else if (dict[parkRow].Contains(parkCol))
                    {
                        for (int i = 1; i < size[1]; i++)
                        {
                            if (parkCol - i > 0)
                            {
                                if (!dict[parkRow].Contains(parkCol - i))
                                {
                                    parkCol -= i;
                                    dict[parkRow].Add(parkCol);
                                    parked = true;
                                    break;
                                }
                            }
                            if (parkCol + i < size[1])
                            {
                                if (!dict[parkRow].Contains(parkCol + i))
                                {
                                    parkCol += i;
                                    dict[parkRow].Add(parkCol);
                                    parked = true;
                                    break;
                                }
                            }
                        }
                    }
                }
                if (!parked)
                {
                    Console.WriteLine($"Row {parkRow} full");
                }
                else
                {
                    int sum = Math.Abs(parkCol - enterCol) + Math.Abs(parkRow - enterRow);
                    Console.WriteLine(sum + 1);
                }
                line = Console.ReadLine();
            }
        }
    }
}