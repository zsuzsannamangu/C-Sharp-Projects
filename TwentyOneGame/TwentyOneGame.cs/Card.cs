using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame.cs
{
    public struct Card //struct (short for structure) is like a class but it is for storing related information of various datatypes = represents a record
    {
        public Suit Suit { get; set; }
        public Face Face { get; set; }
        public override string ToString() //The ToString() method is a built-in method that returns a string, we are going to override it
        {
            return string.Format("{0} of {1}", Face, Suit); //It will print to the console for example: King of Hearts...
        }
    }

    public enum Suit //enum is a class that represents a group of constants, the elements won't change
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
