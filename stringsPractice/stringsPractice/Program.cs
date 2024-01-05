using System;
using System.Text;

namespace stringsPractice
{
    class Program
    {
        static void Main()
        {
            string name1 = "Jarred";
            string name2 = "Jason";
            string name3 = "Smith";
            string newName1 = name1.ToUpper(); //Converts a string to uppercase.
            string result = newName1 + " " + name2 + " " + name3; //Concatenates three strings.
            Console.WriteLine(result);

            StringBuilder myStringBuilder = new StringBuilder("The object is immutable. "); //Creates a Stringbuilder and builds a paragraph of text, one sentence at a time.
            myStringBuilder.Append("Every time you want to modify it, you create a new string object in memory. ");
            myStringBuilder.Insert(4, "String "); //Inserts a word into the fourth position of a StringBuilder object.
            myStringBuilder.Append("This requires a new allocation of space for that new object. That's why we use StringBuilders.");
            Console.WriteLine(myStringBuilder);

            Console.Read();
        }
    }
}
