using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percentGrade = Console.ReadLine();
        int percentage = int.Parse(percentGrade);

        string approved = "Congratulations! You passed the course.";
        string notApproved = "You did not pass the course.";

    

        if(percentage >= 90)
        {
            Console.Write( approved + " Your grade is A");
        }
        else if(percentage >= 80)
        {
            Console.Write(approved + " Your grade is B");

        }
        else if(percentage >= 70)
        {
            Console.Write(approved + " Your grade is C");
        }
        else if(percentage >= 60)
        {
            Console.Write(notApproved + " Your grade is D");
        }
        else
        {
            Console.Write(notApproved + " Your grade is F");
        }

    }
}