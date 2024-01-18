using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Book
    {
        public Book (string title) : this (title, 14) //creates constructor that inherits from the previous constructor, if users don't provide a reading time, assign 14 (days) automatically
        {
        }

        public Book (string title, int readingTime) //creates constructor with 2 parameters, title and reading time
        {
            Title = title;
            ReadingTime = readingTime;
        }
        public string Title { get; set; } //sets properties Title and ReadingTime
        public int ReadingTime { get; set; }
    }
}
