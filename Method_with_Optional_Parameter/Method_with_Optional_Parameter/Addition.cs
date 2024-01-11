

namespace Method_with_Optional_Parameter
{
    class Addition
    {
        public int AdditionOperation(int num1, int num2 = 0) //The AdditionOperation method takes two integers as a parameter, the second is optional
                                                                    //When you assign a variable a default value, it makes it optional
        {
            return 8 + num1 + num2;
        }
    }
}
