using _2023_09_04_Intro.Interfaces;

namespace _2023_09_04_Intro.Classes

{
    public abstract class Employee : IPayable
    {
        #region Instanzvariablen
        private string firstName;
        private string lastName;
        #endregion

        #region Zugriffsmethoden
        public void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }
        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public string getFirstName()
        {
            return firstName;
        }
        public string getLastName()
        {
            return lastName;
        }
        #endregion

        #region Konstruktor
        /*
         // nicht mehr möglich seit die Klasse zu einer abstrakten Klasse wurde
        public Employee()
        {
            new Employee("unknown", "unknown");
        }
        */
        public Employee(string firstName, string lastName)
        {
            setFirstName(firstName);
            setLastName(lastName);
        }
        #endregion


        #region Methoden
        public override string ToString()
        {
            return $"First Name: {getFirstName()}, Last Name: {getLastName()}";
        }

        public abstract double calculateHourlyRate();
        #endregion
    }
}
