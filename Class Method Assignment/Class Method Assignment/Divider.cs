using System;

// This class can be instantiated (we will create an object from it)
public class Divider
{
    // This is a void method with an output parameter (out)
    // It takes an int and puts the result (number / 2) into 'result'
    public void DivideByTwo(int number, out int result)
    {
        result = number / 2; // simple math: divide by 2
    }

    // OVERLOAD of the same method name
    // This overload takes a string, converts it to int, then divides by 2
    public void DivideByTwo(string numberText, out int result)
    {
        // Convert string to int (simple version for this assignment)
        int parsed = Convert.ToInt32(numberText);
        result = parsed / 2;
    }
}
