using _2023_09_04_Intro.Classes;
using System.Text;


Console.OutputEncoding = Encoding.UTF8; // UTF8 Encoding um das € Zeichen auf der Konsole auszugeben

/*
/////////////////////////////////////////////////////////////
// Aufgabe Teil 1
    Employee emp1 = new Employee();
    emp1.setFirstName("Hans");
    emp1.setLastName("Huber");
    Console.WriteLine("emp1: " + emp1.getLastName() + " " + emp1.getFirstName());
    Employee emp2 = new Employee("Barbara", "Schmidt");
    Console.WriteLine("emp2: " + emp2);
    Console.ReadLine();
*/

/////////////////////////////////////////////////////////////
// Aufgabe Teil 2
    PermanentEmployee pe = new PermanentEmployee();
    PermanentEmployee ce = new PermanentEmployee("Hans", "Huber", 100.0);
    PermanentEmployee te = new PermanentEmployee("Barbara", "Schmidt", 7.5);
    Console.WriteLine(pe);
    Console.WriteLine(ce);
    Console.WriteLine(te);
    Console.ReadLine();

/////////////////////////////////////////////////////////////
// Aufgabe Teil 3
    Employee[] f = new Employee[3];
    f[0] = new PermanentEmployee("Franz", "Schuster", 15000.0);
    f[1] = new ContractEmployee("Hans", "Huber", 100);
    f[2] = new TempEmployee("Barbara", "Schmidt", 7.5);

    string hourlyRate;
    foreach(Employee e in f)
    {
        Console.WriteLine(e);
        hourlyRate = e.calculateHourlyRate().ToString("f2");    // 2 float (Nachkommastellen)
        Console.WriteLine(" Hourly rate = " + hourlyRate);
    }
    Console.ReadLine ();
