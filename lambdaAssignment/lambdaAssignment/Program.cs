using System;
using System.Collections.Generic;
using System.Linq;

namespace lambdaAssignment
{
    //Assignment instructions:
    //Create an Employee class with the following properties: Id, First Name, Last Name
    //In the Main() method, create a list of at least 10 employees. At least two employees should have the first name “Joe”.
    //Using a foreach loop, create a new list of all employees with the first name “Joe”.
    //In your comparison statement, remember to reference the property of the object you are checking.
    //Perform the same action again, but this time with a lambda expression.
    //Using a lambda expression, make a list of all employees with an Id number greater than 5.
    class Program
    {
        static void Main()
        {
            //Instantiates the list for all employees without having the create individual variables and then adding them to the list:
            List<Employee> employeeList = new List<Employee> {
                new Employee {Id = 1, FirstName = "Joe", LastName = "Smith"},
                new Employee {Id = 2, FirstName = "Sarah", LastName = "Holsey" },
                new Employee {Id = 3, FirstName = "Lili", LastName = "Trenchard" },
                new Employee {Id = 4, FirstName = "Marian", LastName = "Cronen" },
                new Employee {Id = 5, FirstName = "Katie", LastName = "Calvillo" },
                new Employee {Id = 6, FirstName = "Kelly", LastName = "Ventre" },
                new Employee {Id = 7, FirstName = "John", LastName = "Sandin" },
                new Employee {Id = 8, FirstName = "Joe", LastName = "Cataldi" },
                new Employee {Id = 9, FirstName = "Lyra", LastName = "Starns" },
                new Employee {Id = 10, FirstName = "Joe", LastName = "Commisso" },
                new Employee {Id = 11, FirstName = "Matthew", LastName = "Lommel" },
            };

            //Employee employee1 = new Employee() { Id = 1, FirstName = "Joe", LastName = "Smith" };
            //Employee employee2 = new Employee() { Id = 2, FirstName = "Sarah", LastName = "Holsey" };
            //Employee employee3 = new Employee() { Id = 3, FirstName = "Lili", LastName = "Trenchard" };
            //Employee employee4 = new Employee() { Id = 4, FirstName = "Marian", LastName = "Cronen" };
            //Employee employee5 = new Employee() { Id = 5, FirstName = "Katie", LastName = "Calvillo" };
            //Employee employee6 = new Employee() { Id = 6, FirstName = "Kelly", LastName = "Ventre" };
            //Employee employee7 = new Employee() { Id = 7, FirstName = "John", LastName = "Sandin" };
            //Employee employee8 = new Employee() { Id = 8, FirstName = "Joe", LastName = "Cataldi" };
            //Employee employee9 = new Employee() { Id = 9, FirstName = "Lyra", LastName = "Starns" };
            //Employee employee10 = new Employee() { Id = 10, FirstName = "Joe", LastName = "Commisso" };
            //Employee employee11 = new Employee() { Id = 11, FirstName = "Matthew", LastName = "Lommel" };

            //List<Employee> employeeList = new List<Employee>(); //Creates a list of employees
            //employeeList.Add(employee1); //Adds each employee specified above to the employeeList list
            //employeeList.Add(employee2);
            //employeeList.Add(employee3);
            //employeeList.Add(employee4);
            //employeeList.Add(employee5);
            //employeeList.Add(employee6);
            //employeeList.Add(employee7);
            //employeeList.Add(employee8);
            //employeeList.Add(employee9);
            //employeeList.Add(employee10);
            //employeeList.Add(employee11);

            foreach (Employee employee in employeeList) //Prints out the first name of all employees of the employeeList
            {
                Console.WriteLine("All first names: " + employee.FirstName);
            }

            List<Employee> employeeList2 = new List<Employee>(); //Creates an empty list named employeeList2 with data type Employee refering to the Employee class
            foreach (Employee employee in employeeList) //Using a foreach loop, adds all employees with the first name “Joe” to the list "employeeList2"
            {
                if (employee.FirstName == "Joe")
                {
                    employeeList2.Add(employee);
                }
            }

            foreach (Employee employee in employeeList2)
            {
                Console.WriteLine(employee.Id); //Prints out the contents of employeeList2, showing only the ids
            }

            List<Employee> employeeListLambda = employeeList.Where(x => x.FirstName == "Joe").ToList(); //Creates a new list of all employees with the first name “Joe” using a lambda expression as opposed to a foreach loop as used above

            List<Employee> employeeListLamda2 = employeeList.Where(x => x.Id > 5).ToList(); //Using a lambda expression, makes a list of all employees with an Id number greater than 5.

            foreach (Employee employee in employeeListLamda2)
            {
                Console.WriteLine(employee.FirstName); //Prints out the contents of employeeListLamda2, showing only the first names
            }
            
            Console.ReadLine(); //This lines prevents the console window from closing automatically
        }
    }
}
