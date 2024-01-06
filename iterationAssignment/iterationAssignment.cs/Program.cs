using System;
using System.Collections.Generic;

namespace iterationAssignment.cs
{
    class Program
    {
        static void Main()
        {

            //Part One Assignment

            string[] favAnimals = { "giraffe", "lion", "leopard", "elephant"};

            Console.WriteLine("Press the letter \"s\" to see the plural form of the animals!");
            string userText = Console.ReadLine();

            for (int i = 0; i < favAnimals.Length; i++)
            {
                favAnimals[i] += userText;
            }

            //Console.WriteLine(favAnimals[0]);
            //Console.WriteLine(favAnimals[1]);
            //Console.WriteLine(favAnimals[2]);
            //Console.WriteLine(favAnimals[3]);

            foreach (string animal in favAnimals)
            {
                Console.WriteLine(animal);
            }




            //Part Two Assignment: Infinite Loop

            string firstAnimal = "giraffe";
            while (true)
            {
                Console.WriteLine(firstAnimal);
                break; //without adding the word "break" the loop will go on infinitely, otherwise it prints out "giraffe" only once
            }




            //Part Three Assignment
            //A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.

            int[] money = { 20, 50, 12, 49 };

            for (int i = 0; i < money.Length; i++)
            {
                if (money[i] < 40)
                {
                    Console.WriteLine("You only have $" + money[i] + ". You cannot buy this.");
                }
            }

            //A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator.
            int[] ages = { 18, 12, 50, 34, 40, 26 };

            for (int i = 0; i < ages.Length; i++)
            {
                if (ages[i] <= 21)
                {
                    Console.WriteLine("You are only " + ages[i] + " years old. You cannot enter the bar.");
                }
            }



            //Part Four Assignment

            List<string> names = new List<string>() { "Jesse", "Bob", "Kristi", "Leo" };

            Console.WriteLine("Search for a name in the list:");
            string nameSearch = Console.ReadLine();

            for (int i = 0; i < names.Count; i++)
            {
                if (names[i] != nameSearch)
                {
                    Console.WriteLine("There is no match.");
                }
                else
                {
                    Console.WriteLine("There is a match. The index of the list item is: " + i);
                    break;
                }
            }



            //Part Five Assignment

            List<string> fruits = new List<string>() { "pineapple", "orange", "banana", "apple", "apple", "blueberry", "orange", "mango" };

            Console.WriteLine("Search for a fruit in the list:");
            string fruitSearch = Console.ReadLine();

            for (int i = 0; i < fruits.Count; i++)
            {
                if (fruits[i] == fruitSearch)
                {
                    Console.WriteLine("There is a match. The index of the list item is: " + i);
                }
                else if (fruits[i] != fruitSearch)
                {
                    Console.WriteLine("There is no match.");
                }
            }



            //Part Six Assignment

            List<string> veggies = new List<string>() { "spinach", "celery", "spinach", "cucumber", "squash", "celery", "asparagus", "cucumber", "kale" };

            




            Console.ReadLine();

        }
    }
}
