﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymInterface.Classes
{
    public class Table : Furniture
    {
        public int Width { get; set; }

        public Table(int length, int width, int height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public override double GetValue()
        {
            return Math.Max(Math.Max(Length, Height), Width);
        }
    }
}
