

namespace Classes_and_Methods_Assignment.cs
{
    public class Math //A public class is accessible to all parts of the program
    {
        public static int Addition(int userNum) //Addition is a method of the Math class and it takes one parameter: the integer userNum. The value of userNum will be at Program.cs.
        {
            return 5 + userNum; //Addition will return an integer that is 5 + userNum. userNum is the number the user entered.
        }

        public static int Subtraction(int userNum)
        {
            return 10 - userNum; //The Subtraction method will return 10 minus the user entry: userNum
        }

        public static int Multiplication(int userNum)
        {
            return 2 * userNum; //The Multiplication method will return 2 times the user entry: userNum
        }
    }
}
