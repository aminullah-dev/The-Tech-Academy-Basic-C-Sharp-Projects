using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an Employee object and set basic data
        Employee emp = new Employee();
        emp.FirstName = "Sample";
        emp.LastName = "Student";
        emp.Id = 1001;

        // Call method from Person (inherited) to show full name
        emp.SayName();

        // Polymorphism with interface:
        // We use the interface type IQuittable, but object is Employee
        IQuittable quitter = emp;

        // Call Quit() using the interface reference
        quitter.Quit();

        // Keep console window open
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
