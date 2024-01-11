using System;

namespace Method_Class_Assignment.cs
{
    class Subtraction //created a class
    {
        public void Subtract(int num1, int num2) //created a void method that takes two parameters
                                                //void means that this method does not have a return value
        {
            int num3 = 10 - num1; //performed math operation on the first parameter
            Console.WriteLine("10 - 2 is " + num3); //displayed the result of the math operation
            Console.WriteLine("The second number is " + num2); //displayed the second parameter
        }

    }
}
