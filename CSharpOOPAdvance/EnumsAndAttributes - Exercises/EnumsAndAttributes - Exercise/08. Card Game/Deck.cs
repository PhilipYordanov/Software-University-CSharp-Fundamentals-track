using System.Collections.Generic;

namespace _08.Card_Game
{
    public static class Deck
    {
        private static List<Card> CardDeck = new List<Card>();
        private static Card Card;

        public static List<Card> GenerateDeck()
        {
            foreach (var rank in typeof(Rank).GetEnumValues())
            {
                foreach (var suit in typeof(Suit).GetEnumValues())
                {
                    Card = new Card((Rank)rank, (Suit)suit);
                    CardDeck.Add(Card);
                }
            }
            return CardDeck;
        }
    }
}
