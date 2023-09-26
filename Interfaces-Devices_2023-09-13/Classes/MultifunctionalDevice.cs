using Interfaces_Devices_2023_09_13.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Devices_2023_09_13.Classes
{
    public class MultifunctionalDevice : IPrintable, IScanable
    {
        public string Name { get; set; }
        public string Description { get; set ; }

        public bool IsPoweredOn { get ; set; }

        public MultifunctionalDevice(string name, string description = null, bool isPoweredOn = false) 
        {
            Name = name;
            Description = description;
            IsPoweredOn = isPoweredOn;
        }
        public bool IsAvailable()
        {
            return IsPoweredOn;
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public void Scan()
        {
            throw new NotImplementedException();
        }
    }
}
