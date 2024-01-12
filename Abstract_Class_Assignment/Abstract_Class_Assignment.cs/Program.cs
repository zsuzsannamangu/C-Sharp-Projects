using System;

namespace Abstract_Class_Assignment.cs
{
    public class Program
    {
        static void Main()
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" }; //Instantiated an Employee object with FirstName “Sample” and LastName “Student”
            employee.SayName(); //Called SayName() method on the object

            Console.WriteLine("Name: " + employee.FirstName + " " + employee.LastName);

            Console.ReadLine();

        }
    }
}
