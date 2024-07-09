using System;

class Program
{
    static void Main()
    {
        // Ask the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        int gradePercentage = int.Parse(Console.ReadLine());

        // Determine the letter grade based on the percentage
        string letter = "";
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine if the user passed the course
        bool passed = gradePercentage >= 70;

        // Display the letter grade
        Console.Write($"Your letter grade is {letter}");

        // Display the sign if stretch challenge completed
        int lastDigit = gradePercentage % 10;
        string sign = "";
        if (lastDigit >= 7 && letter != "A" && letter != "F")
        {
            sign = "+";
        }
        else if (lastDigit < 3 && letter != "F")
        {
            sign = "-";
        }

        // Handle exceptional cases
        if (letter == "A" && lastDigit >= 7)
        {
            sign = "-";
        }
        else if (letter == "F" && lastDigit >= 7)
        {
            sign = "";
        }

        // Display the sign if not empty
        if (!string.IsNullOrEmpty(sign))
        {
            Console.WriteLine(sign);
        }
        else
        {
            Console.WriteLine();
        }

        // Congratulate or encourage the user
        if (passed)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Keep working hard! You'll do better next time.");
        }
    }
}
