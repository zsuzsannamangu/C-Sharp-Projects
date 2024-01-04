using System;

namespace branchingProject
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            if (name == "Erik")
            {
                Console.WriteLine("Your name is Erik.");
            }
            else if (name == "Sandra")
            {
                Console.WriteLine("Your name is Sandra.");
            }
            else
            {
                Console.WriteLine("You are not Sandra or Erik.");
            }
            Console.ReadLine();
        }
    }
}
