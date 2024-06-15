using System;

public abstract class Activity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Duration { get; set; }

    protected Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void Start()
    {
        Console.WriteLine($"Starting {Name}: {Description}");
        Console.WriteLine("Prepare to begin...");
        Pause(3);
    }

    public void End()
    {
        Console.WriteLine($"Good job! You have completed {Name} for {Duration} seconds.");
        Pause(3);
    }

    public void Pause(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public abstract void Run();
}
