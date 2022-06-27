using System;
using System.Collections.Generic;
using System.Text;

namespace Semester_Test
{
    internal abstract class LibraryResource
    {
        string _name, _developer, _code;
        bool _onLoan;

        public LibraryResource(string name, string developer, string code)
        {
            _name = name;
            _developer = developer;
            _code = code;
            _onLoan = false;
        }

        public string Name { get { return _name; } }
        public string Developer { get { return _developer; } }
        public string Code { get { return _code; } }
        public bool OnLoan { get { return _onLoan; } set { _onLoan = value; } }
    }
}
