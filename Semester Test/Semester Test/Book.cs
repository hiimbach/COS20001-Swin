using System;
using System.Collections.Generic;
using System.Text;

namespace Semester_Test
{
    internal class Book:LibraryResource
    {

        public Book(string name, string author, string isbn):base(name, author, isbn)
        {

        }

        public string ISBN { get { return Code; } }
    }
}
