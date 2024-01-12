

namespace Abstract_Class_Assignment.cs
{
    public abstract class Person //Created an abstract class called Person with two properties
                                    //Abstract classes are base classes that cannot be instantiated, they only meant to be inherited from
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public abstract void SayName(); //Created an abstract method within the abstract class "Person"
                                        //Abstract classes do not contain any implementation. It it only to say that all classes inheriting from this class, must have this method
    }
}
