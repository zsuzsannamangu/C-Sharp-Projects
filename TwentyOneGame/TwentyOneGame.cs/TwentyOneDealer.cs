using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame.cs
{
    public class TwentyOneDealer : Dealer //TwentyOneDealer class inherits from Dealer class
    {
        //a 21 dealer also has a hand like the player:
        public List<Card> Hand {get; set;}
        public bool Stay { get; set; }
        //in 21 game, you get a certain amount of cards and if you feel like you are close enough to having 21 cards, then you can stay (don't ask for more cards)
        //because you don't want to risk taking another card and going over 21, because then you bust (you automatically loose the game):
        public bool isBusted { get; set; }
    }
}
