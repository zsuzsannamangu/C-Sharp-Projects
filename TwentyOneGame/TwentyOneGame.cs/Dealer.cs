using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame.cs
{
    public class Dealer
    {
        public string Name { get; set; } //The Dealer class has 3 properties: Name, Deck, Balance
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        //put a timestamp into each log entry

        public void Deal(List<Card> Hand) //void methods don't have a return value
                                          //inside of the Deal() method we are writing what we are dealing
        {
            Hand.Add(Deck.Cards.First()); //we are adding a card to the hand
            string card = String.Format(Deck.Cards.First().ToString() + "\n"); //every time a card is dealt, we log that into our log file
            Console.WriteLine(card);
            using (StreamWriter file = new StreamWriter(@"C:\Users\zsuzsi\Documents\logs\log.txt", true)) //we're dealing with unmanaged code, so everything should be disposed off to clean memory
            {                                                                                             //"true" means that yes, I want to append to log.txt, as opposed to creating a new file = then write false
                file.WriteLine(DateTime.Now); //puts a timestamp into each log entry
                                              //"Now" is a property that gives the exact DateTime object of this moment, so a timestamp of when something happened
                file.WriteLine(card); //file here refers to file in the using statement
                                      //card = we want to write whatever is inside the card variable, more specifically inside Format() to the file, so every card that is dealt to the player and the dealer
            }//once this line is hit it will be all cleaned up by the memory manager
            Console.WriteLine(Deck.Cards.First().ToString() + "\n"); //and then we write to the console which card that was
            Deck.Cards.RemoveAt(0);
        }
    }
}
