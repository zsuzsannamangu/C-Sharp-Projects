using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandling.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numberList = new List<int>() { 56, 100, 77, 43, 98, 12, 341 }; //Created a list of integers. 
                Console.WriteLine("Enter a number to divide each number in the list by:"); //Asked the user for a number to divide each number in the list by.
                int userNumber = Convert.ToInt32(Console.ReadLine()); //Stored user input in a variable

                foreach (int listedNumber in numberList) //Created a loop to loop through the list
                {
                    int newNumber = listedNumber / userNumber; //Each number in the list is divided by the number the user entered
                    Console.WriteLine(newNumber); //The result is displayed on the screen
                }
                Console.ReadLine();
            }

            catch (FormatException ex) //This error message appears if the user enters something other than a number
            {
                Console.WriteLine("Please enter a number!");
            }

            catch (DivideByZeroException ex) //This error message appears if the user enters zero
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please choose a number other than zero since all numbers divided by zero will be zero.");
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
