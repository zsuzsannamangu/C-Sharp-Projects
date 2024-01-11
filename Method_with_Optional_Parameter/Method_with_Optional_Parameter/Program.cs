using System;

namespace Method_with_Optional_Parameter
{
    class Program
    {
        static void Main()
        {
            bool numValid = false; //numValid boolean starts as false, it will change to true at the end of the try block if the number entered was valid
            while (!numValid) //while the number is valid, do this:
            {
                try
                {
                    Console.WriteLine("Enter a number: "); //Prompts the user to enter a number
                    int num1 = Convert.ToInt32(Console.ReadLine()); //User entry is stored in the num1 variable which is an integer

                    Console.WriteLine("Optional: Enter a second number: "); //Prompts the user to enter an optional second number
                    int num2; //declares num2 as an integer, no value is given here

                    if (int.TryParse(Console.ReadLine(), out num2)) //if a second number was given and it is an integer
                                                                    //bool int.TryParse(string s, out int result) converts the string representation of a number to 32-bit signed integer equivalent
                                                                    //the return value indicates wheather the conversation succeeded
                    {
                        Console.WriteLine("8 + " + num1 + " + " + num2 + " = " + Addition.AdditionOperation(num1, num2)); //then add all three numbers together
                    }
                    else
                    {
                        Console.WriteLine("8 + " + num1 + " = " + Addition.AdditionOperation(num1)); //otherwise only add the first user number and 8 together
                    }
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

            Console.ReadLine(); //This line prevents the console window from closing automatically
        }
    }
}

