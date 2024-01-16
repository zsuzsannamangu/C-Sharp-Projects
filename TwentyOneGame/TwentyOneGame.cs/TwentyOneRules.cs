using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame.cs
{
    public class TwentyOneRules //this is a separate class that exists without knowledge of other classes = "business logic layer"
                                //we are storing in this class a bunch of helper methods for our business logic
    {
        //creates a dictionary of card values
        //it's private because it is only going to be accessed inside this class, the naming convention with private classes is to use an underscore
        //static, so we don't have to create a TwentyOneRules object to access this
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
            //we are instantiating this dictionary with all of our objects
            //we know that we can add values to this dictionary and it is not going to change because the rules for this game are set
        };

    }
}
