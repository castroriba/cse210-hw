using System;
using System.Collections.Generic;
using System.Threading;

namespace MindfulnessProgram
{
    class ReflectionActivity : Activity
    {
        private List<string> _reflectionPrompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private List<string> _reflectionQuestions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        public ReflectionActivity(string name, string description, int duration)
            : base(name, description, duration)
        {
        }

        protected override void PerformActivity()
        {
            Random random = new Random();

            Console.WriteLine("Think deeply about the following prompt:");
            string prompt = _reflectionPrompts[random.Next(_reflectionPrompts.Count)];
            Console.WriteLine(prompt);

            foreach (var question in _reflectionQuestions)
            {
                Console.WriteLine(question);
                ShowSpinner(2);
            }
        }
    }
}
