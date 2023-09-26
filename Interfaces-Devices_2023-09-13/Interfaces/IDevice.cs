﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Devices_2023_09_13.Interfaces
{
    public interface IDevice
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsPoweredOn { get; set; }

        bool IsAvailable(); 

    }
}
