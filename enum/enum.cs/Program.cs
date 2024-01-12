using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum.cs
{
    public class Program
    {
        public enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main()
        {
            
        //Create an enum for the days of the week.
        //Prompt the user to enter the current day of the week.
        //Assign the value to a variable of that enum data type you just created.
        //Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week.” to the console if an error occurs.

        bool dayValid = false;
            while (!dayValid)
            {
                try
                {
                    // Get currrent day of week.
                    DayOfWeek today = DateTime.Today.DayOfWeek;
                    Console.WriteLine("Today is {0}", today);

                    //Prints out the underlying value number of each day:
                    foreach (string day in Enum.GetNames(typeof(DayOfWeek)))
                    {
                        Console.WriteLine("{0} = {1:D}", day,
                                                     Enum.Parse(typeof(DayOfWeek), day));
                    }
                    //Adds an extra line:
                    Console.WriteLine();

                    DayOfWeek today2 = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), "Monday");
                    Console.WriteLine("The orange value {0:D} has the combined entries of {0}",
                                       today2);

                    Console.WriteLine("Enter the current day of the week: ");
                    string userInput = Console.ReadLine();
                    Console.WriteLine("Your entry is {0}", userInput);

                    DaysOfWeek daysofweek = new DaysOfWeek();

                    // Test current day of week.
                    //if (today == userInput)
                    //{
                    //    Console.WriteLine("DO WORK");
                    //}

                    
                   




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
                    Console.WriteLine("Thank you!");
                }
                Console.ReadLine();

            }
            
        }
    }
}


/*
public class ParseTest
{
    [Flags]
    enum Colors { Red = 1, Green = 2, Blue = 4, Yellow = 8 };

    public static void Main()
    {
        Console.WriteLine("The entries of the Colors enumeration are:");
        foreach (string colorName in Enum.GetNames(typeof(Colors)))
        {
            Console.WriteLine("{0} = {1:D}", colorName,
                                         Enum.Parse(typeof(Colors), colorName));
        }
        Console.WriteLine();

        Colors orange = (Colors)Enum.Parse(typeof(Colors), "Red, Yellow");
        Console.WriteLine("The orange value {0:D} has the combined entries of {0}",
                           orange);
    }
}


This code example produces the following results:

The entries of the Colors Enum are:
Red = 1
Green = 2
Blue = 4
Yellow = 8

The orange value 9 has the combined entries of Red, Yellow

*/