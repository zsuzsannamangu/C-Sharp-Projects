using System;

namespace Class_Assignment.cs
{
    class Program
    {
        static void Main()
        {
            //Proper way to name an object: Start with lower case letters and follow with upper case.
            Division divisionObject = new Division(); //created an object of the Division class

            Console.WriteLine("Enter a number: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            divisionObject.DivideNumbers(userNumber); //Call a method on an object by adding a period after the object name, followed by the name of the method and parentheses

            int num2 = 20;
            divisionObject.DivisionTwo(out num2); //called the DivisionTwo method with an out parameter

            decimal decNum = 38.4554m;
            divisionObject.DivideNumbers(decNum); //called the second DivideNumbers method

            Static.Name(); //called the Name method which is part of the Static class

            Console.ReadLine(); //this line prevents the console window to close automatically

        }
    }
}
