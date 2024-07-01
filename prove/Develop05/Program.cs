using System;

class Program
{
    static void Main(string[] args)
    {
        AllGoals allGoals = new AllGoals();  // Create an instance of AllGoals to manage goals
        int userMainMenuSelection = 0;

        Console.Clear();
        Console.WriteLine("Welcome to the Goal Tracking App!");
        Console.WriteLine();

        // Main loop for the menu
        while (userMainMenuSelection != 6)
        {
            Menu menu = new Menu();  // Create a new menu instance
            allGoals.DisplayPoints(allGoals.getTotalPoints());  // Display the total points
            Console.WriteLine();
            menu.DisplayMainMenu();  // Display the main menu options
            userMainMenuSelection = int.Parse(Console.ReadLine());  // Get user's menu selection
            Console.Clear();

            switch (userMainMenuSelection)
            {
                case 1:
                    // Create a new goal
                    menu.DisplayNewGoalMenu();
                    int userNewGoalSelection = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Goal goal = null;

                    // Determine the type of goal to create based on user input
                    if (userNewGoalSelection == 1)
                    {
                        goal = new SimpleGoal();
                    }
                    else if (userNewGoalSelection == 2)
                    {
                        goal = new EternalGoal();
                    }
                    else
                    {
                        goal = new CheckListGoal();
                    }

                    // Display and get details for the new goal
                    if (goal != null)
                    {
                        goal.DisplayGoalName();
                        goal.DisplayGoalDescription();
                        goal.DisplayGoalPoints();
                        allGoals.addGoal(goal);  // Add the new goal to the list
                    }
                    break;

                case 2:
                    // List all goals
                    allGoals.DisplayGoals();
                    break;

                case 3:
                    // Save goals to a file
                    allGoals.SaveGoals();
                    break;

                case 4:
                    // Load goals from a file
                    allGoals.LoadGoals();
                    break;

                case 5:
                    // Record an event (mark a goal as completed)
                    allGoals.DisplayGoalRecordEvent();
                    break;

                case 6:
                    // Quit the program
                    Console.Write("Do you want to save before you quit (y/n)? ");
                    string userInput = Console.ReadLine();
                    if (userInput == "y")
                    {
                        allGoals.SaveGoals();  // Save goals if the user chooses to
                    }

                    Console.WriteLine();
                    Console.WriteLine("Thank you! Goodbye.");
                    break;

                default:
                    // Invalid selection
                    Console.WriteLine("Please select a valid option.");
                    break;
            }
        }
    }
}
