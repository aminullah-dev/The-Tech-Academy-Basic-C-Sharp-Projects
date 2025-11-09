using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an Employee object
        Employee employee = new Employee();

        // Set first and last name
        employee.firstName = "Sample";
        employee.lastName = "Student";

        // Call SayName() method
        employee.SayName();

        Console.ReadLine();
    }
}
