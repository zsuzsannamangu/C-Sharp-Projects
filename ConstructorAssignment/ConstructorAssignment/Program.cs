using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{

    //Assignment instructions:
    //Create a const variable.
    //Create a variable using the keyword “var.”
    //Chain two constructors together.

    class Program
    {
        static void Main()
        {
            const string bookClubName = "Our Bookclub"; //creates a constant variable, using constant here because the name of the bookclub won't change
            var newBook = "Rooted in Hope"; //creates a variable without declaring the datatype, using the var keyword

            Console.WriteLine("{0} is reading: {1}.", bookClubName, newBook); //prints to the console
            Console.ReadLine(); //prevents the console window from closing automatically
        }
    }
}
