using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum.cs
{
    class Program
    {
        static void Main()
        {
            //public enum DaysOfWeek
            //{
            //Monday,
            //Tuesday,
            //Wednesday,
            //Thursday,
            //Friday,
            //Saturday,
            //Sunday
            //}
        //Create an enum for the days of the week.
        //Prompt the user to enter the current day of the week.
        //Assign the value to a variable of that enum data type you just created.
        //Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week.” to the console if an error occurs.

            bool dayValid = false;
            while (!dayValid)
            {
                try
                {
                    Console.WriteLine("Enter the current day of the week: ");
                    string userInput = Console.ReadLine();

                    DaysOfWeek day = DaysOfWeek.Friday;

                    dayValid = true;
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
                    Console.WriteLine("Press enter to try again!");
                }
                Console.ReadLine();

            }
            
        }
    }
}
