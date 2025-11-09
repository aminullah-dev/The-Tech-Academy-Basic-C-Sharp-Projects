using System;

// Class Employee inherits from Person
public class Employee : Person
{
    // Implement the SayName method
    public override void SayName()
    {
        // Show full name in console
        Console.WriteLine("Name: " + firstName + " " + lastName);
    }
}
