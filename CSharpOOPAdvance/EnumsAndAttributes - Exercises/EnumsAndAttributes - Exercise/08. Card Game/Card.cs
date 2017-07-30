using System;

public class Card : IComparable<Card>
{
    public Rank Rank { get; set; }
    public Suit Suit { get; set; }
    private int Power { get; }

    public Card(Rank rank, Suit suit)
    {
        this.Rank = rank;
        this.Suit = suit;
        this.Power = (int) this.Rank + (int) this.Suit;
    }

    public override string ToString()
    {
        return $"{this.Rank} of {this.Suit}";
    }

    public int CompareTo(Card other)
    {
        return this.Power.CompareTo(other.Power);
    }
}