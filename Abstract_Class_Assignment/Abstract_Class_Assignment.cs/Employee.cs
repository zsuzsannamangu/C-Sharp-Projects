

namespace Abstract_Class_Assignment.cs
{
    public class Employee : Person //The Employee class is inheriting from the Person class
    {
        public override void SayName() //As it is inheriting from the Person class, it must have a SayName() method
                                        //To override this method it must contain the override keyword
        {
            FirstName = "John"; //We set values to the two properties in the Person class
            LastName = "Smith";
        }
    }
}
