using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame.cs
{

    //In Blackjack, the player can ask for one or more cards (called a “hit”) until they either go over 21 (“bust”), or they think they have the
    //best possible hand. Once they have all the cards they need, they “stay” or “stand”;
    //meaning they signal to the dealer that they don’t want any more cards. Each subsequent player then decides whether to hit or stand.
    public class TwentyOneGame: Game, IWalkAway //TwentyOneGame inherits from the Game class, which is a base/abstract class
    {
        public TwentyOneDealer Dealer { get; set; } //it has a Dealer property, the dealer is specific to the 21 game that's why it is not in the Dealer class
        public override void Play() //Play() is abstract method in the Game class, which means we have to have an implementation of it here
        {
            Dealer = new TwentyOneDealer(); //we are instantiating a dealer = creating the dealer object
            //we reset the players who are at this game, because we are joining an already going game:
            foreach (Player player in Players) //"Players" is a property of the Game class, and it's a list of players
            {
                player.Hand = new List<Card>(); //we reset the players, we want their hand to be blank
                                                //Hand is a property of the Player class, it is a list of cards, the Player's hand
                player.Stay = false; //Stay is a property of the Player class, we set it to false, because player is now playing and not "staying" yet
            }
            Dealer.Hand = new List<Card>(); //we reset the dealer's hand as well
            Dealer.Stay = false;
            Dealer.Deck = new Deck(); //we want the deck to be a new deck
            Console.WriteLine("Place your bet!");

            foreach (Player player in Players) //loop through each player and have them place a bet
            {
                int bet = Convert.ToInt32(Console.ReadLine()); //we'll have a message on the screen where the user will enter their bet
                bool successfullyBet = player.Bet(bet); //refers to the Bet() method in the Player class, the player is doing the betting, so we should keep that method there
                                                        //we pass in the amount they enter (bet variable) into the Bet() method
                if (!successfullyBet) //= if (successfullyBet == false)
                {
                    return; //return; just means: end this method. We're in a void method and we're still not returning anything
                            //once this method is over, it will go back to the while loop in the Main() method,
                            //and if conditions are met, it will hit the Play() method in the TwentyOneGame class and ask to place a bet again
                }
                //if the bet succeeds:
                //to track bets, the best datatype is a dictionary, a collection of key value pairs, the key is the player and the value is what they bet
                //we create a dictionary object of all the bets, so when we need to pay everyone, we look up the player's name in the dictionary and their amount
                //we create this dictionary in the Game class, because probably all games are going to have bets
                Bets[player] = bet; //added the player's entry of amount/bet to the dictionary along with their name
            }
            //we give everyone a card, then the dealer a card, then everyone gets another card, then the dealer gets another card, so everyone will have two cards:
            //so we loop through the players and give them a card and we will do that twice
            for (int i = 0; i < 2; i++) //i < 2 because we are doing this twice
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)
                {
                    Console.Write("{0}: ", player.Name); //Console.Write writes something to the console, but then don't automatically press enter
                    Dealer.Deal(player.Hand); //we are passing in the player's hand and it's given a card and that card is printed on the console (see the Dealer class's Deal() method)
                    //if you have an Ace and a face card (J, K or Q), you automatically win in Blackjack, so we have to check for this after the first deal:
                    //create the TwentyOneRules class first
                    if (i == 1)
                    {

                    }
                }
            }
        }
        public override ListPlayers() //this method is from Game.cs where ListPlayers() is a base method
                                      //we use the override keyword here to create a different implementation of the ListPlayers() method with the same functionality
        {
            Console.WriteLine("21 Players:");
            base.ListPlayers();
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }

    }
}
