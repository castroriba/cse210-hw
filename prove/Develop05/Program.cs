using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new user
            User user = new User();

            // Load user data from file
            user.Load();

            // Main loop
            bool running = true;
            while (running)
            {
                // Display user score
                Console.WriteLine($"User Score: {user.Score}");

                // Display menu
                Console.WriteLine("1. Display Goals");
                Console.WriteLine("2. Create New Goal");
                Console.WriteLine("3. Record Event");
                Console.WriteLine("4. Save and Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        // Display goal list
                        Console.WriteLine("Goal List:");
                        foreach (Goal goal in user.Goals)
                        {
                            Console.WriteLine(goal);
                        }
                        break;
                    case "2":
                        // Create a new goal
                        CreateNewGoal(user);
                        break;
                    case "3":
                        // Record an event
                        RecordEvent(user);
                        break;
                    case "4":
                        // Save user data to file and exit
                        user.Save();
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void CreateNewGoal(User user)
        {
            Console.WriteLine("Enter goal type (1. Simple, 2. Eternal, 3. Checklist):");
            string goalType = Console.ReadLine();
            Console.WriteLine("Enter goal name:");
            string goalName = Console.ReadLine();
            Console.WriteLine("Enter goal value:");
            int goalValue = int.Parse(Console.ReadLine());

            Goal newGoal = null;
            switch (goalType)
            {
                case "1":
                    newGoal = new SimpleGoal(goalName, goalValue);
                    break;
                case "2":
                    newGoal = new EternalGoal(goalName, goalValue);
                    break;
                case "3":
                    Console.WriteLine("Enter target count for checklist goal:");
                    int targetCount = int.Parse(Console.ReadLine());
                    newGoal = new ChecklistGoal(goalName, goalValue, targetCount);
                    break;
                default:
                    Console.WriteLine("Invalid goal type.");
                    return;
            }

            user.Goals.Add(newGoal);
        }

        static void RecordEvent(User user)
        {
            Console.WriteLine("Enter goal name:");
            string goalName = Console.ReadLine();
            Goal goal = user.Goals.Find(g => g.Name == goalName);

            if (goal != null)
            {
                goal.RecordEvent(true);
                user.Score += goal.Value;
                Console.WriteLine("Event recorded.");
            }
            else
            {
                Console.WriteLine("Goal not found.");
            }
        }
    }

    public abstract class Goal
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public bool IsComplete { get; set; }

        public Goal(string name, int value)
        {
            Name = name;
            Value = value;
        }

        public abstract void RecordEvent(bool isComplete);

        public override string ToString()
        {
            return $"[{GetType().Name}] {Name} - {Value} points - Complete: {IsComplete}";
        }
    }

    public class SimpleGoal : Goal
    {
        public SimpleGoal(string name, int value) : base(name, value) { }

        public override void RecordEvent(bool isComplete)
        {
            IsComplete = isComplete;
        }
    }

    public class EternalGoal : Goal
    {
        public EternalGoal(string name, int value) : base(name, value) { }

        public override void RecordEvent(bool isComplete)
        {
            // Eternal goals are never complete
        }
    }

    public class ChecklistGoal : Goal
    {
        public int TargetCount { get; set; }
        public int CurrentCount { get; set; }

        public ChecklistGoal(string name, int value, int targetCount) : base(name, value)
        {
            TargetCount = targetCount;
        }

        public override void RecordEvent(bool isComplete)
        {
            if (isComplete)
            {
                CurrentCount++;
                if (CurrentCount >= TargetCount)
                {
                    IsComplete = true;
                }
            }
        }

        public override string ToString()
        {
            return $"[{GetType().Name}] {Name} - {Value} points - Completed: {CurrentCount}/{TargetCount}";
        }
    }

    public class User
    {
        public int Score { get; set; }
        public List<Goal> Goals { get; set; }

        public User()
        {
            Goals = new List<Goal>();
        }

        public void Load()
        {
            // Check if the file exists
            if (File.Exists("userData.txt"))
            {
                // Read all lines from the file
                string[] lines = File.ReadAllLines("userData.txt");

                // The first line is the user's score
                Score = int.Parse(lines[0]);

                // The remaining lines are the goals
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(',');

                    string goalType = parts[0];
                    string name = parts[1];
                    int value = int.Parse(parts[2]);
                    bool isComplete = bool.Parse(parts[3]);

                    Goal goal = null;
                    if (goalType == "SimpleGoal")
                    {
                        goal = new SimpleGoal(name, value);
                    }
                    else if (goalType == "EternalGoal")
                    {
                        goal = new EternalGoal(name, value);
                    }
                    else if (goalType == "ChecklistGoal")
                    {
                        int targetCount = int.Parse(parts[4]);
                        int currentCount = int.Parse(parts[5]);
                        goal = new ChecklistGoal(name, value, targetCount);
                        ((ChecklistGoal)goal).CurrentCount = currentCount;
                    }

                    goal.IsComplete = isComplete;
                    Goals.Add(goal);
                }
            }
        }

        public void Save()
        {
            using (StreamWriter outputFile = new StreamWriter("userData.txt"))
            {
                // Write the user's score
                outputFile.WriteLine(Score);

                // Write each goal
                foreach (Goal goal in Goals)
                {
                    if (goal is ChecklistGoal checklistGoal)
                    {
                        outputFile.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.Value},{goal.IsComplete},{checklistGoal.TargetCount},{checklistGoal.CurrentCount}");
                    }
                    else
                    {
                        outputFile.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.Value},{goal.IsComplete}");
                    }
                }
            }
        }
    }
}
