using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Create a new instance of the Job class representing the first job
        Job job1 = new Job();
        
        // Step 2: Set the member variables of job1 with details of the first job
        job1._jobTitle = "Junior Developer";
        job1._company = "AMAZON";
        job1._startYear = 2020;
        job1._endYear = 2022;

        // Step 3: Create a new instance of the Job class representing the second job
        Job job2 = new Job();
        
        // Step 4: Set the member variables of job2 with details of the second job
        job2._jobTitle = "Senior Developer";
        job2._company = "Microsoft";
        job2._startYear = 2022;
        job2._endYear = 2024;

        // Step 5: Create a new instance of the Resume class
        Resume myResume = new Resume();
        
        // Step 6: Set the person's name in the Resume instance
        myResume._name = "David Carrillo";

        // Step 7: Add the job instances (job1 and job2) to the list of jobs in the Resume instance
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Step 8: Call the Display() method of the Resume instance to display the person's name and job details
        myResume.Display();
    }
}