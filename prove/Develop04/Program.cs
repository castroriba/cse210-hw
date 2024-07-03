using System;

namespace MindfulnessProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Mindfulness Program!");

            bool exitProgram = false;

            do
            {
                DisplayMenu();

                char choice = GetUserChoice();

                switch (choice)
                {
                    case '1':
                        RunBreathingActivity();
                        break;
                    case '2':
                        RunReflectionActivity();
                        break;
                    case '3':
                        RunListingActivity();
                        break;
                    case '4':
                        exitProgram = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

            } while (!exitProgram);

            Console.WriteLine("Thank you for using the Mindfulness Program!");
        }

        static void DisplayMenu()
        {
            Console.WriteLine("\nMENU:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
        }

        static char GetUserChoice()
        {
            Console.Write("Enter your choice (1-4): ");
            char choice = Console.ReadKey().KeyChar;
            Console.WriteLine();
            return choice;
        }

        static void RunBreathingActivity()
        {
            Console.WriteLine("\nStarting Breathing Activity...");
            BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity",
                "This activity will help you relax by walking you through breathing in and out slowly.", 60);
            breathingActivity.Run();
        }

        static void RunReflectionActivity()
        {
            Console.WriteLine("\nStarting Reflection Activity...");
            ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection Activity",
                "This activity will help you reflect on times in your life when you have shown strength and resilience.", 90);
            reflectionActivity.Run();
        }

        static void RunListingActivity()
        {
            Console.WriteLine("\nStarting Listing Activity...");
            ListingActivity listingActivity = new ListingActivity("Listing Activity",
                "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 120);
            listingActivity.Run();
        }
    }
}
