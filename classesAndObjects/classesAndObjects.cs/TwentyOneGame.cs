using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesAndObjects.cs
{
    //to inherent from another class all you have to do is put : and name of the class you inherit from
    public class TwentyOneGame : Game
    {
        public void Play() //this method is specific only to TwentyOneGame class
        {
            throw new NotImplementedException(); //this error message is if we call this method = we don't want to call it
        }
    }
}
