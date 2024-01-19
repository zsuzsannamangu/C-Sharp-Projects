using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame.cs
{
    public class ExceptionEntity //when we call a class an entity we refer to a dB table, the class maps exactly to a dB 
    {
        public int Id { get; set; } //each property of the class = each column in the dB
        public string ExceptionType { get; set; }
        public string ExceptionMessage { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
