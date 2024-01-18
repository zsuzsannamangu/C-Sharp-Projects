using System;

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
            const string bookClubName = "Our Bookclub"; //Creates a constant variable, using constant here because the name of the bookclub won't change

            var bookOne = new Book("Rooted in Hope"); //Initiates a Book object without declaring its datatype. Using the generic var keyword and let C# figure out the datatype
            Console.WriteLine(bookClubName + $" read {bookOne.Title} for {bookOne.ReadingTime} hours."); // Prints out Our Bookclub read Rooted in Hope for 14 hours. 14 is the default value for ReadingTime

            Book bookTwo = new Book("Dragonbreath", 20); //we are initiating another Book object declaring Book at the datatype, we give two arguments here
            Console.WriteLine(bookClubName + $" read {bookTwo.Title} for {bookTwo.ReadingTime} hours."); // Prints out Our Bookclub read Dragonbreath for 20 hours. 20 is the given value for ReadingTime

            Console.ReadLine(); //Prevents the console window from closing automatically
        }
    }
}
