using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Display welcome message
        Console.WriteLine("Console App Array Assignment");

        // ----- Part 1: String Array -----
        string[] stringArray = { "Apple", "Banana", "Cherry", "Mango", "Orange" };

        Console.WriteLine("\nSelect an index (0 to 4) to see the fruit:");
        int stringIndex = Convert.ToInt32(Console.ReadLine());

        // Check if the entered index exists
        if (stringIndex >= 0 && stringIndex < stringArray.Length)
        {
            Console.WriteLine("You selected: " + stringArray[stringIndex]);
        }
        else
        {
            Console.WriteLine("That index does not exist.");
        }

        // ----- Part 2: Integer Array -----
        int[] intArray = { 10, 20, 30, 40, 50 };

        Console.WriteLine("\nSelect an index (0 to 4) to see the number:");
        int intIndex = Convert.ToInt32(Console.ReadLine());

        // Check if the entered index exists
        if (intIndex >= 0 && intIndex < intArray.Length)
        {
            Console.WriteLine("You selected: " + intArray[intIndex]);
        }
        else
        {
            Console.WriteLine("That index does not exist.");
        }

        // ----- Part 3: List of Strings -----
        List<string> stringList = new List<string>() { "Red", "Blue", "Green", "Yellow", "Purple" };

        Console.WriteLine("\nSelect an index (0 to 4) to see the color:");
        int listIndex = Convert.ToInt32(Console.ReadLine());

        // Check if the entered index exists
        if (listIndex >= 0 && listIndex < stringList.Count)
        {
            Console.WriteLine("You selected: " + stringList[listIndex]);
        }
        else
        {
            Console.WriteLine("That index does not exist.");
        }

        // End message
        Console.WriteLine("\nThank you! Press any key to exit.");
        Console.ReadKey();
    }
}
