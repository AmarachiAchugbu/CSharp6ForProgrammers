// Listing 5.4: ClassAverage.cs
// Solving the class-average problem using sentinel-controlled iteration.
using System;

class No04_ClassAverage2
{
    static void Main()
    {
        // Initialization phase
        int total = 0; // initialize sum of grades
        int gradeCounter = 0; // initialize # of grades entered so far

        // Processing phase
        // Prompt for input and read grade from user
        Console.Write("Enter grade or -1 to quit: ");
        int grade = int.Parse(Console.ReadLine());

        // Loop until sentinel value is read from the user
        while (grade != -1)
        {
            total += grade; // add the grade to total
            gradeCounter++; // increment the counter by 1

            Console.Write("Enter grade or -1 to quit: "); // prompt
            grade = int.Parse(Console.ReadLine()); // input grade
        }

        // Termination phase
        // If the user entered at least one grade...
        if (gradeCounter != 0)
        {
            // Use number with decimal point to calculate average of grades
            double average = (double)total / gradeCounter;

            // Display total and average of grades
            Console.WriteLine($"\nTotal of {gradeCounter} grades is {total}");
            Console.WriteLine($"Class average is {average:F}");
        }
        else // no grades were entered, so output error message
        {
            Console.WriteLine("No grades were entered.");
        }
    }
}
