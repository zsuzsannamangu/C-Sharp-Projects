using System;

namespace @enum.cs
{
    public class Program
    {
        //Instructions for the assignment:
        //Create an enum for the days of the week.
        //Prompt the user to enter the current day of the week.
        //Assign the value to a variable of that enum data type you just created.
        //Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week.” to the console if an error occurs.
        static void Main()
        {
        bool dayValid = false; //we create a boolean variable dayValid and set it's initial value to false, it will change into true at the end of the try block
            while (!dayValid) //while the dayValid variable is true, which is to say that while the user entry is a valid day of the week, do this:
            {
                try
                {
                    //DayOfWeek is a built-in enum that specifies the day of the week (use System to use it)
                    DayOfWeek today = DateTime.Today.DayOfWeek; // Gets currrent day of week

                    //Prints out the values in DayOfWeek:
                    //foreach (string day in Enum.GetNames(typeof(DayOfWeek))) //GetNames returns an array of the names of the constants in an enumeration, so  returns what is in enum
                    //{
                    //    DayOfWeek days = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), day);
                    //    Console.WriteLine(days); 
                    //}

                    Console.WriteLine("Enter the current day of the week: "); //Prompts user to enter today's day
                    string userInput = Console.ReadLine(); //save user input in a string

                    //Parse(): Converts a string to an enum, returns enum
                    //Parse syntax: object Enum.Parse(Type enumtype, string value) (+1 overload)

                    DayOfWeek userInputEnum = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), userInput); //Converts user input string type into enum type

                    if (today == userInputEnum) //if user input equals today's date, print out this:
                    {
                        Console.WriteLine("You are correct. Today is {0}.", today);
                    }

                    else if (today != userInputEnum) //if user input does not equal today's date, print out this:
                    {
                        Console.WriteLine("You are incorrect. Today is not {0}, it is {1}.", userInputEnum, today);
                    }

                    dayValid = true; //if user entry was a valid day of the week, dayValid boolean changes to true and it jumps to the finally block
                }
                catch (Exception ex) //This is a general error message for another issue not stated above
                {
                    Console.WriteLine("Please enter an actual day of the week! Press enter to try again!");
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