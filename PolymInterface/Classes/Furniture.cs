using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymInterface.Classes
{
    public abstract class Furniture : IValueProvider
    {
        public int Length { get; set; }
        public int Height { get; set; }

        public abstract double GetValue();
    }
}
