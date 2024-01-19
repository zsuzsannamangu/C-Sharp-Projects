using System;
using System.IO; //this namespace is to use the file class so we can write to textfiles
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

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

            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | "); //we use Console.Write() so it's printed on the same line
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine(); //puts a new line here
                }
                Console.Read();
                return; //ends the loop if someone is actually putting admin in as a name
            }

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
                    catch (FraudException ex) //we start with specific exceptions, as exceptions are run in order
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex); //calls the method that updates the database with the error logs on FraudException
                        Console.ReadLine();
                        return; //return; in a void method ends the method
                    }
                    catch (Exception ex) //general exception, gives user a generic error message
                    {
                        Console.WriteLine("An error occured. Please contact your System Administrator.");
                        UpdateDbWithException(ex);
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

        private static void UpdateDbWithException(Exception ex) //ex is standard for exceptions
                                                                //all exceptions inherit from Exception
                                                                //void: it won't return anything, it will just update the dB
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TwentyOneGame;Integrated Security=True;
                                        Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                        MultiSubnetFailover=False"; //Connection String is located at dB Properties, copy paste the value here
            //writes a SQL query string:
            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES 
                                   (@ExceptionType, @ExceptionMessage, @TimeStamp)";
            //ExceptionType, ExceptionMessage, TimeStamp are the column names
            //We are using parameterized queries instead of actual values for safety --> @ExceptionType, @ExceptionMessage, @TimeStamp are placeholders.
            //ADO.NET will help us create parameters which will then map up the exact values and the placeholders will be substituted with those

            //creates a using statement to manage memory when we are dealing with external resources, like a connection to an external dB here
            //the using statement is wrapped in curly braces, so once we exit the last curly brace, it automatically shuts off that resource to free up memory
            using (SqlConnection connection = new SqlConnection(connectionString)) //creates a new instance of Sqlconnection
            {
                SqlCommand command = new SqlCommand(queryString, connection); //SqlCommand is the datatype
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);  //first we add the datatype "SqlDbType" to that specific placeholder, by naming its datatype we're protecting against SQL injection
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar); //Parameters is a list, we specify which item we are adding to
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                //we add to command the actual parameter values:
                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString(); //Value is a property of Parameters. We're grabbing the type of ex object with GetType(). GetType() returns a type so we convert it to string
                command.Parameters["@ExceptionMessage"].Value = ex.Message; //this is the exception message, it's already a string
                command.Parameters["@TimeStamp"].Value = DateTime.Now; //the value is the current date and time

                connection.Open(); //opens the SQL connection, connection to an external db            
                command.ExecuteNonQuery(); //executes the command, this is an insert statement = nonquery = because we're not querying the dB
                connection.Close(); //closes the connection

            }
        }

        private static List<ExceptionEntity> ReadExceptions() //returns a list of exception entities
                                                              //this method will query the dB and get back all the exceptions
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TwentyOneGame;Integrated Security=True;
                                        Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                        MultiSubnetFailover=False";

            string queryString = @"SELECT Id, ExceptionType, ExceptionMessage, TimeStamp From Exceptions"; //we query the dB

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString)) //creates a new instance of Sqlconnection
            {
                SqlCommand command = new SqlCommand(queryString, connection); //SqlCommand is the datatype
                connection.Open(); //opens the SQL connection, connection to an external db            

                SqlDataReader reader = command.ExecuteReader(); //creates a SqlDateReader object because we are only reading
                                                                //we are Executing a Reader, assigning it to the reader object

                while (reader.Read()) //reader.Read() loops through each record that you're getting back from the query
                                      //while reader object is open, do this:
                {
                    ExceptionEntity exception = new ExceptionEntity(); //for each record we need to create a new ExceptionEntity object
                    exception.Id = Convert.ToInt32(reader["Id"]); //maps what we are getting back from the query to our reader object
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception); //once the properties of our object is filled, it adds it to the Exceptions list
                }
                connection.Close(); //closes the connection
            }
            return Exceptions; //returns the list of exceptions


        }
    }
}
