using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // list of integers
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

        // ask user for a number
        Console.WriteLine("Enter a number to divide each item in the list by:");
        string input = Console.ReadLine(); // read as string

        try
        {
            // convert to int
            int divisor = Convert.ToInt32(input);

            // divide each number and print
            foreach (int n in numbers)
            {
                int result = n / divisor; // may throw DivideByZeroException
                Console.WriteLine(n + " / " + divisor + " = " + result);
            }
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: You cannot divide by zero.");
            Console.WriteLine("System says: " + ex.Message);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: Please enter a valid whole number.");
            Console.WriteLine("System says: " + ex.Message);
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Error: The number is too large or too small.");
            Console.WriteLine("System says: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error: " + ex.Message);
        }

        // prove program continues
        Console.WriteLine("The program finished the try/catch block and kept going.");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
