// Listing 7.1: MaximumFinder.cs
// Method Maximum with three parameters.
using System;

class No01_MaximumFinder
{
    // Obtain three floating-point values and determine maximum value
    static void Main()
    {
        // Prompt for and input three floating-point values
        Console.Write("Enter first floating-point value: ");
        double number1 = double.Parse(Console.ReadLine());

        Console.Write("Enter second floating-point value: ");
        double number2 = double.Parse(Console.ReadLine());

        Console.Write("Enter third floating-point value: ");
        double number3 = double.Parse(Console.ReadLine());

        // Determine the maximum of the three values
        double result = Maximum(number1, number2, number3);

        // Display maximum value
        Console.WriteLine("Maximum is: " + result);
    }

    // Returns the maximum of its three double parameters
    static double Maximum(double x, double y, double z)
    {
        double maximumValue = x; // assume x is the largest to start

        // Determine whether y is greater than maximumValue
        if (y > maximumValue)
        {
            maximumValue = y;
        }

        // Determine whether z is greater than maximumValue
        if (z > maximumValue)
        {
            maximumValue = z;
        }

        return maximumValue;
    }
}
