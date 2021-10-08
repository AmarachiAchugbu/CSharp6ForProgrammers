// Listing 4.1: Account.cs
// A simple Account class that contains a private instance
// variable 'name', and public methods to Set and Get name's value

class No01_Account
{
    private string name; // instance variable

    // Method that sets the account name in the object
    public void SetName(string accountName)
    {
        name = accountName; // stores the account name
    }

    // Method that retrieves the account name from the object
    public string GetName()
    {
        return name; // returns name's value to this method's caller
    }
}