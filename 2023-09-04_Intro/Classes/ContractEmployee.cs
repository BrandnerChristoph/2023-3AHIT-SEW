using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_09_04_Intro.Classes
{
    public class ContractEmployee : Employee
    {
        #region Instanzvariablen
        private double dailyRate;
        #endregion

        #region Zugriffsmethoden
        public void setDailyRate(double dailyRate)
        {
            this.dailyRate = dailyRate;
        }
        public double getDailyRate()
        {
            return this.dailyRate;
        }
        #endregion

        #region Konstruktor
        public ContractEmployee() : this("unknown", "unknown", 0)
        {            
        }
        public ContractEmployee(string firstName, string lastName, double dailyRate) : base(firstName, lastName) {
            this.dailyRate = dailyRate;
        }
        #endregion

        #region Methoden
        public override string ToString()
        {
            return $"{base.ToString()}, Daily Rate: € {string.Format("{0:0.00}", this.dailyRate)}";
        }

        public override double calculateHourlyRate()
        {
            return this.getDailyRate() / Globals.DEFAULT_WORK_HOURS_PER_DAY;
        }
        #endregion
    }
}
