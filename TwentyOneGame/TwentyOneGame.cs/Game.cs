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
        private List<Player> _players = new List<Player>(); //we have a list of players, and we want to make sure the list of players is never null, it is at least an instantiated empty list 

        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();
        public List<Player> Players { get { return _players; } set { _players = value; } } //if you want to get the list players, we return the private field of _players, and we set an underlying value
                                                                                           //the Players list will always be at least empty like this, because if it is null, there will be an error message
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } } //A dictionary is a key value pair, Player is the key and int is the value which is the Player's bet
                                                                                             //value represents whatever they are setting it as, it is a built-in thing to .NET

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
