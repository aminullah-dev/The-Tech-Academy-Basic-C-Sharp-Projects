using System;

namespace MethodsAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an Employee object
            Employee employee = new Employee();

            // Set first and last name
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.Id = 1;

            // Call SayName() method (inherited from Person)
            employee.SayName();

            Console.ReadLine();
        }
    }
}
