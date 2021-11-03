﻿// Listing 7.5: Scope.cs
// Scope class demonstrates static- and local-variable scopes.
using System;

class No05_Scope
{
	// Static variable that's accessible to all methods of this class
	private static int x = 1;

	/** Main creates and initializes local variable x 
	 * and calls methods UseLocalVariable and UseStaticVariable
	 */
	static void Main()
	{
		int x = 5; // this method's local variable x hides static variable x

		Console.WriteLine($"local x in method Main is {x}");

		// UseLocalVariable has its own local x
		UseLocalVariable();

		// UseStaticVariable uses class Scope's static variable x
		UseStaticVariable();

		// UseLocalVariable reinitializes its own local x
		UseLocalVariable();

		// class Scope's static variable x retains its value
		UseStaticVariable();
	}

	/** Create and initialize local variable x during each call */
	static void UseLocalVariable()
	{
		int x = 25; // initialized each time UseLocalVariable is called

		Console.WriteLine($"\nlocal x on entering method UseLocalVariable is {x}");
		x++; // modifies this method's local variable x
		Console.WriteLine($"local x before exiting method UseLocalVariable is {x}");
	}

	/** Modify class Scope's static variable x during each call */
	static void UseStaticVariable()
	{
		Console.WriteLine($"\nstatic variable x on entering method UseStaticVariable is {x}");
		x *= 10; // modifies class Scope's static variable x
		Console.WriteLine($"static variable x before exiting method UseStaticVariable is {x}");
	}
}
