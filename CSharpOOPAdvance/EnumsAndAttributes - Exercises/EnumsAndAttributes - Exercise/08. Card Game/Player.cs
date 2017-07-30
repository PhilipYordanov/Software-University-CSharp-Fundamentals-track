using System.Collections.Generic;
using System.Linq;

public class Player
{
    public string Name { get; set; }

    public SortedSet<Card> Cards { get; set; }

    public Player(string name)
    {
        this.Name = name;
        this.Cards = new SortedSet<Card>();
    }

    public string Winner()
    {
        return $"{this.Name} wins with {this.Cards.Last()}.";
    }
}