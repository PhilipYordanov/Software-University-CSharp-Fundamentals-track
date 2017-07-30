using System;

public class StartUp
{
    public static void Main()
    {
        for (int i = 0; i < Enum.GetValues(typeof(Suit)).Length; i++)
        {
            for (int j = 0; j < Enum.GetValues(typeof(Rank)).Length; j++)
            {
                Console.WriteLine($"{(Rank)j} of {(Suit)i}");
            }
        }
    }
}