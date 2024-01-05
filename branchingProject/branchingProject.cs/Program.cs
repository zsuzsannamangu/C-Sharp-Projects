using System;

namespace branchingProject
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Enter package weight in lbs:");
            int packageWeight = Convert.ToInt32(Console.ReadLine()); //creates integer variable which holds the user input
            if (packageWeight > 50) //if the weight of the package is greater than 50, display the message inside of the {}
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day!");
            }
            else //if it's less than 50, do the following:
            {
                Console.WriteLine("Enter package width");
                int packageWidth = Convert.ToInt32(Console.ReadLine()); //this integer holds the the width that user entered
                Console.WriteLine("Enter package height");
                int packageHeight= Convert.ToInt32(Console.ReadLine());//this integer holds the height that user entered
                Console.WriteLine("Enter package length");
                int packageLength = Convert.ToInt32(Console.ReadLine());//this integer holds the length that user entered
                if (packageWidth * packageLength * packageHeight > 50) //if the total dimensions are greater than 50, display message below in {}
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. Have a good day!");
                }
                else //otherwise display the quote:
                { 
                    float quote = (packageWeight * (packageWidth * packageLength * packageHeight)) / 100f; //float is used here instead of integer, since integer can only be whole numbers
                    Console.WriteLine("Your quote is $" + quote + ".");//this message is displayed to the user.
                }
            }
                Console.ReadLine(); //this prevents the window from closing automatically
        }
    }
}
