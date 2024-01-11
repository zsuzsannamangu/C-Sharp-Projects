using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesAndObjects.cs
{
    public class Deck
    {
        //Constructors always go before properties, at the top of the class
        public Deck() //this is a constructor, which is a method that's called as soon as an object is created
        {
            Cards = new List<Card>(); //first thing the constructor does is it instantiates its property "Cards" as an empty list of Card
            
            //then two more lists are created and immediately instantiates it with values:

            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" }; //4 items
            List<string> Faces = new List<string>() { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };// 13 items
            
            //13x4 is 52, which is the total amount of cards in the deck

            //create a nested foreach loop
            //loops thru both lists to generate a deck of 52 cards

            //so for each of these items in the Faces list, we loop through 4 times
            

            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card(); //during each loop we create a card
                    card.Suit = suit;  //and then we assign the Suit property the value of suit, which will be Clubs first, then Hearts etc
                    card.Face = face; //and then we assign the Face the face
                    Cards.Add(card); //and then we add that new card that we created into our cards list above (Cards = new List<Card>())

                    //the variable card (with small c) only exists inside the foreach loop, so once the loop ends, that var doesn't exist anymore
                }
            }
        }
        public List<Card> Cards { get; set; }
    }
}
