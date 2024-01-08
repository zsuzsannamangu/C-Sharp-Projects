using System;
using System.Collections.Generic;
using System.Linq;

namespace iterationAssignment.cs
{
    class Program
    {
        static void Main()
        {

            //Part One Assignment
            Console.WriteLine("Part 1:");

            string[] favAnimals = { "giraffe", "lion", "leopard", "elephant"}; //This is an array of unique strings

            Console.WriteLine("Press the letter \"s\" to see the plural form of the animals!"); //User is asked to enter the letter s
            string userText = Console.ReadLine(); //This line reads the user input and puts into the userText variable

            for (int i = 0; i < favAnimals.Length; i++) //This is a for loop. It loops through the favAnimals array as many times as many strings there are in the array
            {
                favAnimals[i] += userText; //The user input will be added to each string in the array, each string is represented by i.
            }

            foreach (string animal in favAnimals) //Loop through the favAnimals array again and do this for each item in it:
            {
                Console.WriteLine(animal); //The new strings are printed on the screen
            }




            //Part Two Assignment: Infinite Loop
            Console.WriteLine("\nPart 2:");

            string firstAnimal = "giraffe";
            while (true) //while the firstAnimal string is true, so it's "giraffe" do this:
            {
                Console.WriteLine(firstAnimal); //prints the content of the string firstAnimal on the console 
                break; //without adding the word "break" the loop will go on infinitely, otherwise it prints out "giraffe" only once
            }




            //Part Three Assignment
            Console.WriteLine("\nPart 3:");

            //A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.

            int[] money = { 20, 50, 12, 49 }; //"money" is an array of integers

            for (int i = 0; i < money.Length; i++) //it loops through the money array as many times as many integers there are in the array
            {
                if (money[i] < 40) //if amount is less than 40, it prints this message:
                {
                    Console.WriteLine("You only have $" + money[i] + ". You cannot buy this.");
                }
            }

            //A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator.
            int[] ages = { 18, 12, 50, 34, 40, 26 };

            for (int i = 0; i < ages.Length; i++)
            {
                if (ages[i] <= 21) //if age is 21 or less, print this message:
                {
                    Console.WriteLine("You are only " + ages[i] + " years old. You cannot enter the bar.");
                }
            }




            //Part Four Assignment
            Console.WriteLine("\nPart 4:");

            List<string> names = new List<string>() { "Jesse", "Bob", "Kristi", "Leo" }; //"names" is a list of strings

            Console.WriteLine("Search for a name in the list:"); //user is prompted to enter a name
            string nameSearch = Console.ReadLine(); //the user entry is saved in the string "nameSearch"

            for (int i = 0; i < names.Count; i++) //it loops through the list as many times as many strings there are in the list
            {
                if (names[i] != nameSearch) //if the user entry does not equal any strings on the list, do this:
                {
                    Console.WriteLine("There is no match.");
                }
                else //otherwise do this:
                {
                    Console.WriteLine("There is a match. The index of the list item is: " + i);
                    break; //The word "break" instructs the program to stop searching if there is a match
                }
            }




            //Part Five Assignment
            Console.WriteLine("\nPart 5:");

            List<string> fruits = new List<string>() { "pineapple", "orange", "banana", "apple", "apple", "blueberry", "orange", "mango", "blueberry", "orange" }; //"fruits" is a list of strings

            Console.WriteLine("Search for a fruit in the list:"); //user is prompted to enter a fruit
            string fruitSearch = Console.ReadLine(); //user input is saved in the "fruitSearch" string
            int count = fruits.Where(x => x.Equals(fruitSearch)).Count(); //it counts how many times the word that the user entered appears in the list, that number is saved in the "count" variable
                                                                          //to be able to use Where() you need to add "using System.Linq;"

            for (int i = 0; i < fruits.Count; i++) //it loops through the list as many times as many strings there are in the list
            {
                if (fruits[i] == fruitSearch) //if the user input equals any words in the list, do this:
                {
                    Console.WriteLine("The fruit " + fruitSearch + " appears " + count + " times in the list. The index is: " + i);
                }
                else //otherwise do this:
                {
                    Console.WriteLine("There is no match.");
                }
            }




            //Part Six Assignment
            Console.WriteLine("\nPart 6:");

            //Create a foreach loop that evaluates each item in the list, and displays a message showing the string
            //and whether or not it has already appeared in the list.

            List<string> veggies = new List<string>() { "spinach", "celery", "spinach", "cucumber", "squash", "celery", "asparagus", "cucumber", "kale" }; //"veggies" is a list of strings

            foreach (string veggie in veggies) //loops through the veggies list
            {
                int word = veggies.Where(x => x.Equals(veggie)).Count(); //counts how many times each string appears in the veggies list and puts the number into the word variable

                if (word == 1) //if a word appears one time, do this:
                {
                    Console.WriteLine("The item " + veggie + " is unique.");
                }
                else if (word == 2) //if a word appears two times, do this:
                {
                    Console.WriteLine("The item " + veggie + " is a duplicate.");
                }
            }

            Console.ReadLine();
        }
    }
}
