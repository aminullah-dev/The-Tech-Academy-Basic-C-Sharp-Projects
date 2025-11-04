using System;

namespace MethodAssignment
{
    public class MathOperation1
    {
        // This method takes two integers, one optional (default = 5)
        public int AddNumbers(int num1, int num2 = 5)
        {
            // Add the two numbers and return the result
            return num1 + num2;
        }
    }
}
