// Scripture.cs
using System;
using System.Collections.Generic;

public class Scripture
{
    // Private member variables
    private string reference;
    private string text;
    private List<Word> words;

    // Constructors
    public Scripture(string reference, string text)
    {
        this.reference = reference;
        this.text = text;
        this.words = new List<Word>();
        // Initialize words list by parsing text into Word objects
        ParseTextIntoWords();
    }

    // Methods
    private void ParseTextIntoWords()
    {
        // Logic to split text into words and initialize Word objects
        // Add Word objects to the words list
    }

    public void Display()
    {
        // Display scripture including reference and text
        Console.WriteLine($"{reference}: {GetDisplayText()}");
    }

    public void HideRandomWords()
    {
        // Logic to hide a few random words
        // Calls methods on Word objects to hide them
    }

    private string GetDisplayText()
    {
        // Logic to combine words into displayable text
        // Iterate through words list and concatenate Word.GetDisplayText()
        return "";
    }
}
