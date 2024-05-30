using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference reference; // Reference object to store scripture reference
    private List<Word> words; // List of Word objects to store words of the scripture

    // Constructor to initialize the scripture with reference and text
    public Scripture(Reference reference, string text)
    {
        this.reference = reference;

        // Split the text into words and create a list of Word objects
        words = text.Split(' ').Select(wordText => new Word(wordText)).ToList();
    }

    // Method to hide a specified number of random words
    public void HideWords(int count)
    {
        Random random = new Random();
        
        // Select random words that are not already hidden
        var wordsToHide = words.Where(word => !word.IsHidden()).OrderBy(x => random.Next()).Take(count);

        // Hide the selected words
        foreach (var word in wordsToHide)
        {
            word.Hide();
        }
    }

    // Method to get the rendered scripture text with hidden words replaced by underscores
    public string GetRenderedText()
    {
        string renderedWords = string.Join(" ", words.Select(word => word.GetRenderedText()));
        return $"{reference.GetFormattedReference()} {renderedWords}";
    }

    // Method to check if all words in the scripture are hidden
    public bool IsCompletelyHidden()
    {
        return words.All(word => word.IsHidden());
    }
}
