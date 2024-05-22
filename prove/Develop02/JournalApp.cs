using System;

public class JournalApp
{
    private Journal _journal; // Declare a private member variable of type Journal

    public JournalApp()
    {
        _journal = new Journal(); // Initialize the _journal variable with a new instance of the Journal class
    }

    public void Run()
    {
        bool isRunning = true;
        
        while (isRunning)
        {
            // Display the menu options
            Console.WriteLine("Journal App Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            
            string choice = Console.ReadLine(); // Read user input
            
            switch (choice)
            {
                case "1":
                    _journal.WriteNewEntry(); // Call the WriteNewEntry method of the Journal instance
                    break;
                case "2":
                    _journal.Display(); // Call the Display method of the Journal instance
                    break;
                case "3":
                    _journal.SaveToFile(); // Call the SaveToFile method of the Journal instance
                    break;
                case "4":
                    _journal.LoadFromFile(); // Call the LoadFromFile method of the Journal instance
                    break;
                case "5":
                    isRunning = false; // Set isRunning to false to exit the loop
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again."); // Handle invalid input
                    break;
            }
        }
    }
}
