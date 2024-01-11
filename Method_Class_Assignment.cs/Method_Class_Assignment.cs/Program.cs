using System;

namespace Method_Class_Assignment.cs
{
    class Program
    {
        static void Main()
        {
            Subtraction subtractionObject = new Subtraction(); //created object

            Console.WriteLine("Version 1:");
            subtractionObject.Subtract(2, 3); //called Subtract method from Subtraction.cs and passed in two arguments
            Console.WriteLine("Version 2:");
            subtractionObject.Subtract(num1: 2, num2: 3); //called Subtract method again passing in the same arguments, but now also displaying the parameters by name

            Console.ReadLine(); //this line prevents the console window from closing automatically

        }
    }
}
