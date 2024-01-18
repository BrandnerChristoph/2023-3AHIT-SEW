using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymInterface.Classes
{
    public class Person : IValueProvider
    {
        public int Height { get; set; }

        public Person(int height) {
            this.Height = height;
        }
        public double GetValue()
        {
            return this.Height;
        }
    }
}
