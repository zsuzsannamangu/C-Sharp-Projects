using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame.cs
{
    public class Deck
    {
        public Deck() //this is a constructor, which is a method that's called as soon as an object is created. Constructors always go before properties, at the top of the class and have the same name as the class.
        {
            Cards = new List<Card>(); //first thing the constructor does is that it instantiates its property "Cards" as an empty list of Cards

            //we are creating a nested for loop, it loops through both lists to generate a deck of 52 cards (13 x 4 = 52):
            for (int i = 0; i < 13; i++) //there are 13 faces: "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            {
                for (int j = 0; j < 4; j++) //there are 4 suits: "Clubs", "Hearts", "Diamonds", "Spades"; for each of these items in the Faces list, we loop through 4 times
                {
                    Card card = new Card(); //creates Card object
                    card.Face = (Face)i; //Face should be the Face at i
                    card.Suit = (Suit)j; //Suit should be the Suit at j
                    Cards.Add(card); //adds card to the pile of cards
                }
            }
        }
        private List<Card> _cards = new List<Card>(); //creates private property _cards
        public List<Card> Cards { get { return _cards; } set { _cards = value; } } //Deck class has one property: Cards which is a public list
        public void Shuffle(int times = 1) //int times = 1 parameter is optional. When you assign a var a default value (here it's 1), you create an optional variable
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();

                //C# has a class "Random" from the framework class library to create randomity
                Random random = new Random();

                while (Cards.Count > 0) //grabs a random card, takes it out of the deck and puts it into the temporary deck named TempList
                {
                    int randomIndex = random.Next(0, Cards.Count); //random.Next takes a minimum value of 0 and maximum of 52 = Cards.Count
                    TempList.Add(Cards[randomIndex]);//Then we add it to our Temp.List
                    Cards.RemoveAt(randomIndex); //RemoveAt is a function of the List method, deletes it from the list of cards and we do that until there are no more cards left
                }
                //now we take the Deck.Cards which is now empty and we assign TempList to it as a value:
                //this.Cards = TempList; //this keyword is referring to itself, its own object, but can be omitted:
                Cards = TempList;
            }
        }
    }
}
