using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference; // Reference object to store scripture reference
    private List<Word> _words; // List of Word objects to store words of the scripture

    // Constructor to initialize the scripture with reference and text
    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        // Split the text into words and create a list of Word objects
        _words = text.Split(' ').Select(wordText => new Word(wordText)).ToList();
    }

    // Method to hide a specified number of random words
    public void HideWords(int count)
    {
        Random random = new Random();
        
        // Select random words that are not already hidden
        var wordsToHide = _words.Where(word => !word.IsHidden()).OrderBy(x => random.Next()).Take(count);

        // Hide the selected words
        foreach (var word in wordsToHide)
        {
            word.Hide();
        }
    }

    // Method to get the rendered scripture text with hidden words replaced by underscores
    public string GetRenderedText()
    {
        string renderedWords = string.Join(" ", _words.Select(word => word.GetRenderedText()));
        return $"{_reference.GetFormattedReference()} {renderedWords}";
    }

    // Method to check if all words in the scripture are hidden
    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}
