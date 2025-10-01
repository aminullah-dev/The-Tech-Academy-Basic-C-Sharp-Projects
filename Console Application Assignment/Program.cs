using System;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user for a number and multiply by 50
            Console.WriteLine("Enter a number:");
            long num1 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Result: " + (num1 * 50));

            // Ask user for a number and add 25
            Console.WriteLine("Enter a number:");
            long num2 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Result: " + (num2 + 25));

            // Ask user for a number and divide by 12.5
            Console.WriteLine("Enter a number:");
            double num3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Result: " + (num3 / 12.5));

            // Ask user for a number and check if greater than 50
            Console.WriteLine("Enter a number:");
            int num4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Greater than 50? " + (num4 > 50));

            // Ask user for a number and show remainder after dividing by 7
            Console.WriteLine("Enter a number:");
            int num5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Remainder: " + (num5 % 7));

            // End program
            Console.WriteLine("Done. Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
