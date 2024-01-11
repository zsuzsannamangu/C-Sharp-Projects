using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesAndObjects.cs
{
    public class Game
    {
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public void ListPlayers () //void = doesn't return anything, just prints to the console
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }
}
}
