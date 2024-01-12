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
            //Employee employee1 = new Employee() { Id = 3 };
            //Employee employee2 = new Employee() { Id = 3 };

            //Console.WriteLine(employee1 == employee2);

            //Instantiate an Employee object with type “string” as its generic parameter. Assign a list of strings as the property value of Things.

            var thing = new Employee<string>();
            thing.Things = new List<string> { "desk", "chair", "drawer" };

            //Instantiate an Employee object with type “int” as its generic parameter. Assign a list of integers as the property value of Things.

            var thing2 = new Employee<int>();
            thing2.Things = new List<int> { 12, 23, 73 };

            foreach (var item in thing.Things)
            {
                Console.WriteLine(item);
            }

            foreach (var item2 in thing2.Things)
            {
                Console.WriteLine(item2);
            }

            Console.ReadLine();

        }
    }
}
