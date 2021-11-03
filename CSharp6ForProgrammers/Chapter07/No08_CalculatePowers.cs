// Listing 7.8: CalculatePowers.cs
// Optional parameter demonstration with method Power.
using System;

class No08_CalculatePowers
{
    static void Main()
    {
        // Call Power with and without optional arguments
        Console.WriteLine($"Power(10) = {Power(10)}");
        Console.WriteLine($"Power(2, 10) = {Power(2, 10)}");
    }

    /** Use iteration to calculate power */
    static int Power(int baseValue, int exponentValue = 2)
    {
        int result = 1;

        for (int i = 0; i < exponentValue; i++)
        {
            result *= baseValue;
        }

        return result;
    }
}
