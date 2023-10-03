using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphismus.Classes
{
    class MyClass
    {
        public string GetInfo()
        {
            return "Die Methode wurde in der Klasse " + this.GetType().Name;
        }
        public string Test()
        {
            return this.GetInfo() + " / Parameter: keine";
        }
    }

    class SubClass : MyClass { 
        public string Test(int i)   
        {
            return base.GetInfo() + " Parameter: int (Wert: " + i + ")";
        }
        public string Test(string str) 
        {
            return base.GetInfo() + " Parameter: string (Wert: " + str + ")";
        }
    }
}
