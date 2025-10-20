using System;
using System.Text;   // Needed for StringBuilder

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Combine (concatenate) three strings into one sentence
            string first = "Hello";
            string second = " from";
            string third = " C# programming!";
            string message = first + second + third;
            Console.WriteLine(message);

            // Convert a string to uppercase
            string upperMessage = message.ToUpper();
            Console.WriteLine(upperMessage);

            // Create a StringBuilder to build a paragraph
            StringBuilder paragraph = new StringBuilder();

            // Add sentences one by one
            paragraph.Append("This is my first sentence. ");
            paragraph.Append("Here comes the second sentence. ");
            paragraph.Append("Finally, this is the last one!");

            // Print the full paragraph
            Console.WriteLine(paragraph);

            Console.ReadLine(); // Keeps the console window open
        }
    }
}
