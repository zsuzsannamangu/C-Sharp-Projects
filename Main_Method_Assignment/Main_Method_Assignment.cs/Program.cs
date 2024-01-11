using System;

namespace Main_Method_Assignment.cs
{
    class Program
    {
        static void Main()
        {
            //we are callig the MathOperations method 3 times which is at Operations.cs:

            int number = 3;
            Console.WriteLine("12 - " + number + " = " + Operations.MathOperations(number));

            decimal decNumber = 9.11m; //decNumber is a decimal datatype which requires an "m" suffix after the value
            int decNumberInt = Convert.ToInt32(Operations.MathOperations(decNumber)); //we are converting the result of the math operation from decimal to integer
            Console.WriteLine("2 * " + decNumber + " = " + decNumberInt);

            string stringNumber = "5"; //stringNumber is a string datatype so we use double quotes
            Console.WriteLine("2 + " + stringNumber + " = " + Operations.MathOperations(Convert.ToInt32(stringNumber))); //we are converting string to integer in order to perform the math operation

            Console.ReadLine(); //Console.ReadLine() prevents the console window from closing automatically
        }
    }
}
