using System;

namespace carInsuranceApproval
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?"); //asks user to enter their age
            int age = Convert.ToInt32(Console.ReadLine()); //user input is a string which is converted into an integer and stored in a new variable with integer datatype
            Console.WriteLine("Have you ever had a DUI?"); //asks user whether they had a DUI
            bool dui = Convert.ToBoolean(Console.ReadLine()); //user input is a string which is converted into boolean and stored in a new variable with boolean datatype
            Console.WriteLine("How many speeding tickets do you have?"); //asks user how many speeding tickets they had
            int speedingTic = Convert.ToInt32(Console.ReadLine()); //user input is a string which is converted into integer and stored in a new variable with integer data type

            bool doesQualify = (age > 15 && !dui && speedingTic <= 3); //the doesQualify boolean variable stores the information about whether the person qualifies for insurance
                                                                        //to qualify the person needs to be over 15 years old AND has no DUI AND has less than 3 speeding tickets
            Console.WriteLine("Do you qualify for car insurance? " + doesQualify); //the answer is printed to the console
            Console.ReadLine(); //this line prevents the console window to close automatically
        }
    }
}
