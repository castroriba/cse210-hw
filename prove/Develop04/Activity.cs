using System;
using System.Threading;

namespace MindfulnessProgram
{
    abstract class Activity
    {
        protected string _name;
        protected string _description;
        protected int _duration;

        public Activity(string name, string description, int duration)
        {
            _name = name;
            _description = description;
            _duration = duration;
        }

        public virtual void Run()
        {
            DisplayStartingMessage();

            // Pause before starting activity
            Thread.Sleep(3000);

            // Perform the activity-specific task
            PerformActivity();

            DisplayEndingMessage();

            // Pause before ending
            Thread.Sleep(3000);
        }

        protected abstract void PerformActivity();

        protected void DisplayStartingMessage()
        {
            Console.WriteLine($"Activity: {_name}");
            Console.WriteLine($"Description: {_description}");
            Console.WriteLine($"Duration: {_duration} seconds");
            Console.WriteLine("Prepare to begin...");
        }

        protected void DisplayEndingMessage()
        {
            Console.WriteLine("Good job! Activity completed.");
            Console.WriteLine($"Activity: {_name}");
            Console.WriteLine($"Duration: {_duration} seconds");
        }

        protected void ShowSpinner(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }
    }
}
