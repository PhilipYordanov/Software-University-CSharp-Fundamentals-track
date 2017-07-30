using System;

public class Program
{
    public static void Main()
    {
        string rank = Console.ReadLine();
        string suit = Console.ReadLine();

        Object cardRank = Enum.Parse(typeof(Rank), rank);
        Object cardSuit = Enum.Parse(typeof(Suit), suit);

        var card = new Card((Rank)cardRank,(Suit)cardSuit);

        Console.WriteLine($"Card name: {card.Rank} of {card.Suit}; Card power: {(int)card.Rank + (int)card.Suit}");
    }
}