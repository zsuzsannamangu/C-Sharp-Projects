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
            Console.ReadLine(); //added
        }
    }
}
