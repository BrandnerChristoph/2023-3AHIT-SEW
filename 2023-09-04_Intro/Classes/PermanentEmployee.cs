using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_09_04_Intro.Classes
{
    public class PermanentEmployee : Employee
    {
        #region Instanzvariablen
        private double salary;
        #endregion

        #region Zugriffsmethoden
        public void setSalary(double salary)
        {
            this.salary = salary;
        }
        public double getSalary()
        {
            return this.salary;
        }
        #endregion

        #region Konstruktor
        public PermanentEmployee() : this("unknown", "unknown", 0)
        {            
        }
        public PermanentEmployee(string firstName, string lastName, double salary) : base(firstName, lastName) {
            this.salary = salary;
        }
        #endregion

        #region Methoden
        public override string ToString()
        {
            return $"{base.ToString()}, Salary: € {string.Format("{0:0.00}", this.salary)}";
        }

        public override double calculateHourlyRate()
        {
            return this.getSalary() / Globals.DEFAULT_WORK_HOURS_PER_DAY / Globals.DEFAULT_WORK_DAYS_PER_YEAR;
        }


        #endregion
    }
}
