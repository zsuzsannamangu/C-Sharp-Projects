using System;

namespace structAssignment.cs
{
    class Program
    {

        /*Assignment instructions:
        Create a struct called Number and give it the property “Amount” and have it be of data type decimal.
        In the Main() method, create an object of data type Number and assign an amount to it.
        Print this amount to the console.*/

        /*A struct is the same as a class, but it's a value data type as oppposed to a reference data type like a class.
        Value data data types can't inherit or be inherited from and can't have a value of null.*/

        public struct Number //created a struct called Number
        {
            public decimal Amount { get; set; } //gave it a property "Amount" with data type decimal
        }

        static void Main()
        {
            Number num = new Number(); //created an object of data type Number
            num.Amount = 5.55m; //assigned an amount to num of the Amount property of the Number struct
            Console.WriteLine(num.Amount); //printed the above amount to the console
            Console.ReadLine(); //this line prevents the console window from closing automatically
        }
    }
}
