
namespace Main_Method_Assignment.cs
{
    class Operations
    {
        //We defined 3 versions of the MathOperations method.
        //C# allows to use the same name for methods that are similar as long as they are somewhat different -> they all take in a different parameter.
        public static int MathOperations(int number) //The first MathOperations method takes an integer as a parameter
        {
            return 12 - number; //number is defined at Program.cs
        }
        public static decimal MathOperations(decimal decNumber) //The second MathOperations method takes a decimal (a number that can be up to 29 digits in length) as a parameter
        {
            return 2 * decNumber; //decNumber is defined at Program.cs
        }
        public static string MathOperations(string stringNumber) //The third MathOperations method takes a string as a parameter
        {
            return 12 + stringNumber; //stringNumber is defined at Program.cs
        }

    }
}
