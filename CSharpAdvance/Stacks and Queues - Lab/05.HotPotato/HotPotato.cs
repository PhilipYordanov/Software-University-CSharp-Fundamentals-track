using System;
using System.Collections.Generic;

public class HotPotato
{
    public static void Main()
    {
        var input = Console.ReadLine();
        var queue = new Queue<string>(input.Split(' '));
        var number = int.Parse(Console.ReadLine());

        while (queue.Count > 1)
        {
            for (int i = 0; i < number - 1; i++)
            {
                string remainder = queue.Dequeue();
                queue.Enqueue(remainder);
            }

            Console.WriteLine($"Removed {queue.Dequeue()}");
        }

        Console.WriteLine($"Last is {queue.Dequeue()}");
    }
}

