using System;

namespace VoidMethodAssignment
{
    // This class has our void method
    class MathOperations
    {
        // This is a void method that takes two integers
        public void DoMath(int number1, int number2)
        {
            // Multiply the first number by 2
            int result = number1 * 2;

            // Show the result
            Console.WriteLine("Result of first number * 2 is: " + result);

            // Show the second number
            Console.WriteLine("The second number is: " + number2);
        }
    }
}
