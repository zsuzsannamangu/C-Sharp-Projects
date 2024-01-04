using System; //using System refers to using the Base Class Library, a library that provides basic functionality of C#

namespace dailyReport.cs //A namespace in C# is a container for classes and other namespaces
{
    class Program
    {
        static void Main() //The Main() function is 1st to be executed when running the program
        {
            Console.WriteLine("The Tech Academy"); //Content of () is printed on the screen
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine(); //Created a string variable to hold the user input. Console.ReadLine() takes input from the screen.
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine(); //String datatypes are used for 0 or more characters
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumber); //Converted string "pageNumber" into integer
            Console.WriteLine("Do you need help with anything?");
            string helpNeeded = Console.ReadLine();
            bool helpNeed = Convert.ToBoolean(helpNeeded); //Converted string into boolean
            Console.WriteLine("Were there any positive experiences you’d like to share?");
            string anyExperiences = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string anyFeedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            int hoursStu = Convert.ToInt32(hoursStudied); //Converted string "hoursStudied" into integer
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine(); //Added Console.ReadLine() at the end to prevent the console window to close automatically
        }
    }
}
