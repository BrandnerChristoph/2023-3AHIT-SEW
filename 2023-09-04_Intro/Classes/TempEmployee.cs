using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_09_04_Intro.Classes
{
    public class TempEmployee : Employee
    {
        #region Instanzvariablen
        private double hourlyRate;
        #endregion

        #region Zugriffsmethoden
        public void setHourlyRate(double hourlyRate)
        {
            this.hourlyRate = hourlyRate;
        }
        public double getHourlyRate()
        {
            return this.hourlyRate;
        }
        #endregion

        #region Konstruktor
        public TempEmployee() : this("unknown", "unknown", 0)
        {            
        }
        public TempEmployee(string firstName, string lastName, double hourlyRate) : base(firstName, lastName) {
            this.hourlyRate = hourlyRate;
        }
        #endregion

        #region Methoden
        public override string ToString()
        {
            return $"{base.ToString()}, Hourly Rate: € {string.Format("{0:0.00}", this.hourlyRate)}";
        }

        public override double calculateHourlyRate()
        {
            return this.getHourlyRate();
        }
        #endregion
    }
}
