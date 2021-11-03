// Listing 7.9: FactorialTest.cs
// Recursive Factorial method.
using System;

class No09_FactorialTest
{
    static void Main(string[] args)
    {
        // Calculate the factorials of 0 through 10
        for (int counter = 0; counter <= 10; counter++)
        {
            Console.WriteLine($"{counter}! = {Factorial(counter)}");
        }
    }

    static long Factorial(long number)
    {
        // Base case
        if (number <= 1)
            return 1;
        else // recursive step
            return number * Factorial(number - 1);
    }
}
