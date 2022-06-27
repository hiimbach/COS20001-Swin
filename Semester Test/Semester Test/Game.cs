using System;
using System.Collections.Generic;
using System.Text;

namespace Semester_Test
{
    internal class Game:LibraryResource
    {

        public Game(string name, string developer, string contentRating):base(name, developer, contentRating)
        {

        }

        public string ContentRating
        {
            get { return Code; }
        }

    }
}
