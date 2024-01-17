using System;

namespace DateTimeAssignment.cs
{
    //Assignment instructions:
    //Print the current date and time to the console.
    //Ask the user for a number.
    //Print to the console the exact time it will be in X hours, X being the number the user entered.

    class Program
    {
        static void Main()
        {
            bool numValid = false; //Sets numValid variable to false, it will change to True at the end of the try block
            while (!numValid) //while the number entered is valid, the try block will run, otherwise the catch block will run
            {
                try
                {
                    DateTime currentDateTime = DateTime.Now; //using DateTime.Now we get the current date and time, and save it in the currentDateTime variable which has a DateTime datatype
                    Console.WriteLine(currentDateTime); //prints the current date and time to the console

                    Console.WriteLine("Enter a number: "); //prompts user to enter a number
                    int userInput = Convert.ToInt32(Console.ReadLine()); //converts user input into integer and saves it in the userInput variable

                    DateTime newDateTime = currentDateTime.AddHours(userInput); //creates a new DateTime variable, adds the userInput to the hours of the current date and time
                    Console.WriteLine("In {0} hours, the date and time will be {1}.", userInput, newDateTime); //prints new date and time to the console

                    Console.ReadLine(); //this line prevents the console window from closing immediately
                    numValid = true;
                }
                catch (FormatException ex) //This error message appears if the user enters something other than a number
                {
                    Console.WriteLine("Please enter a whole number!");
                }

                catch (Exception ex) //This is a general error message for another issue not stated above
                {
                    Console.WriteLine(ex.Message);
                }

                finally //The finally block runs no matter what and it typically has a database log
                {
                    Console.WriteLine("Thank you!");
                }
                Console.ReadLine();
            }
        }
    }
}
