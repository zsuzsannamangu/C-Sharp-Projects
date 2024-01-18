using System;
using System.IO; //this namespace is to use the file class so we can write to textfiles
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "Here is some text.";
            //File.WriteAllText(@"C:\Users\zsuzsi\Documents\Logs\log.txt", text); //if the log.txt doesn't exist, it will create
            //we are writing the text to the log.txt file
            //WriteAllText takes one parameter, which is the filepath
            //@ means write this string exactly as is without escape characters, if you actually want escape characters use \\
            //read back the file we just wrote:
            //string text = File.ReadAllText(@"C:\Users\zsuzsi\Documents\Logs\log.txt");

            const string casinoName = "Grand Hotel and Casino"; //declares a constant variable as we know the name of the casino won't change
            Console.WriteLine("Welcome to the {0}! What is your name?", casinoName);
            string playerName = Console.ReadLine();

            bool validAnswer = false;
            int bank = 0; //sets the initial value of bank to zero
            while (!validAnswer) //while validAnswer is false
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank); //same as Int32.TryParse(). TryParse() is a method, it takes a string in (Console.ReadLine() here)
                                                                          //and it has an out parameter, it's assigning a value to this result and it's sending it out back to int bank
                                                                          //TryParse() returns true if it was converted successfully from string to ints, otherwise it returns false
                if (!validAnswer) //if validAnswer is false, show this message:
                {
                    Console.WriteLine("Please enter digits only, no decimals.");
                }
            }
            Console.WriteLine("Hello, {0}! Would you like to join a 21 game right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank); //created a player object and we initialized them with their name and their initial balance
                                                              //to do that, we'll create a Player constructor in player.cs first
                player.Id = Guid.NewGuid(); //we create a guid = a Global Unique IDentifier for each player, so players can be tracked with their unique ID
                using (StreamWriter file = new StreamWriter(@"C:\Users\zsuzsi\Documents\logs\log.txt", true)) //we'll be logging each user and write them onto log.txt
                {
                    file.WriteLine(player.Id); //adds the player's Id to the log
                }
                Game game = new TwentyOneGame(); //here we created a game object
                game += player; //game = game + player, we are adding a player to the game
                player.isActivelyPlaying = true; //isActivelyPlaying is a property of Player in Player.cs
                                                   //we are setting that to true because the player is playing now
                while (player.isActivelyPlaying && player.Balance > 0) //as long as the player wants to keep playing and has enough money, the while loop will continue
                {
                    try //we wrap our Play() method in a try catch, so if it catches any exceptions that happen in the main method Play(), it will handle that
                    {
                        game.Play(); //we call the Play() method here
                    }
                    catch (FraudException) //we start with specific exceptions, as exceptions are run in order
                    {
                        Console.WriteLine("Security! Kick this person out!");
                        Console.ReadLine();
                        return; //return; in a void method ends the method
                    }
                    catch (Exception) //general exception, gives user a generic error message
                    {
                        Console.WriteLine("An error occured. Please contact your System Administrator.");
                        Console.ReadLine();
                        return; //return; in a void method ends the method
                    }

                    
                }
                game -= player; //if while loop isn't continuing, we want to subtract player from the game
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now!"); //if they didn't answer yes to wanting to play, we display this message
            Console.Read(); //this line prevents the console window from closing automatically
        }
    }
}
