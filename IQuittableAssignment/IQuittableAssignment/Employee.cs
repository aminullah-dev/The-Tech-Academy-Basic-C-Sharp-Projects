using System;

// Employee inherits from Person and also implements IQuittable
public class Employee : Person, IQuittable
{
    // Simple Id for employee
    public int Id { get; set; }

    // Implement SayName from Person
    public override void SayName()
    {
        // Print full name
        Console.WriteLine("Name: " + FirstName + " " + LastName);
    }

    // Implement Quit from IQuittable
    public void Quit()
    {
        // Simple quit message
        Console.WriteLine("Employee " + FirstName + " " + LastName + " has quit the job.");
    }
}
