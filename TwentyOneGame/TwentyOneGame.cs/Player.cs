using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame.cs
{
    public class Player
    {

        //Creates a constructor. Constructors always go on the top of the class and have the same name as the class
        //Constructor is a method that is used initialize objects and set default values for fields. They don't have a return type.
        //A constructor is called when an object of a class is created.
        public Player (string name, int beginningBalance) //this constructor takes 2 parameters and it's going to assign some values
        {
            Hand = new List<Card>(); //we are creating an empty list with type Card, then we need to initialize this list to be able to add things to it
            Balance = beginningBalance; //we are taking the two arguments of the constructor "Player" and we are assigning them to properties of this object
            Name = name;

        }
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }

        public bool Bet(int amount) //it returns a boolean because in this logic we also check whether the player even has that amount
                                    //Bet() has one parameter: amount => the player enters the amount they are betting
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You don't have enough to place a bet that size");
                return false; //so the bet failed
            }
            else
            {
                Balance -= amount; //or Balance = Balance - amount;
                return true;
            }
        }

        public static Game operator +(Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }
            
        public static Game operator -(Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
