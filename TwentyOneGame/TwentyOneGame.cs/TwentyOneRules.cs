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
        //it's private because it is only going to be accessed inside this class, the naming convention for private classes is to use an underscore
        //static, so we don't have to create a TwentyOneRules object to access this
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
            //we are instantiating this dictionary by creating dictionary entries of all the cards and their values, so we can quickly look up a value of a card and we can calculate the value of a hand
            //we know that we can add values to this dictionary and it is not going to change because the rules for this game are set
            //because of the possibility of duplicate values, we cannot use enums here, ex.: Jack and King are both equal to 10, and having duplicate values in an enum will cause a conflict

            [Face.Two] = 2, //Card Two has a value of 2...
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1 //Ace can be either 1 or 11 in the game of 21 and it's up to the player to decide that, but for now we'll assign it a value of 1
        };
        //We are checking whether Ace is 1 or 11 with GetAllPossibleHandValues() method:
        private static int[] GetAllPossibleHandValues(List<Card> Hand) //it returns an array of integers = all the possible values that it the hand has
        {
            int aceCount = Hand.Count(x => x.Face == Face.Ace); //checks how many aces there are in the hand, which can tell us the total value of the hand
                                                                //We are using a lambda expression here: we take each item which is in a list, and check whether
                                                                //the card's face is equal to Ace. It will return an integer "aceCount"
            int[] result = new int[aceCount + 1]; //result array has all the possible results of the aceCount
                                                  //when we create an array we have to say how big it is going to be in the []
                                                  //how many results there are is how many aces there are plus one
                                                  //ex: if you have two aces, there are 3 possible results = 11 + 1, 11 + 11, 1 + 1
            int value = Hand.Sum(x => _cardValues[x.Face]); //get the lowest possible value, which is when Ace = 1, which is its default value in the dictionary
                                                            //it takes each item and it looks up its value in the _cardValues dictionary, and it sums it
            result[0] = value; //we take the very first entry in our integer array "result" and we assign "value" to it
                               
            if (result.Length == 1) return result; //if there are no aces, there is only one possible value, since ace is the only card that can have more than one possible value
                                                   //in an if statement you don't have to use {} if you only have one line
            for (int i = 0; i < result.Length; i++) //we iterate through, putting in different values of Ace
            {
                value += (i * 10); //or value = value + (i * 10);
                                   //for each Ace, we have a separate value and add 10 to it
                result[i] = value;
            }
            return result;
        }
        
        public static bool CheckForBlackJack(List<Card> Hand) //this method will check whether the hand is Black Jack so it has a Jack/Queen/King and an Ace card
                                                              //it has one parameter, a list of cards
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand); //created an integer array of all possible values, we use the GetAllPossibleHandValues() method and we pass in the Hand
            int value = possibleValues.Max(); //we get the largest value
            if (value == 21) return true; //if that maximum value equals 21, then we return true = that player has blackjack
            else return false;
        }

        public static bool IsBusted(List<Card> Hand) //this method checks whether player is busted
        {
            int value = GetAllPossibleHandValues(Hand).Min(); //we are getting the value of the hand
                                                              //if the minimum value is busted, all values are busted, so we only care about the minimum not the maximum
            if (value > 21) return true;
            else return false;
        }

        public static bool ShouldDealerStay(List<Card> Hand) //we create a new method for the dealer as there are specific rules for the dealer that don't apply to players
        {
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);
            foreach (int value in possibleHandValues)
            {
                if (value > 16 && value < 22) //if value is more than 16 or less than 22, the dealer has to stay
                {
                    return true;
                }
            }
            return false;
        }

        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand) //it takes in two parameters, two lists of cards, the hand of the player and the hand of the dealer
        {
            int[] playerResults = GetAllPossibleHandValues(PlayerHand); //get all possible values for the player's hand
            int[] dealerResults = GetAllPossibleHandValues(DealerHand); //get all possible values for the dealer's hand

            int playerScore = playerResults.Where(x => x < 22).Max(); //we need to find the highest possible value, but it has to be less than 22 (over 21 is busting)
            int dealerScore = dealerResults.Where(x => x < 22).Max();

            if (playerScore > dealerScore) return true;
            else if (playerScore < dealerScore) return false;
            else return null; //bool? is a datatype that allows for a boolen to be nullable
        }
    }
}
