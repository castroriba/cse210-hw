using System;
using System.Threading;

namespace MindfulnessProgram
{
    class BreathingActivity : Activity
    {
        public BreathingActivity(string name, string description, int duration)
            : base(name, description, duration)
        {
        }

        protected override void PerformActivity()
        {
            Console.WriteLine("Clear your mind and focus on your breathing...");
            for (int i = 0; i < _duration; i += 10)
            {
                Console.WriteLine("Breathe in...");
                ShowSpinner(1);

                Console.WriteLine("Breathe out...");
                ShowSpinner(1);
            }
        }
    }
}
