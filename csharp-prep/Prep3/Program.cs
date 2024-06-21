using System;

class Program
{
    static void Main()
    {
        // Generate a random magic number between 1 and 100
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        // Loop until the user guesses the magic number
        int guesses = 0;
        while (true)
        {
            // Ask the user for a guess
            Console.Write("What is your guess? ");
            int guess = int.Parse(Console.ReadLine());
            guesses++;

            // Check if the guess matches the magic number
            if (guess == magicNumber)
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"It took you {guesses} guesses.");
                break; // Exit the loop if the guess is correct
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }
        }

        // Ask the user if they want to play again
        Console.Write("Do you want to play again? (yes/no) ");
        string playAgain = Console.ReadLine().ToLower();

        // If the user wants to play again, generate a new magic number
        if (playAgain == "yes")
        {
            Main(); // Recursively call Main to start a new game
        }
    }
}
