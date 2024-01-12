using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment.cs
{
    public class Employee //Created an Employee class with Id, FirstName and LastName properties
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Overload the “==” operator, so it checks if two Employee objects are equal by comparing their Id property.
        //Comparison operators must be overloaded in pairs: == and !=

        //public static bool operator ==(Employee employee1, Employee employee2)
        //=> employee1.Id == employee2.Id;

        //public static bool operator !=(Employee employee1, Employee employee2)
        //=> !(employee1 == employee2);

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            bool result = false;
            if (employee1.Id == employee2.Id)
            {
                result = true;
            }
            return result;
        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            bool result = false;
            if (employee1.Id != employee2.Id)
            {
                result = true;
            }
            return result;
        }
    }
}

//public static bool operator !=(Employee employee1, Employee employee2)
//{
//    return !(employee1 == employee2);
//}