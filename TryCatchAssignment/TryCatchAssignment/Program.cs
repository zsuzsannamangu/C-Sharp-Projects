using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            bool numValid = false; //Sets numValid variable to false, it will change to True at the end of the try block
            while (!numValid) //while the number entered is valid, the try block will run, otherwise the catch block will run
            {
                try
                {
                    Console.WriteLine("What is your age?");
                    int age = Convert.ToInt32(Console.ReadLine());

                    DateTime currentDateTime = DateTime.Now;

                    int currentYear = currentDateTime.Year;

                    int userBirthYear = currentYear - age;
                    Console.WriteLine("You were born in {0}", userBirthYear);
                    numValid = true;
                }


                catch (FormatException) //This error message appears if the user enters something other than a number
                {
                    Console.WriteLine("Please enter a whole number!");
                }

                catch (Exception) //This is a general error message for another issue not stated above
                {
                    Console.WriteLine("Something went wrong. Please contact your system administrator.");
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
