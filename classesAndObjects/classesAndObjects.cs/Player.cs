using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesAndObjects.cs
{
    class Player
    {
        public List<Card> Hand { get; set; } //it is the player's cards
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }

        public static Game operator+ (Game game, Player player)
        //Game is the return type
        //we're adding a player here
        //we're overloading the operator plus, it's taking two operands, a game and a player and its returning a game
        {
            game.Players.Add(player); //it takes the game, it adds a player to it and then returns the game
            return game;
        }
        //subtract overload operator:
        public static Game operator- (Game game, Player player)
        {
            game.Players.Remove(player); //it takes the game, it removes a player from it and then returns the game
            return game;
        }
    }
}
