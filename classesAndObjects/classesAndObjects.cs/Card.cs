using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesAndObjects.cs
{
    public class Card
    {
        public Card() //this is a constructor which has the same name as the class. A constructor's value is assigned upon creation
        {
            Suit = "Spades"; //these are the default values
            Face = "Two";
        }
        public string Suit { get; set; } //Public means that it's accessible to all parts of the program. Suit is the name with string datatype.
                                         //Suit is a property of the card class
                                         // get; set; are the 2 only two things you can do with an object property - you can get or set this property
        public string Face { get; set; }
    }
    
}
