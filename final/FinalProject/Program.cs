using System;
using System.Collections.Generic;

public class Program
{
    // Creating an instance of the PersonalFinanceManager class
    private static PersonalFinanceManager manager = new PersonalFinanceManager();

    public static void Main(string[] args)
    {
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
                    AddMonthlyBudgetMenu();
                    break;
                case "4":
                    DisplayTithingDetails();
                    break;
                case "5":
                    GenerateAndDisplayReport();
                    break;
                case "6":
                    DisplayUserDetails();
                    break;
                case "7":
                    SaveData();
                    break;
                case "8":
                    LoadData();
                    break;
                case "9":
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
        Console.WriteLine("3. Add Monthly Budget");
        Console.WriteLine("4. Display Tithing Details");
        Console.WriteLine("5. Generate Financial Report");
        Console.WriteLine("6. Display User Details");
        Console.WriteLine("7. Save Data");
        Console.WriteLine("8. Load Data");
        Console.WriteLine("9. Exit");
        Console.Write("Enter your choice: ");
    }

    // Submenu to add a new transaction
    private static void AddTransactionMenu()
    {
        Console.WriteLine("\n--- Add Transaction ---");
        Console.Write("Enter transaction type (income/expense): ");
        string type = Console.ReadLine();

        DateTime date = ReadDateInput("Enter date (yyyy-mm-dd): ");

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

    // Submenu to add a new monthly budget
    private static void AddMonthlyBudgetMenu()
    {
        Console.WriteLine("\n--- Add Monthly Budget ---");
        Console.Write("Enter month (e.g., 2024-07): ");
        string month = Console.ReadLine();

        Console.Write("Enter budget amount: ");
        decimal amount = decimal.Parse(Console.ReadLine());

        MonthlyBudget budget = new MonthlyBudget(month, amount);
        manager.AddMonthlyBudget(budget);
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

    // Save data to JSON file
    private static void SaveData()
    {
        Console.Write("Enter username to save data: ");
        string username = Console.ReadLine();
        manager.SaveData(username);
        Console.WriteLine("Data saved successfully.");
    }

    // Load data from JSON file
    private static void LoadData()
    {
        Console.Write("Enter username to load data: ");
        string username = Console.ReadLine();
        manager.LoadData(username);
        Console.WriteLine("Data loaded successfully.");
    }

    // Method to handle invalid input gracefully
    private static string ReadUserInput(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }

    // Method to parse date input with validation
    private static DateTime ReadDateInput(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (DateTime.TryParse(Console.ReadLine(), out DateTime date))
            {
                return date;
            }
            Console.WriteLine("Invalid input. Please enter a valid date in yyyy-mm-dd format.");
        }
    }
}
