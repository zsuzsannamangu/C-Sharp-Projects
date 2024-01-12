using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment.cs
{
    class Program
    {
        //Instantiate two objects of the Employee class and assign their values to their properties
        //Then compare the two Employee objects using the newly overloaded operators and display the results.
        static void Main()
        {
            Employee employee1 = new Employee() { Id = 3 };
            Employee employee2 = new Employee() { Id = 3 };

            if (employee1 != employee2)
                Console.WriteLine("Not equal");
            else
                Console.WriteLine("Equal");

            Console.ReadLine();

        }
    }
}
