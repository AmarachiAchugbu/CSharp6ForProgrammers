// Listing 6.8: AutoPolicyTest.cs
// Demonstrating strings in switch.
using System;

class No08_AutoPolicyTest
{
    //static void Main()
    //{
    //    // Create two AutoPolicy objects
    //    No07_AutoPolicy policy1 = new No07_AutoPolicy(11111111, "Toyota Camry", "NJ");
    //    No07_AutoPolicy policy2 = new No07_AutoPolicy(22222222, "Ford Fusion", "ME");

    //    // Display whether each policy is in a no-fault state
    //    PolicyInNoFaultState(policy1);
    //    PolicyInNoFaultState(policy2);
    //}

    // Method that displays whether an AutoPolicy is in a state with no-fault auto insurance
    public static void PolicyInNoFaultState(No07_AutoPolicy policy)
    {
        Console.WriteLine("The auto policy:");
        Console.Write($"Account #: {policy.AccountNumber}; ");
        Console.WriteLine($"Car: {policy.MakeAndModel};");
        Console.Write($"State {policy.State} is ");
        Console.Write($"{(policy.IsNoFaultState ? "" : "not ")}");
        Console.WriteLine("a no-fault state\n");
    }
}
