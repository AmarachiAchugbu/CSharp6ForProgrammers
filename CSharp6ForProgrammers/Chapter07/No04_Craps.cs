// Listing 7.4: Craps.cs
// Craps class simulates the dice game craps.
using System;

class No04_Craps
{
    // Create random-number generator for use in method RollDice
    private static Random randomNumbers = new Random();

    // Enumeration with constants that represent the game status
    private enum Status { Continue, Won, Lost }

    // Enumeration with constants that represent common rolls of the dice
    private enum DiceNames
    {
        SnakeEyes = 2,
        Trey = 3,
        Seven = 7,
        YoLeven = 11,
        BoxCars = 12
    }

    // Plays one game of craps
    static void Main(string[] args)
    {
        Status gameStatus = Status.Continue;
        int myPoint = 0; // stores the point if there is no win or loss on first roll

        int sumOfDice = RollDice();

        // Determine game status and point based on first roll
        switch ((DiceNames)sumOfDice)
        {
            case DiceNames.Seven: // win with 7 on first roll
            case DiceNames.YoLeven: // win with 11 on first roll
                gameStatus = Status.Won;
                break;
            case DiceNames.SnakeEyes: // lose with 2 on first roll
            case DiceNames.Trey: // lose with 3 on first roll
            case DiceNames.BoxCars: // lose with 12 on first roll
                gameStatus = Status.Lost;
                break;
            default: // did not win or lose, so remember point
                gameStatus = Status.Continue; // game is not over
                myPoint = sumOfDice; // remember the point
                Console.WriteLine($"Point is {myPoint}");
                break;
        }

        // While the game is not complete
        while (gameStatus == Status.Continue)
        {
            sumOfDice = RollDice(); // roll dice again

            // Determine the game status
            if (sumOfDice == myPoint)
            {
                gameStatus = Status.Won;
            }
            else if (sumOfDice == (int)DiceNames.Seven) // lose by rolling 7 before point
            {
                gameStatus = Status.Lost;
            }
        }

        // Display won or lost message
        if (gameStatus == Status.Won)
        {
            Console.WriteLine("Player wins");
        }
        else
        {
            Console.WriteLine("Player loses");
        }
    }

    // Roll dice, calculate sum and display results
    static int RollDice()
    {
        // Pick random die values
        int die1 = randomNumbers.Next(1, 7); // first die roll
        int die2 = randomNumbers.Next(1, 7); // second die roll

        int sum = die1 + die2; // sum of die values

        // Display results of this roll
        Console.WriteLine($"Player rolled {die1} + {die2} = {sum}");
        return sum; // return sum of dice
    }
}
