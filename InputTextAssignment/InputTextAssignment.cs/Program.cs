using System;
using System.IO; //to use text files we use the System.IO namespace

namespace InputTextAssignment.cs
{

    //Assignment instructions:
    //Ask the user for a number.
    //Log that number to a text file.
    //Print the text file back to the user.
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number: "); //Asks the user for a number
            int userInput = Convert.ToInt32(Console.ReadLine()); //Saves user input in the userInput variable as an integer

            string textWrite = Convert.ToString(userInput); //Saves userinput as a string in the textWrite variable
            File.WriteAllText(@"C:\Users\zsuzsi\Documents\Logs\log2.txt", textWrite); //Logs that number into the text file named log2.txt, located at the given path

            string textRead = File.ReadAllText(@"C:\Users\zsuzsi\Documents\Logs\log2.txt"); //Reads the content of the file named log2.txt and saves it in the textRead variable
            Console.WriteLine("Your number: " + textRead); //Prints the number on the console

            Console.ReadLine(); //This line prevents the console window from closing immediately
        }
    }
}
