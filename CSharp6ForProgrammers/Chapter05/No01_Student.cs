// Listing 5.1: Student.cs
// Student class that stores a student name and average

class No01_Student
{
    public string Name { get; set; } // property to manipulate the Student's name
    private int average; // instance variable

    // Constructor initializes Name and Average properties
    public No01_Student (string studentName, int studentAverage)
    {
        Name = studentName;
        Average = studentAverage; // sets average instance variable
    }

    // Property to get and set instance variable average
    public int Average
    {
        get // returns the Student's average
        {
            return average;
        }

        set // sets the Student's average
        {
            // Validate that value is > 0 and <= 100; otherwise,
            // keep instance variable average's current value
            if (value > 0 && value <= 100)
            {
                average = value;
            }
        }
    }

    public string LetterGrade
    {
        get
        {
            string letterGrade = string.Empty; // string.Empty is ""

            if (average >= 90)
            {
                letterGrade = "A";
            }
            else if (average >= 80)
            {
                letterGrade = "B";
            }
            else if (average >= 70)
            {
                letterGrade = "C";
            }
            else if (average >= 60)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }

            return letterGrade;
        }
    }
}