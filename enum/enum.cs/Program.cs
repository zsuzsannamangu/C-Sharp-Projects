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

                    dayValid = true;

            catch
            {


            }

    }
            }
        }
    }
}
