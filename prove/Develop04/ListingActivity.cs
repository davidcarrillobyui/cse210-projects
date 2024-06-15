using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> Prompts { get; } = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public override void Run()
    {
        Start();
        Random rand = new Random();
        string prompt = Prompts[rand.Next(Prompts.Count)];
        Console.WriteLine(prompt);
        Pause(3);

        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        int count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item: ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"You have listed {count} items.");
        End();
    }
}
