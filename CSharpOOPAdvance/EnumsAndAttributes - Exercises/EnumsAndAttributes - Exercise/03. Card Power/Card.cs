public class Card
{
    public Rank Rank { get; set; }
    public Suit Suit { get; set; }

    public Card(Rank rank, Suit suit)
    {
        this.Rank = rank;
        this.Suit = suit;
    }
}