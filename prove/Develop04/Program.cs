using System;

class Program
{
    static void Main(string[] args)
    {
        // Infinite loop to keep the program running until the user chooses to exit
        while (true)
        {
            // Display menu options
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an activity: ");

            // Read user's choice
            string choice = Console.ReadLine();

            // Switch statement to handle user's choice
            switch (choice)
            {
                case "1":
                    // Create an instance of BreathingActivity and run it
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Duration = GetDuration(); // Set duration for the activity
                    breathing.Run();
                    break;
                case "2":
                    // Create an instance of ReflectionActivity and run it
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.Duration = GetDuration(); // Set duration for the activity
                    reflection.Run();
                    break;
                case "3":
                    // Create an instance of ListingActivity and run it
                    ListingActivity listing = new ListingActivity();
                    listing.Duration = GetDuration(); // Set duration for the activity
                    listing.Run();
                    break;
                case "4":
                    // Exit the program
                    return;
                default:
                    // Handle invalid choice
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    // Helper method to get the duration of the activity from the user
    static int GetDuration()
    {
        Console.Write("Enter the duration of the activity in seconds: ");
        return int.Parse(Console.ReadLine());
    }
}
