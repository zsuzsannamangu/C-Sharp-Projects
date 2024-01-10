using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace iterationAssignment.cs
{
    class Program
    {
        static void Main()
        {

            //Part One Assignment
            Console.WriteLine("Part 1:");

            string[] favAnimals = { "giraffe", "lion", "leopard", "elephant" }; //This is an array of unique strings

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

            //Create a list of strings where each item in the list is unique. Ask the user to input text to search for in the list.
            //Create a loop that iterates through the list and then displays the index of the list item that contains matching text on the screen.
            //Check if the user put in text that isn't on the list and, if they did, tell the user their input is not on the list.
            //Stop the loop from executing once a match has been found.

            List<string> names = new List<string>() { "Jesse", "Bob", "Kristi", "Leo" }; //"names" is a list of strings
            Console.WriteLine("Search for a name on the list:"); //user is prompted to enter a name

            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo; //create a TextInfo object for capitalizing the user entry, the TextInfo class is part of the System.Globalization namespace
            string nameSearch = textInfo.ToTitleCase(Console.ReadLine()); //the user entry is capitalized with the ToTitleCase method of the TextInfo class and saved in the string "nameSearch"
                                                                          //The ToTitleCase method converts the first character of each word in a string to uppercase, and the rest to lowercase.
            Console.WriteLine("You are searching for: " + nameSearch);

            int index = -1; //start with index at -1 which is equivalent to "not found" since there is no index -1
            for (int k = 0; k < names.Count; k++) //for loop
            {
                if (names[k] == nameSearch) //if searched name is equal to name at a specific index
                {
                    index = k; //index becomes the index where that name is 
                    break; //exit the loop since name has been found
                }
            }

            if (index == -1) //if name hasn't been found
            {
                Console.WriteLine("That is not on the list."); //write this message
            }
            else //otherwise, if name has been found, write this message:
            {
                Console.WriteLine("That name is found at index " + index + ".");
            }

            //Solution without a foor loop:
            //Although this will treat pineapple and apple the same if the search is for apple
            //bool searchResult = names.Contains(nameSearch);
            //if (searchResult == true)
            //{
            //    Console.WriteLine("That name is on the list.");
            //    int index = names.IndexOf(nameSearch);
            //    Console.WriteLine("The index is: " + index);
            //}
            //else
            //{
            //    Console.WriteLine("That name is not on the list.");
            //}




            //Part Five Assignment
            Console.WriteLine("\nPart 5:");

            //Create a list of strings that has at least two identical strings in the list. Ask the user to select text to search for in the list.
            //Create a loop that iterates through the list and then displays the indices of the items matching the user-selected text.
            //Add code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list.
            //(It does not provide any additional chances for the user to enter text.)

            List<string> fruits = new List<string>() { "papaya", "orange", "banana", "apple", "apple", "blueberry", "orange", "mango", "blueberry", "orange" }; //"fruits" is a list of strings

            Console.WriteLine("List of fruits: " + string.Join(" ", fruits));
            Console.WriteLine("Select text to search for in the list: "); //user is prompted to select a fruit
            string fruitSearchAsIs = Console.ReadLine();
            string fruitSearch = fruitSearchAsIs.ToLower(); //user input is saved in the "fruitSearch" string and coverted into lower case

            int count = fruits.Where(x => x.Equals(fruitSearch)).Count(); //it counts how many times the word that the user entered appears on the list, that number is saved in the "count" variable
                                                                          //to be able to use Where() you need to add "using System.Linq;"

            List<int> countIndexes = new List<int>(); //this is an empty list to save into the indices of strings later

            for (int i = 0; i < fruits.Count; i++) //it loops through the list as many times as many strings there are on the list
            {
                if (fruits[i] == fruitSearch && count == 1) //if the user input equals any words on the list and that word only occurs once, do this:
                {
                    Console.WriteLine("The fruit " + fruitSearch + " was found at index " + i + "."); //display this message, which has the name of the fruit and its index
                    break; //exit the loop
                }
                else if (fruits[i] == fruitSearch && count > 1) //if the user input has been found on the list multiple times, do:
                {
                    countIndexes.Add(i); //add the indices of that string into the countIndexes list
                }
            }

            if (count == 0) //if user input hasn't been found
            {
                Console.WriteLine("That is not on the list."); //write this message
            }

            else if (countIndexes.Count > 1) //else if that fruit has been found multiple times, because the list countIndexes have multiple numbers in it
            {
                Console.WriteLine("The fruit " + fruitSearch + " is on the list multiple times."); //display this message
                Console.WriteLine("Its indices are: " + string.Join(" ", countIndexes)); //and then show this message with the indices displaying horizontally
            }




            //Part Six Assignment
            Console.WriteLine("\nPart 6:");

            //Create a foreach loop that evaluates each item on the list, and displays a message showing the string
            //and whether or not it has already appeared on the list.

            List<string> veggies = new List<string>() { "Spinach", "Celery", "Spinach", "Cucumber", "Squash", "Celery", "Asparagus", "Cucumber", "Kale", "Celery" }; //"veggies" is a list of strings

            HashSet<string> newList = new HashSet<string>(); //using HashSet<> here instead of List as HashSet can only contain unique elements, so inserting duplicates are prevented automatically
                                                //the variable "set" is a HashSet = an unordered collection of unique strings
            foreach (string veggie in veggies) //a foreach loop will iterate through the veggies list, we are referring to each item on the list with the word "veggie"
            {
                if (!newList.Add(veggie)) //newList.Add(veggie) adds all items to the HashSet only once, each appears only once, so then
                                            //!newList.Add(veggie) has all other items in order of appearance: spinach, celery, cucumber, celery -> celery appeard 3x
                                            //so if that veggie wasn't added to newList (again), it is its second or third, etc. appearance
                {
                    Console.WriteLine(veggie + " appeared more than once.");
                }
                else //otherwise, it is it's first appearance on the list
                {
                    Console.WriteLine(veggie + " appears for the first time.");
                }
            }

            Console.ReadLine();
        }
    }
}