using System;

public class JournalApp
{
    private Journal _journal; // 1: Declare a private member variable of type Journal

    public JournalApp()
    {
        _journal = new Journal(); // 2: Initialize the _journal variable with a new instance of the Journal class
    }

    public void Run()
    {
        bool isRunning = true;
        
        while (isRunning)
        {
            // 3: Display the menu options
            Console.WriteLine("Journal App Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            
            string choice = Console.ReadLine(); //   4: Read user input
            
            switch (choice)
            {
                case "1":
                    _journal.WriteNewEntry(); //  5: Call the WriteNewEntry method of the Journal instance
                    break;
                case "2":
                    _journal.Display(); //   6: Call the Display method of the Journal instance
                    break;
                case "3":
                    _journal.SaveToFile(); //   7: Call the SaveToFile method of the Journal instance
                    break;
                case "4":
                    _journal.LoadFromFile(); //   8: Call the LoadFromFile method of the Journal instance
                    break;
                case "5":
                    isRunning = false; //   9: Set isRunning to false to exit the loop
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again."); //   10: Handle invalid input
                    break;
            }
        }
    }
}
