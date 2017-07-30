using System;

public class Program
{
    public static void Main()
    {
        var input = Console.ReadLine();

        Console.WriteLine("Card Suits:");
        if (input == "Card Suits")
        {
            foreach (CardDeck card in Enum.GetValues(typeof(CardDeck)))
            {
                Console.WriteLine($"Ordinal value: {(int)card}; Name value: {card}");
            }
        }
    }
}