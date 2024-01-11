using System;

namespace Class_Assignment.cs
{
    class Division
    {
        public void DivideNumbers(int num) //created a method with one parameter that won't return a value
        {
            int numResult = num / 2;
            Console.WriteLine("Your number divided by 2 is " + numResult + ".");
        }

        //A method with output parameters:
        public void DivisionTwo(out int num2)
        {
            num2 = 20;
            int num3 = num2 / 1;
            Console.WriteLine("20 / 1 = " + num3);
        }

        //overload method:
        //a method that exists in the same class with the same name as another one but with some differences
        public void DivideNumbers(decimal decNum) //this DivideNumbers method takes a decimal instead of an integer
        {
            int decNumInt = Convert.ToInt32(decNum); //decimal is converted into integer
            int decNumResult = decNumInt / 3;
            int decNumRemainder = decNumInt % 3;
            Console.WriteLine(decNumInt + " divided by 3 is " + decNumResult + " and the remainder is " + decNumRemainder + ".");
        }
    }
}

//Proper way to name a method:
//Use verbs or verbs followed by adjectives or nouns.
//Use PascalCase for method names. Start each subsequent word with an uppercase character.
//Describe the purpose of the method with its name.
//Use maximum 7 parameters in a method
