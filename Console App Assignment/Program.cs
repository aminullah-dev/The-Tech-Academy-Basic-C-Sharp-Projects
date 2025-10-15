using System;

namespace LoopComparisonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print a title for the program
            Console.WriteLine("=== Boolean Comparison using While and Do-While Loops ===");

            // ---------------- WHILE LOOP ----------------
            // Initialize a variable
            int number = 0;

            // The while loop will continue as long as number is less than 5
            while (number < 5)
            {
                Console.WriteLine("While Loop Count: " + number);
                number++; // increase the value by 1 each time
            }

            Console.WriteLine("---------------------------");

            // ---------------- DO-WHILE LOOP ----------------
            // Reset the variable
            int count = 0;

            // The do-while loop runs the code at least once before checking the condition
            do
            {
                Console.WriteLine("Do-While Loop Count: " + count);
                count++; // increase the value by 1 each time
            }
            while (count < 5); // condition is checked after executing the loop body

            // End message
            Console.WriteLine("---------------------------");
            Console.WriteLine("Loop comparison complete. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
