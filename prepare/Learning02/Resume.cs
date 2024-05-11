using System;
using System.Collections.Generic; // Needed for List<T>

public class Resume
{
    // Step 1: Declare a member variable to store the person's name
    public string _name;

    // Step 2: Declare a list of Job objects to store multiple jobs in the resume
    public List<Job> _jobs = new List<Job>();

    // Step 3: Define a method to display the resume details
    public void Display()
    {
        Console.WriteLine($"Name: {_name}"); // Step 4: Display the person's name
        
        Console.WriteLine("Jobs:"); // Step 5: Display a header for the jobs
        
        // Step 6: Iterate through each Job object in the list and call its Display() method
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}
