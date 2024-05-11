using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Create a new instance of the Journal class
        Journal journal = new Journal();

        // Step 2: Create a loop to display the menu and handle user input
        bool exit = false;
        while (!exit)
        {
            // Step 3: Display the menu options
            Console.WriteLine("Journal Program");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    // Step 4: Call the corresponding method based on user choice
                    case 1:
                        journal.WriteNewEntry();
                        break;
                    case 2:
                        journal.DisplayJournal();
                        break;
                    case 3:
                        journal.SaveJournalToFile();
                        break;
                    case 4:
                        journal.LoadJournalFromFile();
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            Console.WriteLine();
        }
    }
}

class Journal
{
    private List<Entry> entries;

    // Step 5: Constructor to initialize the list of entries
    public Journal()
    {
        entries = new List<Entry>();
    }

    // Step 6: Method to write a new journal entry
    public void WriteNewEntry()
    {
        // Step 7: Define prompts for the journal entries
        string[] prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        // Step 8: Randomly select a prompt
        Random rand = new Random();
        int index = rand.Next(prompts.Length);

        // Step 9: Prompt user for response and create an Entry object
        Console.WriteLine($"Prompt: {prompts[index]}");
        Console.Write("Enter your response: ");
        string response = Console.ReadLine();

        Entry entry = new Entry(prompts[index], response, DateTime.Now);
        entries.Add(entry);

        Console.WriteLine("Entry added successfully.");
    }

    // Step 10: Method to display all journal entries
    public void DisplayJournal()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("Journal is empty.");
        }
        else
        {
            foreach (var entry in entries)
            {
                Console.WriteLine(entry);
            }
        }
    }

    // Step 11: Method to save the journal to a file
    public void SaveJournalToFile()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine(entry);
            }
        }

        Console.WriteLine("Journal saved to file successfully.");
    }

    // Step 12: Method to load journal entries from a file
    public void LoadJournalFromFile()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            entries.Clear();

            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    string prompt = parts[0];
                    string response = parts[1];
                    DateTime date = DateTime.Parse(parts[2]);
                    Entry entry = new Entry(prompt, response, date);
                    entries.Add(entry);
                }
            }

            Console.WriteLine("Journal loaded from file successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}

class Entry
{
    private string prompt;
    private string response;
    private DateTime date;

    // Step 13: Constructor to initialize entry properties
    public Entry(string prompt, string response, DateTime date)
    {
        this.prompt = prompt;
        this.response = response;
        this.date = date;
    }

    // Step 14: Override ToString() method to format entry for display
    public override string ToString()
    {
        return $"Date: {date}, Prompt: {prompt}, Response: {response}";
    }
}