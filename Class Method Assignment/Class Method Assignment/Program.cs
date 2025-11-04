using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate the Divider class (create an object)
        Divider divider = new Divider();

        // Ask the user to enter a number
        Console.Write("Enter a whole number: ");
        string input = Console.ReadLine(); // read text

        // Try to use the INT overload first (when input is a valid int)
        // If input is not a valid int, we will call the STRING overload
        int numberValue;
        int half; // this will receive the output (via out)

        if (int.TryParse(input, out numberValue))
        {
            // Call the void method with OUT parameter (int version)
            divider.DivideByTwo(numberValue, out half);

            // Show the output (the entered number divided by two)
            Console.WriteLine("Half of " + numberValue + " is: " + half);
        }
        else
        {
            // Call the overload that accepts string (it converts inside)
            divider.DivideByTwo(input, out half);

            // Show the output (the entered text converted to int, then /2)
            Console.WriteLine("Half (after converting your text) is: " + half);
        }

        // Use a STATIC class method (just to show we declared a static class)
        Utils.Line();
        Console.WriteLine("Done. Press any key to exit.");
        Console.ReadKey();
    }
}
