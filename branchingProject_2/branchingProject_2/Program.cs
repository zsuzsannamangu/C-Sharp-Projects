using System;


namespace branchingProject_2
{
    class Program
    {
        static void Main()
        {
            int day = 9;
            switch (day) //day is the expression of the switch block, the switch expression is evaluated once
            {
                case 1: //The value of the expression is compared with the values of each case. If there is a match, the associated block of code is executed.
                    Console.WriteLine("Monday");
                    break; //When C# reaches a break keyword, it breaks out of the switch block.
                case 2: //It basically means if day equals 2, then do what's below
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default: //The default keyword is optional and specifies some code to run if there is no case match
                    Console.WriteLine("No match.");
                    break;
            }

            Console.WriteLine("Guess a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 12;

            do
            {
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 62. Incorrect, try again");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29. Incorrect, try again");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("Correct");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("Incorrect, try again");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            while (!isGuessed); //while isGuessed is false, same as saying isGuessed == false, do what's in {}

            Console.ReadLine();
        }
    }
}
