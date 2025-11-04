using System;

namespace MainMethodAssignment
{
    public class MathMethods
    {
        // This method takes an integer number
        // It adds 10 to the number and returns the result
        public int DoMath(int number)
        {
            return number + 10;
        }

        // This method takes a decimal number
        // It multiplies the number by 2 and returns the result as an integer
        public int DoMath(decimal number)
        {
            return Convert.ToInt32(number * 2);
        }

        // This method takes a string number
        // It converts the string to integer, subtracts 5, and returns the result
        public int DoMath(string number)
        {
            int num = Convert.ToInt32(number);
            return num - 5;
        }
    }
}
