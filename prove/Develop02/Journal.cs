using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<string> _prompts; // Step 1: Declare a private member variable to store prompts
    private List<string> _entries; // Step 2: Declare a private member variable to store journal entries

    public Journal()
    {
        InitializePrompts(); // Step 3: Call the InitializePrompts method to initialize prompts
        _entries = new List<string>(); // Step 4: Initialize _entries with an empty list
    }

    private void InitializePrompts()
    {
        // Step 5: Initialize _prompts with some default prompts
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
    }

    public void WriteNewEntry()
    {
        // Step 6: Display a random prompt to the user
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        string prompt = _prompts[index];
        Console.WriteLine("Prompt: " + prompt);
        
        // Step 7: Read user's response
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        
        // Step 8: Save the entry (prompt, response, and date) to _entries
        string entry = $"{DateTime.Now:yyyy-MM-dd}: {prompt}\n{response}\n";
        _entries.Add(entry);
    }

    public void Display()
    {
        // Step 9: Display all journal entries
        Console.WriteLine("Journal Entries:");
        foreach (string entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile()
    {
        // Step 10: Prompt user for filename and save journal entries to the file
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();
        File.WriteAllLines(filename, _entries);
        Console.WriteLine("Journal saved to file successfully.");
    }

    public void LoadFromFile()
    {
        // Step 11: Prompt user for filename and load journal entries from the file
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();
        if (File.Exists(filename))
        {
            _entries = new List<string>(File.ReadAllLines(filename));
            Console.WriteLine("Journal loaded from file successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
