using Interfaces_Devices_2023_09_13.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Devices_2023_09_13.Classes
{
    public class Printer : IPrintable
    {        
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsPoweredOn { get; set; }
        public bool IsTonerAvailable { get; set; }

        public Printer(string name, string description = null, bool isPoweredOn = false, bool isTonerAvailable = false)
        {
            this.Name = name;
            this.Description = description;
            IsPoweredOn = isPoweredOn;
            IsTonerAvailable = isTonerAvailable;
        }
        public bool IsAvailable()
        {
            if (IsPoweredOn && IsTonerAvailable)
                return true;
            return false;
        }

        public void Print()
        {
            try {
                if (!this.IsAvailable())
                    throw new Exception("Das Dokument wurde NICHT gedruckt!");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Das Dokument wurde gedruckt!");
            } catch (Exception e) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ResetColor();
            }            
        }
    }
}
