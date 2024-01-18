using System;

namespace TryCatchAssignment
{
    class Program
    {
        //Assignment instructions:
        //Ask the user for their age.
        //Display the year the user was born.
        //Exceptions must be handled using “try/catch.”
        //Display appropriate error messages if the user enters zero or negative numbers.
        //Display a general message if an exception was caused by anything else.

        static void Main()
        {
            bool numValid = false; //we set the initial value of the numValid to false, it will change to true at the end of the try block
            while (!numValid) //while numValid is false
            {
                try
                {
                    Console.WriteLine("What is your age?"); //asks user to enter their age
                    int age = Convert.ToInt32(Console.ReadLine()); //saves user input an integer named age
                    if (age <= 0 || age > 130) //if age is a negative number, zero or bigger than 130
                    {
                        Console.WriteLine("Please enter a whole number that is between 1 and 130."); //display this message
                        numValid = false; //numValid is false = it is not a valid number
                    }
                    else //if age is a positive number and it's between 1-130, execute this code:
                    {
                        DateTime currentDateTime = DateTime.Now; //gets current date and time and saves it the currentDateTime variable
                        int currentYear = currentDateTime.Year;//gets only the year from the currentDateTime variable and saves it in the currentYear variable

                        int userBirthYear = currentYear - age; //subtracts user's age from the current year to get the user's year of birth
                        Console.WriteLine("You were born in {0}.", userBirthYear); //displays user's year of birth to the console
                        numValid = true; //numValid now becomes true and the while loop ends
                    }
                }//if the while loop is still running, as numValid is still false, the catch block will execute
                catch (FormatException) //This error message appears if the user enters something other than a number
                {
                    Console.WriteLine("Please only enter numbers!");
                }
                catch (Exception) //This is a general error message for another issue not stated above
                {
                    Console.WriteLine("Something went wrong. Please contact your system administrator.");
                }

                finally //The finally block runs no matter what and it typically has a database log
                {
                    Console.WriteLine("Thank you!");
                }
                Console.ReadLine(); //this line prevents the console window from closing automatically
            }
        }
    }
}
