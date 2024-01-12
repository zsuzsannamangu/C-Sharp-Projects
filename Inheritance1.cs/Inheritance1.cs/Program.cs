using System;

namespace Inheritance1.cs
{
    class Program
    {
        static void Main()
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" }; //We created an object for the Employee class and gave its two properties values
            //employee.FirstName = "Sample"; //this is another way to give values to its properties
            //employee.LastName = "Student";

            employee.SayName(); //we are calling the SayName() method on the employee object

            Console.ReadLine(); //this line prevents the console window to close automatically

        }
    }
}
