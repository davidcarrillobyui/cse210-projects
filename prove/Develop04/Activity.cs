using System;

// Base class representing a generic activity
public abstract class Activity
{
    // Private member variables
    private string _name;
    private string _description;
    private int _duration;

    // Constructor to initialize the activity name and description
    protected Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // Public property to get and set the duration of the activity
    public int Duration
    {
        get { return _duration; }
        set { _duration = value; }
    }

    // Method to start the activity
    protected void Start()
    {
        Console.WriteLine($"Starting {_name}: {_description}");
        Console.WriteLine("Prepare to begin...");
        Pause(3); // Pause for 3 seconds
    }

    // Method to end the activity
    protected void End()
    {
        Console.WriteLine($"Good job! You have completed {_name} for {_duration} seconds.");
        Pause(3); // Pause for 3 seconds
    }

    // Method to pause the execution for a given number of seconds
    protected void Pause(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("."); // Display a dot each second
            System.Threading.Thread.Sleep(1000); // Wait for 1 second
        }
        Console.WriteLine();
    }

    // Abstract method to be implemented by derived classes to run the specific activity
    public abstract void Run();
}
