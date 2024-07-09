using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new ScriptureMemorizer instance
            ScriptureMemorizer memorizer = new ScriptureMemorizer();

            // Run the memorizer
            memorizer.Run();
        }
    }

    class ScriptureMemorizer
    {
        private string reference;
        private string[] scriptureText;
        private bool[] hiddenWords;

        public ScriptureMemorizer()
        {
            // Initialize with a sample scripture
            reference = "John 3:16";
            scriptureText = new string[]
            {
                "For God so loved the world that he gave his one and only Son,",
                "that whoever believes in him shall not perish but have eternal life."
            };
            hiddenWords = new bool[CountTotalWords()];
        }

        public void Run()
        {
            bool allWordsHidden = false;

            do
            {
                DisplayScripture();
                Console.WriteLine("\nPress Enter to hide more words or type 'quit' to end:");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }
                else if (input == "")
                {
                    HideRandomWords();
                    Console.Clear();
                }

                allWordsHidden = CheckAllWordsHidden();
            } while (!allWordsHidden);

            Console.WriteLine("\nAll words are hidden. Program ended.");
        }

        private void DisplayScripture()
        {
            Console.WriteLine($"Scripture Reference: {reference}\n");

            for (int i = 0; i < scriptureText.Length; i++)
            {
                string[] words = scriptureText[i].Split(' ');

                for (int j = 0; j < words.Length; j++)
                {
                    if (hiddenWords[GetWordIndex(i, j)])
                    {
                        Console.Write("________ ");
                    }
                    else
                    {
                        Console.Write($"{words[j]} ");
                    }
                }

                Console.WriteLine();
            }
        }

        private void HideRandomWords()
        {
            Random random = new Random();
            int totalWords = CountTotalWords();

            // Choose a random word to hide
            int wordIndex = random.Next(totalWords);
            hiddenWords[wordIndex] = true;
        }

        private bool CheckAllWordsHidden()
        {
            foreach (bool hidden in hiddenWords)
            {
                if (!hidden)
                {
                    return false;
                }
            }
            return true;
        }

        private int CountTotalWords()
        {
            int count = 0;
            foreach (string line in scriptureText)
            {
                string[] words = line.Split(' ');
                count += words.Length;
            }
            return count;
        }

        private int GetWordIndex(int lineIndex, int wordIndex)
        {
            int index = 0;
            for (int i = 0; i < lineIndex; i++)
            {
                string[] words = scriptureText[i].Split(' ');
                index += words.Length;
            }
            index += wordIndex;
            return index;
        }
    }
}
