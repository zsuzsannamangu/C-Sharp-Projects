using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame.cs
{
    class FraudException : Exception //inherits from Exception
    {
        public FraudException() //a constructor
            : base() { }  //inherits from base, which is Exception, the base constructor
        public FraudException(string message) //we are overloading the constructor method, it takes one argument
            : base(message) { }
    }
}
