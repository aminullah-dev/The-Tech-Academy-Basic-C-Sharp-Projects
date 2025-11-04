using System;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of the MathOperation1 class
            MathOperation1 math = new MathOperation1();

            // Ask the user to enter the first number
            Console.WriteLine("Enter the first number:");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            // Ask the user to enter the second number (optional)
            Console.WriteLine("Enter the second number (or press Enter to skip):");
            string secondInput = Console.ReadLine();

            int result;

            // If user leaves the second input empty, call method with one parameter
            if (string.IsNullOrEmpty(secondInput))
            {
                result = math.AddNumbers(firstNum);
            }
            else
            {
                int secondNum = Convert.ToInt32(secondInput);
                result = math.AddNumbers(firstNum, secondNum);
            }

            // Show the result
            Console.WriteLine("The result is: " + result);

            // Pause the console
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
