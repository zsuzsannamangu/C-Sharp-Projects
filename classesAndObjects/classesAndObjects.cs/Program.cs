using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesAndObjects.cs
{
    class Program
    {
        static void Main(string[] args) //void means it returns nothing, if you want it to return an integer, change to int
                                        //it takes a parameter which is here a string array called args
                                        //Methods have to be part of a class. If a method is being called without first creating an object of that class, it is marked static
        {
            //Card cardOne = new Card(); //we add an object of the Card class which is at Card.cs
            //cardOne.Face = "Queen"; //instead of this, we can create a constructor at Card.cs to assign default values to a class
            //cardOne.Suit = "Spades";
            //Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);
            //Console.ReadLine();

            //we create a deck of cards:
            Deck deck = new Deck(); //this is an empty object we created
                                    //Deck is the datatype and deck is the name of the variable
                                    //so we initiated an object called Deck and assigned it to the variable called deck
                                    //deck.Cards = new List<Card>(); 
                                    //the deck object has one property (see at Deck.cs) which is a list named Cards
                                    //to initiate this list we use the new keyword
                                    //List<Card> is the datatype
                                    //once we added the lists and foreach loops at Deck.cs, it should add all the 52 cards to the list Cards

            //to be able to see it, we need a foreach loop:

            deck = Shuffle(deck); //we are reassigning the value to this variable

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            //And now we can add cards to the property Cards which is a list, but for that we first need to create a card
            //deck.Cards.Add(cardOne); //so we added cardOne to the list, but instead adding one by one we create a constructor in Deck.cs

            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        //this is the method to shuffle the cards:
        //Deck is the type of the data that it's returning
        //Takes a parameter of the type Deck
        //Shuffle is the name of the method
        public static Deck Shuffle(Deck deck)
        {
            //create a temporary list to store our shuffled items:
            List<Card> TempList = new List<Card>();
            
            //C# has a class "Random" from the framework class library to use to create randomity
            Random random = new Random();

            while (deck.Cards.Count > 0) //grab a random card, take it out of the deck and put it into the temporary deck
            {
                int randomIndex = random.Next(0, deck.Cards.Count); //random.Next takes a minimum value of 0 and max of 52
                TempList.Add(deck.Cards[randomIndex]);//Then we add it to our Temp.List
                deck.Cards.RemoveAt(randomIndex); //RemoveAt is a function of the List method, delete it from the list of cards and we do that until there are no more cards left
            }
                //now we take the deck.Cards which is now empty and now we assign TempList to it as a value
                deck.Cards = TempList;
                return deck;
        }
    }
}
