using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame.cs
{
    public abstract class Game //bstract means that it is a template/base class that is used as a basis to create other classes, such as the TwentyOneGame here
                               //all classes inheriting from this class (because it's abstract) must have the same methods that Game has: Play() and ListPlayers() in this case
    {
        public List<Player> Players { get; set; } //we created 2 properties for the Game class: Players list and Name, it doesn't have a Dealer property because it varies with different games
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get; set; } //A dictionary is a key value pair, Player is the key and int is the value which is the Player's bet

        public abstract void Play(); //void methods don't have a return value
                                     //it is also an abstract method, which means that it is a base method
        public virtual void ListPlayers() //A virtual method is a method that can be overridden by a derived class to provide a different implementation of the same functionality.
                                          //You use the virtual keyword in the base class, and the override keyword in the derived class.
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
