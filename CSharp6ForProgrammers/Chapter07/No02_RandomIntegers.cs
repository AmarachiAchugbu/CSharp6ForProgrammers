// Listing 7.2: RandomIntegers.cs
// Shifted and scaled random integers.
using System;

class No02_RandomIntegers
{
    static void Main()
    {
        Random randomNumbers = new Random(); // random number generator

        // Loop 20 times
        for (int counter = 0; counter < 20; counter++)
        {
            // picks random integer from 1 to 6
            int face = randomNumbers.Next(1, 7);
            Console.Write($"{face}  "); // Display generated value
        }

        Console.WriteLine();
    }
}
