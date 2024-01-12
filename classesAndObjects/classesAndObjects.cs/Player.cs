using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesAndObjects.cs
{
    class Player
    {
        public List<Card> Hand { get; set; } //it is the player's cards
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
}
}
