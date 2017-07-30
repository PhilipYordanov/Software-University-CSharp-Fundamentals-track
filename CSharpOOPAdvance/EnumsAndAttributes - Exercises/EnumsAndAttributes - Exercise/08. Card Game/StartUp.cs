using _08.Card_Game;
using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var deck = Deck.GenerateDeck();

        var firstPlayer = new Player(Console.ReadLine());
        var secondPlayer = new Player(Console.ReadLine());

        while (firstPlayer.Cards.Count != 5)
        {
            var currentCardTokens = GetCurrentCardTokens();

            if (IsValidCard(currentCardTokens))
            {
                var currentCard = CardCreator(currentCardTokens);
                if (DeckChecker(deck, currentCardTokens))
                {
                    firstPlayer.Cards.Add(currentCard);
                    deck = DeckRemover(deck, currentCardTokens);
                }
                else
                {
                    Console.WriteLine("Card is not in the deck.");
                }
            }
            else
            {
                Console.WriteLine("No such card exists.");
            }
        }

        while (secondPlayer.Cards.Count != 5)
        {
            var currentCardTokens = GetCurrentCardTokens();

            if (IsValidCard(currentCardTokens))
            {
                var currentCard = CardCreator(currentCardTokens);
                if (DeckChecker(deck, currentCardTokens))
                {
                    secondPlayer.Cards.Add(currentCard);
                    deck = DeckRemover(deck, currentCardTokens);
                }
                else
                {
                    Console.WriteLine("Card is not in the deck.");
                }
            }
            else
            {
                Console.WriteLine("No such card exists.");
            }
        }
        var winner = firstPlayer.Cards.Last().CompareTo(secondPlayer.Cards.Last());
        Console.WriteLine(winner == 1 ? firstPlayer.Winner() : secondPlayer.Winner());
    }

    private static List<Card> DeckRemover(List<Card> deck, string[] currentCardTokens)
    {
        deck = deck.Where(x => !(x.Rank == RankParser(currentCardTokens) && x.Suit == SuitParser(currentCardTokens))).ToList();
        return deck;
    }

    private static bool DeckChecker(List<Card> deck, string[] currentCardTokens)
    {
        return deck.Exists(x => x.Rank == RankParser(currentCardTokens) && x.Suit == SuitParser(currentCardTokens));
    }

    private static Card CardCreator(string[] currentCardTokens)
    {
        return new Card(RankParser(currentCardTokens), SuitParser(currentCardTokens));
    }

    private static Suit SuitParser(string[] currentCardTokens)
    {
        return (Suit)Enum.Parse(typeof(Suit), currentCardTokens[1]);
    }

    private static Rank RankParser(string[] currentCardTokens)
    {
        return (Rank)Enum.Parse(typeof(Rank), currentCardTokens[0]);
    }

    private static bool IsValidCard(string[] currentCardTokens)
    {
        return Enum.IsDefined(typeof(Rank), currentCardTokens[0]) && Enum.IsDefined(typeof(Suit), currentCardTokens[1]);
    }

    private static string[] GetCurrentCardTokens()
    {
        return Console.ReadLine().Split(new string[] { " of " }, StringSplitOptions.RemoveEmptyEntries);
    }
}