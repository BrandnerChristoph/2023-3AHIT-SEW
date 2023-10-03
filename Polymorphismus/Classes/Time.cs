using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphismus.Classes
{
    abstract class Time
    {
        protected DateTime DatumZeit{ get; set;}
        abstract public string GetTime();
    }
    class Time12Format : Time
    {
        public override string GetTime() 
        {
            DatumZeit  = DateTime.Now;
            return DatumZeit.ToString("hh:mm"); 
        }
    }
    class Time24Format : Time
    {
        public override string GetTime()    
        {
            DatumZeit = DateTime.Now;
            return DatumZeit.ToShortTimeString();
        }
    }
}
