using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesAndObjects.cs
{
    public abstract class Game
    {
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public abstract void Play(); //an abstract method contains no implementation and can only exist inside of an abstract class
                                     //it states that any class inheriting this class must implement this method

        public virtual void ListPlayers () //void = doesn't return anything, just prints to the console
                                            //virtual means that this method gets inherited from an inheriting class but it has the ability to override it
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }
}
}
