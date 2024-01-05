using System;
using System.Collections.Generic;

namespace arrayApp.cs
{
    class Program
    {
        static void Main()
        {
            string[] stringArray = { "apple", "banana", "orange", "mango", "raspberry" }; //Creates a one - dimensional Array of strings.
            //Display the whole content of the array on the screen:
                //foreach (var fruit in stringArray)
                //{
                //    Console.WriteLine(fruit.ToString());
                //}
            Console.WriteLine("Select a number from 0 to 4 to see your fruit:"); //Asks the user to select an index of the Array
            int selectedNumber = Convert.ToInt32(Console.ReadLine()); //The user response is stored in the variable selectedNunmber
            if (selectedNumber < 0 || selectedNumber > 4)
            {
                while (selectedNumber < 0 || selectedNumber > 4)
                {
                    Console.WriteLine("That number doesn't exist."); //Add in a message that displays when the user selects an index that doesn’t exist.
                    Console.WriteLine("Select a number from 0 to 4 to see your fruit:");
                    selectedNumber = Convert.ToInt32(Console.ReadLine());
                    if (selectedNumber >= 0 && selectedNumber <= 4)
                    {
                        Console.WriteLine("Your fruit: " + stringArray[selectedNumber]); //Displays the string at that index on the screen
                    }
                }
            }
            else
            {
                Console.WriteLine("Your fruit: " + stringArray[selectedNumber]); //Displays the string at that index on the screen
            }
  

            int[] intArray = { 2, 4, 8, 16, 32 }; //Creates a one - dimensional Array of integers.
            Console.WriteLine("Select a number from 0 to 4 to see your number:"); //Asks the user to select an index of the Array
            int selectedNo = Convert.ToInt32(Console.ReadLine()); //The user response is stored in the variable selectedNo
            if (selectedNo < 0 || selectedNo > 4)
            {
                while (selectedNo < 0 || selectedNo > 4)
                {
                    Console.WriteLine("That number doesn't exist."); //Add in a message that displays when the user selects an index that doesn’t exist.
                    Console.WriteLine("Select a number from 0 to 4 to see your number:");
                    selectedNo = Convert.ToInt32(Console.ReadLine());
                    if (selectedNo >= 0 && selectedNo <= 4)
                    {
                        Console.WriteLine("Your number: " + intArray[selectedNo]); //Displays the number at that index on the screen
                    }
                }
            }
            else
            {
                Console.WriteLine("Your number: " + intArray[selectedNo]); //Displays the number at that index on the screen
            }
            

            List<string> stringList = new List<string> { "dog", "cat", "hamster", "snake", "fish" }; //Creates a list of strings
            Console.WriteLine("Select a number from 0 to 4 to see your pet:"); //asks user to select an index of the list
            int selectedPet = Convert.ToInt32(Console.ReadLine()); //stores that number in a variable
            if (selectedPet < 0 || selectedPet > 4)
            {
                while (selectedPet < 0 || selectedPet > 4)
                {
                    Console.WriteLine("That number doesn't exist."); //Add in a message that displays when the user selects an index that doesn’t exist.
                    Console.WriteLine("Select a number from 0 to 4 to see your pet:");
                    selectedPet = Convert.ToInt32(Console.ReadLine());
                    if (selectedPet >= 0 && selectedPet <= 4)
                    {
                        Console.WriteLine("Your pet: " + stringList[selectedPet]); //displays content at that index on the screen
                    }
                }
            }
            else
            {
                Console.WriteLine("Your pet: " + stringList[selectedPet]); //displays content at that index on the screen
            }

            Console.WriteLine("Thanks for playing! Goodbye!");
            Console.ReadLine();
        }
    }
}
