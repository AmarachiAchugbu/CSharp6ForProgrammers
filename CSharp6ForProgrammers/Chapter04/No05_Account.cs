// Listing 4.5: Account.cs
// Account class with a constructor that initializes an Account's name.

class No05_Account
{
    // Auto-implemented property to get and set the name instance variable
    public string Name { get; set; }

    // Constructor sets the Name property to parameter accountName's value
    public No05_Account(string accountName) // constructor name is class name
    {
        Name = accountName;
    }
}