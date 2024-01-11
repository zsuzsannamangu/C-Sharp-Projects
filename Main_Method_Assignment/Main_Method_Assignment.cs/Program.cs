using System;

namespace Main_Method_Assignment.cs
{
    class Program
    {
        static void Main()
        {
            //we are callig the MathOperations method 3 times which is at Operations.cs:
            Operations operationsObject = new Operations();

            int number = 3;
            Console.WriteLine("12 - " + number + " = " + operationsObject.MathOperations(number));

            decimal decNumber = 9.11m; //decNumber is a decimal datatype which requires an "m" suffix after the value
            Console.WriteLine("2 * " + decNumber + " = " + operationsObject.MathOperations(decNumber));

            string stringNumber = "5"; //stringNumber is a string datatype so we use double quotes
            Console.WriteLine("12 + " + stringNumber + " = " + operationsObject.MathOperations(stringNumber));

            Console.ReadLine(); //Console.ReadLine() prevents the console window from closing automatically
        }
    }
}
