// Listing 6.7: AutoPolicy.cs
// Class that represents an auto insurance policy

class No07_AutoPolicy
{
    public int AccountNumber { get; set; } // policy account number
    public string MakeAndModel { get; set; } // car that policy applies to
    public string State { get; set; } // two-letter state abbreviation

    // Constructor
    public No07_AutoPolicy(int accountNumber, string makeAndModel, string state)
    {
        AccountNumber = accountNumber;
        MakeAndModel = makeAndModel;
        State = state;
    }

    // Returns whether the state has no-fault insurance
    public bool IsNoFaultState
    {
        get
        {
            bool noFaultState;

            // Determine whether state has no-fault auto insurance
            switch (State) // get AutoPolicy object's state abbreviation
            {
                case "MA":
                case "NJ":
                case "NY":
                case "PN": noFaultState = true; break;
                default: noFaultState = false;
                    break;
            }

            return noFaultState;
        }        
    }
}
