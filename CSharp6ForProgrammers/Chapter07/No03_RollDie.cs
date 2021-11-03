// Listing 7.3: RollDie.cs
// Roll a six-sided die 60,000,000 times.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class No03_RollDie
{
    static void Main()
    {
        Random randomNumbers = new Random();

        int frequency1 = 0; // count of 1s rolled
        int frequency2 = 0; // count of 2s rolled
        int frequency3 = 0; // count of 3s rolled
        int frequency4 = 0; // count of 4s rolled
        int frequency5 = 0; // count of 5s rolled
        int frequency6 = 0; // count of 6s rolled

        // summarize results of 60,000,000 rolls of a die
        for (int roll = 1; roll <= 60000000; roll++)
        {
            int face = randomNumbers.Next(1, 7); // number from 1 to 6

            // Determine roll value 1-6 and increment appropriate counter
            switch (face)
            {
                case 1: frequency1++; break; // increment the 1s counter
                case 2: frequency2++; break; // increment the 2s counter
                case 3: frequency3++; break; // increment the 3s counter
                case 4: frequency4++; break; // increment the 4s counter
                case 5: frequency5++; break; // increment the 5s counter
                case 6: frequency6++; break; // increment the 6s counter
            }
        }

        Console.WriteLine("Face\tFrequency"); // output headers
        Console.WriteLine($"1\t{frequency1}\n2\t{frequency2}");
        Console.WriteLine($"3\t{frequency3}\n4\t{frequency4}");
        Console.WriteLine($"5\t{frequency5}\n6\t{frequency6}");
    }
}
