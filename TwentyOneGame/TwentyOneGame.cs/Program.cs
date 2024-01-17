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

            Console.WriteLine("Welcome to the Grand Hotel and Casino! What is your name?");
            string playerName = Console.ReadLine();
            Console.WriteLine("How much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}! Would you like to join a 21 game right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank); //created a player object and we initialized them with their name and their initial balance
                                                              //to do that, we'll create a Player constructor in player.cs first
                Game game = new TwentyOneGame(); //here we created a game object
                game += player; //game = game + player, we are adding a player to the game
                player.isActivelyPlaying = true; //isActivelyPlaying is a property of Player in Player.cs
                                                   //we are setting that to true because the player is playing now
                while (player.isActivelyPlaying && player.Balance > 0) //as long as the player wants to keep playing and has enough money, the while loop will continue
                {
                    game.Play(); //we call the Play() method here
                }
                game -= player; //if while loop isn't continuing, we want to subtract player from the game
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now!"); //if they didn't answer yes to wanting to play, we display this message
            Console.Read(); //this line prevents the console window from closing automatically
        }
    }
}
