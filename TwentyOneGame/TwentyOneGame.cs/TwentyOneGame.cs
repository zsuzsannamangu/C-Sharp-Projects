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
    public class TwentyOneGame: Game //TwentyOneGame inherits from the Game class, which is a base/abstract class
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
            Dealer.Deck.Shuffle(); //we shuffle the deck
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
                    if (i == 1) //now we are on the second round
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand); //we check if the player's hand has blackjack
                        if (blackJack)
                        {
                            Console.WriteLine("Blackjack! {0}  wins {1}", player.Name, Bets[player]); //we are grabbing the player's name and their bet from the Bets table in the Game class
                                                                                                      //we grab the value of the bet by using the Bets' key
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]); //we add the amount to the Balance (in Blackjack you win 1.5 times)
                                                                                                    //we remove the original bet from the player's balance when they place the bet, so we have to give that back + the bet * 1.5
                            //Bets.Remove(player); //we remove them from the Bets' table
                            return; //we end the round here  
                        }
                    }
                }
                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand); //we are dealing the dealer's hand
                if (i == 1) //we are on the second round of dealing cards to the dealer
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand); //we check whether the dealer has Blackjack
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has blackjack. Everyone looses.");
                        //we have to give the dealer all those bets:
                        foreach (KeyValuePair<Player, int> entry in Bets) //we iterate through the dictionary
                        {
                            Dealer.Balance += entry.Value;
                        }
                        return;
                    }
                }
            }
            foreach (Player player in Players) //we ask each player whether they want to hit or stay
            {
                while (!player.Stay) //if they don't want to stay, so they want to keep playing:
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.Write("{0}", card.ToString()); //we show the player their cards formatted with the ToString() method that we overrode in the Card class
                    }
                    Console.WriteLine("\n\nHit or stay?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break; //break the loop
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand); //we deal them a card
                    }
                    //every time we deal them a new card we need to check whether they busted
                    bool busted = TwentyOneRules.IsBusted(player.Hand); //we use the IsBusted() method that is implemented in the TwentyOneRules class
                    if (busted)
                    {
                        Dealer.Balance += Bets[player]; //if they busted, we give the dealer that money, we access that amount through the Bets table, a property of the Game class
                        Console.WriteLine("{0} Busted! You lose your bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "yeah")
                        {
                            player.isActivelyPlaying = true;
                            return; //return ends the void function
                        }
                        else
                        {
                            player.isActivelyPlaying = false; //Play() is only happening while isActivelyPlaying is true as said in Main()
                            return;
                        }
                    }
                }
            }
            //now we need to ask the dealer
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            while (!Dealer.Stay && !Dealer.isBusted) //as long as the dealer is not busted and is staying, let's continue to give them cards
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);//we deal them a card
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);//check it again whether dealer is busted, if true, while loop breaks
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);//check it again whether dealer is staying
            }
            if (Dealer.Stay) //if dealer is staying
            {
                Console.WriteLine("Dealer is staying.");
            }
            if (Dealer.isBusted) //if dealer is busted
            {
                Console.WriteLine("Dealer Busted.");
                foreach (KeyValuePair<Player, int> entry in Bets) //we need to give all players their winnings, for everyone of those key value pairs, write:
                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value); //we access the Bets dictionary with entry. and we write to the console who won what
                    //then we actually have to give that money to that player's balance:
                    //we first get the list of Players inside of this game where their name equals the name in the dictionary, where always produces a list, but there will be only one person in the list
                    //then we grab the First(), the only one, and we get the Balance of that person, and we add that to what they bet (=entry.Value), times 2
                    //it's because we took their bet out of their balance in the beginning, so now we give that back plus their winnings
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2); //this is a lambda expression
                    Dealer.Balance -= entry.Value; //we take that amount out of the dealer's balance
                }
                return; //return ends the round
            }
            //if noone busts and everyone stays, we want to compare the player's hand with the dealer's hand, the highest amount wins or there could be a tie
            foreach (Player player in Players) //we loop through the players
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand); //booleans cannot be null, but if you use "bool?" datatype, you make a boolean be able to have a null value
                if (playerWon == null) //it's a tie
                {
                    Console.WriteLine("Push! Noone wins.");
                    player.Balance += Bets[player]; //we give the players their money back
                }
                else if (playerWon == true) //player won
                {
                    Console.WriteLine("{0} won {1}", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2); //adjusts the balance of the player, their original bet * 2
                    Dealer.Balance -= Bets[player]; //dealer looses player's money
                }
                else //dealer won
                {
                    Console.WriteLine("Dealer wins!");
                    Dealer.Balance += Bets[player]; //dealer won player's money and that's added to dealer's balance
                }
                Console.WriteLine("Play again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah")
                {
                    player.isActivelyPlaying = true;
                }
                else
                {
                    player.isActivelyPlaying = false;
                }
            }
        }
        public override void ListPlayers() //this method is from Game.cs where ListPlayers() is a base method
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
