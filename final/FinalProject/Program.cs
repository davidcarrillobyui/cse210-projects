using System;
using System.Collections.Generic;

public class Program
{
    // Creating an instance of the PersonalFinanceManager class
    private static PersonalFinanceManager manager = new PersonalFinanceManager();

    public static void Main(string[] args)
    {
        // Initialize sample data for testing purposes
        InitializeSampleData();

        // Main menu loop
        bool running = true;
        while (running)
        {
            DisplayMainMenu();
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddTransactionMenu();
                    break;
                case "2":
                    AddSavingsGoalMenu();
                    break;
                case "3":
                    DisplayTithingDetails();
                    break;
                case "4":
                    GenerateAndDisplayReport();
                    break;
                case "5":
                    DisplayUserDetails();
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    // Display the main menu options to the user
    private static void DisplayMainMenu()
    {
        Console.WriteLine("\n--- Personal Finance Manager ---");
        Console.WriteLine("1. Add Transaction");
        Console.WriteLine("2. Add Savings Goal");
        Console.WriteLine("3. Display Tithing Details");
        Console.WriteLine("4. Generate Financial Report");
        Console.WriteLine("5. Display User Details");
        Console.WriteLine("6. Exit");
        Console.Write("Enter your choice: ");
    }

    // Submenu to add a new transaction
    private static void AddTransactionMenu()
    {
        Console.WriteLine("\n--- Add Transaction ---");
        Console.Write("Enter transaction type (income/expense): ");
        string type = Console.ReadLine();

        Console.Write("Enter date (yyyy-mm-dd): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter amount: ");
        decimal amount = decimal.Parse(Console.ReadLine());

        Console.Write("Enter category: ");
        string category = Console.ReadLine();

        Console.Write("Enter description: ");
        string description = Console.ReadLine();

        if (type.ToLower() == "income")
        {
            Console.Write("Enter income source: ");
            string incomeSource = Console.ReadLine();
            Income income = new Income(date, amount, category, description, incomeSource);
            manager.AddTransaction(income);
        }
        else if (type.ToLower() == "expense")
        {
            Console.Write("Enter payment method: ");
            string paymentMethod = Console.ReadLine();
            Expense expense = new Expense(date, amount, category, description, paymentMethod);
            manager.AddTransaction(expense);
        }
        else
        {
            Console.WriteLine("Invalid transaction type.");
        }
    }

    // Submenu to add a new savings goal
    private static void AddSavingsGoalMenu()
    {
        Console.WriteLine("\n--- Add Savings Goal ---");
        Console.Write("Enter goal name: ");
        string goalName = Console.ReadLine();

        Console.Write("Enter goal amount: ");
        decimal goalAmount = decimal.Parse(Console.ReadLine());

        SavingsGoal goal = new SavingsGoal(goalName, goalAmount);
        manager.AddSavingsGoal(goal);
    }

    // Display tithing details based on user input
    private static void DisplayTithingDetails()
    {
        Console.WriteLine("\n--- Tithing Details ---");
        Console.Write("Enter income amount: ");
        decimal incomeAmount = decimal.Parse(Console.ReadLine());

        Tithing tithing = new Tithing(incomeAmount);
        Console.WriteLine(tithing.GetTithingDetails());
    }

    // Generate and display a financial report
    private static void GenerateAndDisplayReport()
    {
        Console.WriteLine("\n--- Financial Report ---");
        Report report = manager.GenerateReport();
        Console.WriteLine(report.Content);
    }

    // Display details of all users
    private static void DisplayUserDetails()
    {
        Console.WriteLine("\n--- User Details ---");
        List<User> users = manager.GetUsers();
        foreach (var user in users)
        {
            Console.WriteLine(user.GetUserDetails());
        }
    }

    // Initialize sample data for testing purposes
    private static void InitializeSampleData()
    {
        // Create sample users
        User user1 = new User(1, "John Doe", "john.doe@example.com");
        manager.AddUser(user1);

        // Create sample transactions
        Income income1 = new Income(DateTime.Now, 1000, "Salary", "Monthly salary", "Company A");
        Expense expense1 = new Expense(DateTime.Now, 200, "Groceries", "Weekly groceries", "Credit Card");

        manager.AddTransaction(income1);
        manager.AddTransaction(expense1);

        // Create sample savings goals
        SavingsGoal goal1 = new SavingsGoal("Vacation", 2000);
        manager.AddSavingsGoal(goal1);
    }
}
