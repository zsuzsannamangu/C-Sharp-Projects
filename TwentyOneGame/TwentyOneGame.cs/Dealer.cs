using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame.cs
{
    public class Dealer
    {
        public string Name { get; set; } //The Dealer class has 3 properties: Name, Deck, Balance
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand) //void methods don't have a return value
                                          //inside of the Deal() method we are writing what we are dealing
        {
            Hand.Add(Deck.Cards.First());
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");
            Deck.Cards.RemoveAt(0);
        }
    }
}
