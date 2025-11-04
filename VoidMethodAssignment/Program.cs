using System;

namespace VoidMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of MathOperations class
            MathOperations math = new MathOperations();

            // Call method with two numbers
            math.DoMath(5, 10);

            // Call method again, using named parameters
            math.DoMath(number1: 8, number2: 3);

            // Keep window open
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
