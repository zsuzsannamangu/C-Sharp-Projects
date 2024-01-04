using System;

namespace incomeComparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program"); //prints title of program using Console.WriteLine()
            Console.WriteLine("Person 1");
            Console.WriteLine("What is your hourly rate?"); //asks person 1 for input
            string hourlyRate1 = Console.ReadLine(); //reads input as string
            int hourlyR1 = Convert.ToInt32(hourlyRate1); //converts string input into integer
            Console.WriteLine("How many hours do you work per week?");
            string workedHours1 = Console.ReadLine();
            int workedH1 = Convert.ToInt32(workedHours1);
            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly rate?");
            string hourlyRate2 = Console.ReadLine();
            int hourlyR2 = Convert.ToInt32(hourlyRate2);
            Console.WriteLine("How many hours do you work per week?");
            string workedHours2 = Console.ReadLine();
            int workedH2 = Convert.ToInt32(workedHours2);
            int annualSalary1 = hourlyR1 * workedH1 * 52; //multiplies person 1's hourly rate and hours worked, then multiplies it by 52 as there are 52 weeks/year
            Console.WriteLine("Annual salary of Person 1: " + annualSalary1); //prints the annual salary of person 1 on the screen
            int annualSalary2 = hourlyR2 * workedH2 * 52;
            Console.WriteLine("Annual salary of Person 2: " + annualSalary2);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool answer = annualSalary1 > annualSalary2; //checks whether person 1's salary is bigger than person 2's salary and stores the answer in a boolean variable
            Console.WriteLine(answer); //prints the boolean answer to the console
            Console.ReadLine(); //prevents the console window from closing automatically
        }
    }
}
