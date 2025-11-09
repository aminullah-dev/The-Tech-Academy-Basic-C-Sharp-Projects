using System;

// This is a simple base class for a person
public abstract class Person
{
    // First name of the person
    public string FirstName { get; set; }

    // Last name of the person
    public string LastName { get; set; }

    // This method will be implemented by child classes
    public abstract void SayName();
}
