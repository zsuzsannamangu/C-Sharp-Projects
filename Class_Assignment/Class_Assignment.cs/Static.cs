using System;

namespace Class_Assignment.cs
{
    static class Static //static classes can't create objects and everything inside of it must be static too
                        //The static keyword is used in C# to indicate that a member belongs to the type itself rather than to a specific object.
    {
        static string fname = "Joe"; //declared two static variables
        static string lname = "Smith";

        public static void Name() //created static method that won't return a value
        {
            Console.WriteLine("The name is " + fname + " " + lname);
        }

    }
}
