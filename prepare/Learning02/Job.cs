using System;

public class Job
{
    // Step 1: Declare member variables to store job details
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    // Step 2: Define a method to display job details
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
