using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Initialize the Reference object
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        // Scripture text to be memorized
        string scriptureText = "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.";

        // Initialize the Scripture object with the reference and text
        Scripture scripture = new Scripture(reference, scriptureText);

        // Main loop for user interaction
        while (true)
        {
            // Clear the console screen
            Console.Clear();

            // Display the rendered scripture text
            Console.WriteLine(scripture.GetRenderedText());

            // Prompt the user to press Enter or type 'quit'
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();
            
            // Exit the program if the user types 'quit' or if all words are hidden
            if (input.ToLower() == "quit" || scripture.IsCompletelyHidden())
            {
                break;
            }

            // Hide a few random words in the scripture
            scripture.HideWords(3);
        }
    }
}
