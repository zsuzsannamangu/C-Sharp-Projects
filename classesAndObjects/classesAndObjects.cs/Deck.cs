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
        public List<Card> Cards { get; set; } //Deck class has one property: Cards

        //I want the Deck method to act upon the object that it is attached to
        //If you have the keyword static for a method, you can call the method without applying it to the specific Deck you created
        //We can delete Deck deck parameter, bc we are operating on a Deck right now already
        public void Shuffle(int times = 1) //int times = 1 parameter is optional. When you assign a var a default value (here it's 1), you create an optional var
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();

                //C# has a class "Random" from the framework class library to use to create randomity
                Random random = new Random();

                while (Cards.Count > 0) //grab a random card, take it out of the deck and put it into the temporary deck
                {
                    int randomIndex = random.Next(0, Cards.Count); //random.Next takes a minimum value of 0 and max of 52
                    TempList.Add(Cards[randomIndex]);//Then we add it to our Temp.List
                    Cards.RemoveAt(randomIndex); //RemoveAt is a function of the List method, delete it from the list of cards and we do that until there are no more cards left
                }
                //now we take the deck.Cards which is now empty and now we assign TempList to it as a value
                //this.Cards = TempList; //this keyword is referring to itself, its own object, but not necessary
                Cards = TempList;
            }

            //return deck; no need to return anything, bc it is doing it already internally
        }
    }
}
