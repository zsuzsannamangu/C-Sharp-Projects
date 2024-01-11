using System;

namespace Method_Class_Assignment.cs
{
    class Program
    {
        static void Main()
        {
            Subtraction subtractionObject = new Subtraction();

            Console.WriteLine("Version 1:");
            subtractionObject.Subtract(2, 3);
            Console.WriteLine("Version 2:");
            subtractionObject.Subtract(num1: 2, num2: 3);

            Console.ReadLine();

        }
    }
}
