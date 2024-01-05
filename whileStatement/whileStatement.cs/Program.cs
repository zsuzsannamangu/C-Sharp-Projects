using System;

namespace whileStatement.cs
{
    class Program
    {
        static void Main()
        {
            //The while loop loops through a block of code as long as a specified condition is True.
            uint count = 10; //the uint variable can only hold positive whole numbers
            while (count <= 10) //as long as count is less or equal to 10
            {
                Console.WriteLine(count); //print the value of count on the console
                count -= 1; //then subtract 1 from count and start over
            }

            //The do while loop: The loop will always be executed at least once, even if the condition is false, because the code block is executed before the condition is tested.
            Console.WriteLine("Guess a fruit"); //Asks for user input
            string fruit = Console.ReadLine(); //puts user input into a string variable
            bool guess = fruit == "apple"; //creates a boolean variable that holds the right answer

            do //the do block executes first
            {
                switch (fruit) //the switch block checks for different cases
                {
                    case "apple": //if the case of apple is true, so the user entered apple
                        Console.WriteLine("Correct"); //print correct on the screen
                        guess = true; //the boolean guess variable then becomes true and the switch block and do block will end
                        break; //the break closes the current switch block
                    default: //if the input is anything but apple, write the below lines on the screen and start the guessing again.
                        Console.WriteLine("Not correct. Try again.");
                        Console.WriteLine("Guess a fruit");
                        fruit = Console.ReadLine();
                        break;
                }
            }
            while (!guess); //while the guess variable is false, keep repeating the above code and ask the user to guess a new fruit

            Console.Read();
        }
    }
}
