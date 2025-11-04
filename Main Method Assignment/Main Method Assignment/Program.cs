using System;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of the MathMethods class
            MathMethods math = new MathMethods();

            // Call the first method (integer)
            int result1 = math.DoMath(10);
            Console.WriteLine("Result from int method: " + result1);

            // Call the second method (decimal)
            int result2 = math.DoMath(12.5m);
            Console.WriteLine("Result from decimal method: " + result2);

            // Call the third method (string)
            int result3 = math.DoMath("20");
            Console.WriteLine("Result from string method: " + result3);

            // Pause the console so the window does not close immediately
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
