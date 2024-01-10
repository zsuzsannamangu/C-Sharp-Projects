using System;

namespace Classes_and_Methods_Assignment.cs
{
    class Program
    {
        //Create a class. In that class, create three methods, each of which will take one integer parameter in and return an integer.
        //The methods should do some math operation on the received parameter. Put this class in a separate .cs file in the application.
        
        //In the Main() program, ask the user what number they want to do the math operations on.
        //Call each method in turn, passing the user input to the method.
        //Display the returned integer to the screen.

        static void Main()
        {
            bool validNum = false; //Start with a boolean variable that is false and will change to true if the user number is a valid number
            while (!validNum) //While the number is valid, do the code in the {}. The while loop will allow the user to try again if the input wasn't valid
            {
                try
                {
                    Console.WriteLine("Enter a number: "); //Prompts the user to enter a number
                    int userNum = Convert.ToInt32(Console.ReadLine()); //User entry is stored in the userNum variable which is an integer

                    Console.WriteLine("5 + " + userNum + " = " + Math.Addition(userNum)); //We are calling the Math class' Addition, Subtraction and Multiplication method which are at Math.cs
                    Console.WriteLine("10 - " + userNum + " = " + Math.Subtraction(userNum));
                    Console.WriteLine("2 * " + userNum + " = " + Math.Multiplication(userNum));

                    validNum = true; //validNum boolean variable will change to true if the user entry was valid
                    Console.ReadLine();
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
