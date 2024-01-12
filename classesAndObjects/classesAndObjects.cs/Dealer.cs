using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesAndObjects.cs
{
    class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand) //its input parameter is a list of cards = a hand and in this method it's going to add a card to that hand
        {
            Hand.Add(Deck.Cards.First()); //First() is a method that is available to a list and it takes the first item of that list
                                            //So we grab that first card and add it to the hand which is passed into Deal
            Console.WriteLine(Deck.Cards.First().ToString() + "\n"); //and then we print on the console which card was added the list
            Deck.Cards.RemoveAt(0); //now we remove it from the deck. RemoveAt() is also a built-in method of a list. You pass in the index of where you want to remove
        
            //but why don't have the Dealer class inherit from the Deck class as opposed to adding Deck as a property here, so we would have access to everything Deck has
            //reason: the Dealer has a deck, a Dealer is not a type of deck, so you won't inheret from it as opposed to the 21 game
            //so ask is it a "has a" or "is a" relationship?
        }
    }
}
