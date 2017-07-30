using System;
//using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        //var cards = new SortedSet<Card>();

        //string firstRank = Console.ReadLine();
        //string firstSuid = Console.ReadLine();
        //Object firstCardRank = Enum.Parse(typeof(Rank), firstRank);
        //Object firstCardSuit = Enum.Parse(typeof(Suit), firstSuid);
        //var firstCard = new Card((Rank)firstCardRank, (Suit)firstCardSuit);


        //string secondRank = Console.ReadLine();
        //string secondSuit = Console.ReadLine();
        //Object secondCardRank = Enum.Parse(typeof(Rank), secondRank);
        //Object secondCardSuit = Enum.Parse(typeof(Suit), secondSuit);
        //var secondCard = new Card((Rank)secondCardRank, (Suit)secondCardSuit);

        //cards.Add(secondCard);
        //cards.Add(firstCard);
        //Console.WriteLine(cards.Last());

        //var enumType = Console.ReadLine();

        Console.WriteLine(Type.GetType(Console.ReadLine()).GetCustomAttributes(false).FirstOrDefault().ToString());
    }
}