using System;
using System.Collections.Generic;

// Derived class representing the listing activity
public class ListingActivity : Activity
{
    // Private member variable to hold prompts
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    // Constructor that calls the base class constructor with name and description
    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    // Override the Run method to implement the listing activity
    public override void Run()
    {
        Start(); // Call the Start method from the base class
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        Pause(3); // Pause for 3 seconds

        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        int count = 0;

        // Loop until the duration is over
        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item: ");
            Console.ReadLine(); // Read user input
            count++; // Increment count
        }

        Console.WriteLine($"You have listed {count} items.");
        End(); // Call the End method from the base class
    }
}
