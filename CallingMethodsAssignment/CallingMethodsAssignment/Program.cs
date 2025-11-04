using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int userNumber = Convert.ToInt32(Console.ReadLine());

        MathOperations mathOps = new MathOperations();

        int result1 = mathOps.MultiplyByTwo(userNumber);
        Console.WriteLine("Your number multiplied by 2 is: " + result1);

        int result2 = mathOps.SquareNumber(userNumber);
        Console.WriteLine("Your number squared is: " + result2);

        int result3 = mathOps.AddTen(userNumber);
        Console.WriteLine("Your number plus 10 is: " + result3);

        Console.WriteLine("All done! Press any key to exit.");
        Console.ReadKey();
    }
}
