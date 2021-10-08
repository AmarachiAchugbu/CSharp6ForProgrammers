// Listing 4.7: Account.cs
// Account class with a balance and a Deposit method

class No07_Account
{
    public string Name { get; set; } // auto-implemented property
    private decimal balance; // instance variable

    // Account constructor that receives two parameters
    public No07_Account(string accountName, decimal initialBalance)
    {
        Name = accountName;
        Balance = initialBalance;
    }

    // Balance property with validation
    public decimal Balance
    {
        get { return balance; }

        private set // can be used only within the class
        {
            // Validate that the balance is greater than 0.0; if it's not,
            // instance variable balance keeps its prior value
            if (value > 0.0m) // m indicates that 0.0 is a decimal literal
            {
                balance = value;
            }
        }
    }

    // Method that deposits (adds) only a valid amount to the balance
    public void Deposit(decimal depositAmount)
    {
        if (depositAmount > 0.0m) // if the depositAmount is valid
        {
            Balance += depositAmount; // add it to the balance
        }
    }
}
