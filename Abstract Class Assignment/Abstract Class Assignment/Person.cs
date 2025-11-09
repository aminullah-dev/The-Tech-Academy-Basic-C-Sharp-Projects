using System;

// Create an abstract class called Person
public abstract class Person
{
    // Two string properties for first and last name
    public string firstName { get; set; }
    public string lastName { get; set; }

    // Abstract method (must be implemented by subclasses)
    public abstract void SayName();
}
