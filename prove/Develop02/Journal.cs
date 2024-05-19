using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<string> _prompts; // Declare a private member variable to store prompts
    private List<Entry> _entries; // Declare a private member variable to store journal entries

    public Journal()
    {
        InitializePrompts(); // Call the InitializePrompts method to initialize prompts
        _entries = new List<Entry>(); // Initialize _entries with an empty list
    }

    private void InitializePrompts()
    {
        // Initialize _prompts with some default prompts
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
        // Display a random prompt to the user
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        string prompt = _prompts[index];
        Console.WriteLine("Prompt: " + prompt);
        
        // Read user's response
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        
        // Save the entry (prompt, response, and date) to _entries
        Entry entry = new Entry(DateTime.Now.ToString("yyyy-MM-dd"), prompt, response);
        _entries.Add(entry);
    }

    public void Display()
    {
        // Display all journal entries
        Console.WriteLine("Journal Entries:");
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile()
    {
        // Prompt user for filename and save journal entries to the file
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();
        List<string> lines = new List<string>();
        foreach (Entry entry in _entries)
        {
            lines.Add(entry.ToString());
        }
        File.WriteAllLines(filename, lines);
        Console.WriteLine("Journal saved to file successfully.");
    }

    public void LoadFromFile()
    {
        // Prompt user for filename and load journal entries from the file
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();
        if (File.Exists(filename))
        {
            _entries = new List<Entry>();
            string[] lines = File.ReadAllLines(filename);
            for (int i = 0; i < lines.Length; i += 3)
            {
                string date = lines[i].Split(':')[0];
                string prompt = lines[i].Split(':')[1].Trim();
                string response = lines[i + 1];
                _entries.Add(new Entry(date, prompt, response));
            }
            Console.WriteLine("Journal loaded from file successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
