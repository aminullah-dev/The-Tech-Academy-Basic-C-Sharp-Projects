using System;

namespace MethodsAndObjectsAssignment
{
    // This class represents a person with a first and last name
    public class Person
    {
        // Property for first name
        public string FirstName { get; set; }

        // Property for last name
        public string LastName { get; set; }

        // This method prints the full name
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
