using System;
using System.Collections.Generic;

namespace exceptionHandling.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Putting the try-catch inside the while loop will allow user to continue to enter values until they enter the valid number
           
            bool numValid = false; //The key to using a while statement for this is to have a boolean variable that you can change
            while (!numValid) //!numValid is evaluating whether numValid is False
                              //If it's True then the while loop won't run, whereas if it's set to False it will run until changed to True.
            {
                try
                {
                    List<int> numberList = new List<int>() { 56, 100, 77, 43, 98, 12, 341 }; //Created a list of integers. 
                    Console.WriteLine("Enter a whole number to divide each number in the list by:"); //Asked the user for a number to divide each number in the list by.
                    int userNumber = Convert.ToInt32(Console.ReadLine()); //Stored user input in a variable

                    foreach (int listedNumber in numberList) //Created a loop to loop through the list
                    {
                        int newNumber = listedNumber / userNumber; //Each number in the list is divided by the number the user entered
                        Console.WriteLine(newNumber); //The result is displayed on the screen
                        numValid = true; //You want to change the boolean variable to true at the end of your try block.
                                         //Switching it to true will stop the while loop from running.
                    }
                    Console.ReadLine();
                }

                catch (FormatException ex) //This error message appears if the user enters something other than a number
                {
                    Console.WriteLine("Please enter a whole number!");
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
                    Console.WriteLine("Press enter to try again!");
                }
                Console.ReadLine();
            }
        }
    }
}



