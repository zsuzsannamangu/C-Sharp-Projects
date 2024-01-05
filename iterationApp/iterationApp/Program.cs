using System;
using System.Collections.Generic;

namespace iterationApp
{
    class Program
    {
        static void Main()
        {
            int[] testScores1 = { 78, 65, 98, 79, 69, 90 };

            //we are starting with 0 and we are doing the for loop as long as we reach the end of the length of the testscores
            for (int i = 0; i < testScores1.Length; i++)
            {
                if (testScores1[i] > 85)
                {
                    Console.WriteLine("Passing test score: " + testScores1[i]);
                }
            }


            string[] names1 = { "John", "Marry", "Jesse", "Bob", "Tod" };

            for (int j = 0; j < names1.Length; j++)
            {
                if (names1[j] == "Jesse")
                {
                    Console.WriteLine(names1[j]);
                }
            }

            List<int> testScores2 = new List<int>();
            testScores2.Add(89);
            testScores2.Add(85);
            testScores2.Add(86);
            testScores2.Add(56);
            testScores2.Add(68);
            testScores2.Add(99);

            foreach (int score in testScores2)
            {
                if (score >= 85)
                {
                    Console.WriteLine("Passing score: " + score);
                }
            }

            
            
            List<string> names2 = new List<string>() { "Jesse", "Bob", "Kristi", "Leo" };

            foreach (string name in names2)
            {
                Console.WriteLine(name); //displays all names
            }

            
            
            
            List<int> testScores3 = new List<int>() { 76, 98, 77, 90, 91 };
            List<int> passingScores = new List<int>(); //you can create an empty list but not an empty array, this is where we are going to add the test scores that passed

            foreach (int score in testScores3)
            {
                if (score >= 85)
                {
                    passingScores.Add(score);
                }
            }
            Console.WriteLine(passingScores.Count);
            Console.ReadLine();
        }
    }
}
