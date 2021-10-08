// Listing 4.8 AccountTest.cs
// Reading and writing monetary amounts with Account objects.
using System;

class No08_AccountTest
{
    private static void Main()
    {
        No07_Account account1 = new No07_Account("Jane Green", 50.00m);
        No07_Account account2 = new No07_Account("John Blue", -7.53m);

        // Display initial balance of each object
        Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
        Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");

        // Prompt for input, then read it in
        Console.Write("\nEnter deposit amount for account1: ");
        decimal depositAmount = decimal.Parse(Console.ReadLine());
        Console.WriteLine($"adding {depositAmount:C} to account1 balance\n");
        account1.Deposit(depositAmount); // add to account1's balance

        // Display balances
        Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
        Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");

        // Prompt for then read input
        Console.Write("\nEnter deposit amount for account2: ");
        depositAmount = decimal.Parse(Console.ReadLine());
        Console.WriteLine($"adding {depositAmount:C} to account2 balance\n");
        account2.Deposit(depositAmount); // add to account2's balance

        // Display balances
        Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
        Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");
    }
}
