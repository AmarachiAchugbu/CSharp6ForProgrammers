// Listing 05 - Addition.cs
// Displaying the sum of two numbers input from the keyboard.
using System;

class No05_Addition
{
    // Main method begins execution of C# app
    private static void Main()
    {
        int number1; // declare first number to add
        int number2; // declare second number to add
        int sum; // declare sum of number1 and number2

        Console.Write("Enter first integer: "); // prompt user
        // Read first number from user
        number1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second integer: "); // prompt user
        // Read second number from user
        number2 = int.Parse(Console.ReadLine());

        sum = number1 + number2; // add the numbers

        Console.WriteLine($"Sum is {sum}"); // display sum
    } // end Main
} // end class Addition
