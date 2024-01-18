using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperLib
{
    public class Person
    {
        public string Name { get; set; }
        public string Firstname { get; set; }
        public int Height { get; set; }

        public Person()
        {

        }

        public Person(string name, string firstname, int height)
        {
            Name = name;
            Firstname = firstname;
            Height = height;
        }

        public bool IsTall()
        {
            if (Height > 185)
                return true;
            return false;
        }
    }
}
