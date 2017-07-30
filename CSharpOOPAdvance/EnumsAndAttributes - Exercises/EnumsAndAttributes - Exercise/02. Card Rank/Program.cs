using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Card Ranks:");
        foreach (CardDeck card in Enum.GetValues(typeof(CardDeck)))
        {
            Console.WriteLine($"Ordinal value: {(int)card}; Name value: {card}");
        }
    }
}