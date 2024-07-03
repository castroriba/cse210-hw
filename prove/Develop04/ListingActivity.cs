using System;
using System.Collections.Generic;
using System.Threading;

namespace MindfulnessProgram
{
    class ListingActivity : Activity
    {
        private List<string> _listingPrompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        public ListingActivity(string name, string description, int duration)
            : base(name, description, duration)
        {
        }

        protected override void PerformActivity()
        {
            Random random = new Random();

            Console.WriteLine("Consider the following prompt:");
            string prompt = _listingPrompts[random.Next(_listingPrompts.Count)];
            Console.WriteLine(prompt);

            Console.WriteLine($"You have {_duration} seconds to list as many items as you can...");

            // Simulate user listing items
            Thread.Sleep(_duration * 1000);

            Console.WriteLine($"You listed {_duration / 5} items.");
        }
    }
}
