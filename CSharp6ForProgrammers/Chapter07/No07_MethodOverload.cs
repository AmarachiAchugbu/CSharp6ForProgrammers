// Listing 7.7: MethodOverload.cs
// Overloaded method declarations.
using System;

class No07_MethodOverload
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Square of integer 7 is {Square(7)}");
        Console.WriteLine($"Square of integer 7.5 is {Square(7.5)}");
    }

    /** Square method with int argument */
    static int Square(int intValue)
    {
        Console.WriteLine($"Called square with int argument: {intValue}");
        return intValue * intValue;
    }

    /** Square method with double argument */
    static double Square(double doubleValue)
    {
        Console.WriteLine($"Called square with int argument: {doubleValue}");
        return doubleValue * doubleValue;
    }
}