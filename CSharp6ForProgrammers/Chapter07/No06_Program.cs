// Listing 7.6: SquareTest.cs
// Square method used to demonstrate the method call stack 
// and activation records
using System;

class No06_Program
{
    static void Main()
    {
        int x = 10; // value to square
        Console.WriteLine($"x squared: {Square(x)}");
    }

    /** Method that returns the square of an integer */
    static int Square(int y)
    {
        return y * y; // calculates the square of y and returns the result
    }
}
