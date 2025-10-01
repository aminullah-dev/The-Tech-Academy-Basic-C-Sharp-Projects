using System;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print school name
            Console.WriteLine("Academy of Learning Career College");

            // Print report title
            Console.WriteLine("Student Daily Report.");

            // Ask for name
            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            // Ask for course
            Console.Write("What course are you on? ");
            string course = Console.ReadLine();

            // Ask for page number
            Console.Write("What page number? ");
            int pageNumber = Convert.ToInt32(Console.ReadLine());

            // Ask if student needs help
            Console.Write("Do you need help with anything? Please answer true or false: ");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());

            // Ask about positive experience
            Console.Write("Were there any positive experiences you'd like to share? Please give specifics: ");
            string positiveExp = Console.ReadLine();

            // Ask for feedback
            Console.Write("Is there any other feedback you’d like to provide? Please be specific: ");
            string feedback = Console.ReadLine();

            // Ask for study hours
            Console.Write("How many hours did you study today? ");
            int hoursStudied = Convert.ToInt32(Console.ReadLine());

            // Thank the student
            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");

            // Keep console open
            Console.ReadLine();
        }
    }
}
