using System;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print program title
            Console.WriteLine("Anonymous Income Comparison Program");

            // Person 1
            Console.WriteLine("Person 1");
            Console.Write("Hourly Rate? ");
            decimal hourlyRate1 = Convert.ToDecimal(Console.ReadLine()); // get hourly rate
            Console.Write("Hours worked per week? ");
            int hoursPerWeek1 = Convert.ToInt32(Console.ReadLine()); // get weekly hours

            // Person 2
            Console.WriteLine("Person 2");
            Console.Write("Hourly Rate? ");
            decimal hourlyRate2 = Convert.ToDecimal(Console.ReadLine()); // get hourly rate
            Console.Write("Hours worked per week? ");
            int hoursPerWeek2 = Convert.ToInt32(Console.ReadLine()); // get weekly hours

            // Calculate annual salaries
            decimal annualSalary1 = hourlyRate1 * hoursPerWeek1 * 52; // person 1 salary
            decimal annualSalary2 = hourlyRate2 * hoursPerWeek2 * 52; // person 2 salary

            // Print results
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(annualSalary1);

            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(annualSalary2);

            // Compare salaries
            Console.WriteLine("Person 1 makes more money than Person 2");
            Console.WriteLine(annualSalary1 > annualSalary2); // true or false

            // Keep console open until user presses enter
            Console.ReadLine();
        }
    }
}
