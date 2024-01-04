using System;

namespace mathOperations
{
    class Program
    {
        static void Main()
        {
            int num1 = 5;
            int num2 = 2;
            int total = num1 + num2; //add two numbers
            Console.WriteLine(total); //display output in the console
            int subtract = num1 - num2; //subtract two numbers
            Console.WriteLine(subtract);
            int multiply = num1 * num2; //multiply two numbers
            Console.WriteLine(multiply);
            int divide = num1 / num2; //divide two numbers
            Console.WriteLine(divide);
            int remainder = num1 % num2; //display the remainder after dividing two numbers
            Console.WriteLine(remainder);
            string name1 = "Zsuzsi";
            string name2 = "Mangu";
            string names = name1 + name2;
            Console.WriteLine(names);
            Console.WriteLine("Type in a number"); //we are taking input from the user
            string userNumber = Console.ReadLine(); //input is string 
            double userNum = Convert.ToDouble(userNumber); //convert string into a number, a number that is up to 15/16 digits in length and it's not only a whole number
            double multiplyNum = userNum * 50; //we multiply the user input by 50
            Console.WriteLine(multiplyNum);
            double addNum = userNum + 25; //we add 25 to the user input
            Console.WriteLine(addNum);
            double divideNum1 = userNum / 12.5; //we divide user input by 12.5
            Console.WriteLine(divideNum1);
            bool boolNum = userNum > 50; //check whether user input is bigger than 50
            Console.WriteLine(boolNum);
            double divideNum2 = userNum % 7; //divide user input by 7 and print out the remainder on the console
            Console.WriteLine(divideNum2);
            Console.ReadLine();
        }
    }
}
