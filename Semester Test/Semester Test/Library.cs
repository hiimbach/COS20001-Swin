using System;
using System.Collections.Generic;
using System.Text;

namespace Semester_Test
{
    internal class Library
    {
        List<LibraryResource> _resources;

        public Library (string name)
        {
            _resources = new List<LibraryResource> ();
        }

        public void AddResource(LibraryResource resource)
        {
            _resources.Add(resource);
        }

        public bool HasResource(string name)
        {
            foreach (LibraryResource libre in _resources)
            {
                if (libre.Name == name && libre.OnLoan == false)
                {
                    return true;
                }
            }
            return false;
        }

    }


}
