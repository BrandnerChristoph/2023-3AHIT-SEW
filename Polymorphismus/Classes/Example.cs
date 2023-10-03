using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphismus.Classes
{
    internal class Example : Basis
    {
        internal double Plus(int s, int t) // Überladen
        {
            return this.Plus((double)s, (double)t);
        }

        internal double Plus(double s, double t)  // Überladen
        {
            return s + t;
        }
        internal double Plus(int i)  // Überladen
        {
            return this.Plus(i, i);
        }
        public  new string Minus(string s) // Verbergen
        {
            return "";
        }
        public override char Operator() {  return '+'; }  // Abstraktion

        public override bool IsDone() { return true; } // Überschreiben
    }

    /// <summary>
    ///  Basisklasse
    /// </summary>
    internal abstract class Basis
    {
        internal double Minus(string s)
        {
            return 0;
        }
        public virtual bool IsDone() { return false; }
        public abstract char Operator();
    }
}
