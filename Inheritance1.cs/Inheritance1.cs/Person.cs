using System;

namespace Inheritance1.cs
{
    class Person
    {
        public string FirstName { get; set; } //The Person class has two properties, FirstName and LastName
        public string LastName { get; set; }

        public void SayName() //SayName() is a method that doesn't return anything, but simply prints the full name to the console
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
