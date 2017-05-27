using System;
using System.Collections.Generic;

public class HandsOfCards
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split(':');
        char[] cardSeparator = new char[] { ' ', ',' };

        var playerCards = new Dictionary<string, HashSet<string>>();

        while (input[0] != "JOKER")
        {
            string[] cards = input[1].Split(cardSeparator, StringSplitOptions.RemoveEmptyEntries);
            if (!playerCards.ContainsKey(input[0]))
            {
                var uniqueCards = new HashSet<string>();
                for (int i = 0; i < cards.Length; i++)
                {
                    uniqueCards.Add(cards[i]);
                }

                playerCards.Add(input[0], uniqueCards);
            }
            else
            {
                var uniqueCards = playerCards[input[0]];
                for (int i = 0; i < cards.Length; i++)
                {
                    uniqueCards.Add(cards[i]);
                }
            }

            input = Console.ReadLine().Split(':');
        }

        foreach (var item in playerCards)
        {
            Console.WriteLine($"{item.Key}: {SumCards(item.Value)}");
        }
    }

    public static int SumCards(HashSet<string> cards)
    {
        var cardValue = new Dictionary<string, int>()
        {
            { "2", 2 },
            { "3", 3 },
            { "4", 4 },
            { "5", 5 },
            { "6", 6 },
            { "7", 7 },
            { "8", 8 },
            { "9", 9 },
            { "10", 10 },
            { "J", 11 },
            { "Q", 12 },
            { "K", 13 },
            { "A", 14 }
        };
        var typeValue = new Dictionary<char, int>()
        {
            { 'S', 4 },
            { 'H', 3 },
            { 'D', 2 },
            { 'C', 1 }
        };
        int sum = 0;
        foreach (string card in cards)
        {
            if (card.StartsWith("10"))
            {
                sum = sum + (10 * typeValue[card[2]]);
            }
            else
            {
                var cardNumber = card[0].ToString();
                var cardType = card[1];
                sum = sum + (cardValue[cardNumber] * typeValue[cardType]);
            }
        }

        return sum;
    }
}