using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymInterface.Classes
{
    public class Mirror : Furniture
    {
        public Mirror(int length, int height)
        {
            this.Length = length;
            this.Height = height;
        }

        public override double GetValue()
        {
            return Math.Max(this.Height, this.Length);
        }
    }
}
