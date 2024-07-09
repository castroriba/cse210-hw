// Word.cs
using System;

public class Word
{
    // Private member variables
    private string originalText;
    private bool hidden;

    // Constructors
    public Word(string text)
    {
        this.originalText = text;
        this.hidden = false;
    }

    // Methods
    public string GetDisplayText()
    {
        if (hidden)
        {
            // Return underscore or hidden representation
            return "______";
        }
        else
        {
            return originalText;
        }
    }

    public void Hide()
    {
        hidden = true;
    }
}