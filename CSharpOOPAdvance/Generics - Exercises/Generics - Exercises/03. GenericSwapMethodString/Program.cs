using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var listOfBoxes =new List<Box<int>>();

        for (int i = 0; i < n; i++)
        {
            var currentBox = new Box<int>(int.Parse(Console.ReadLine()));
            listOfBoxes.Add(currentBox);
        }

        var itemsToSwap = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        var first = itemsToSwap[0];
        var second = itemsToSwap[1];

        GenericSwapMethod(listOfBoxes, first, second);

        foreach (var box in listOfBoxes)
        {
            Console.WriteLine(box);
        }
    }

    private static void GenericSwapMethod<T>(List<Box<T>> listOfBoxes, int first, int second)
    {
        Box<T> firstBox = listOfBoxes[first];
        listOfBoxes[first] = listOfBoxes[second];
        listOfBoxes[second] = firstBox;
    }
}