using System;

class Program
{
    static void Main()
    {
        // Call the DisplayWelcome function
        DisplayWelcome();

        // Call the PromptUserName function and save the returned value
        string userName = PromptUserName();

        // Call the PromptUserNumber function and save the returned value
        int favoriteNumber = PromptUserNumber();

        // Call the SquareNumber function and save the returned value
        int squaredNumber = SquareNumber(favoriteNumber);

        // Call the DisplayResult function with the user's name and squared number
        DisplayResult(userName, squaredNumber);
    }

    // Function to display a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Function to prompt the user for their name and return it
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // Function to prompt the user for their favorite number and return it
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    // Function to square a given number and return the result
    static int SquareNumber(int num)
    {
        return num * num;
    }

    // Function to display the result using the user's name and squared number
    static void DisplayResult(string name, int squaredNum)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNum}");
    }
}
