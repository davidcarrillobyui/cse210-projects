using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class PersonalFinanceManager
{
    // List to store all transactions
    private List<Transaction> _transactions = new List<Transaction>();
    
    // List to store all savings goals
    private List<SavingsGoal> _savingsGoals = new List<SavingsGoal>();

    // Dictionary to store monthly budgets
    private Dictionary<string, decimal> _monthlyBudgets = new Dictionary<string, decimal>();

    // List to store users
    private List<User> _users = new List<User>();

    // Method to add a new transaction
    public void AddTransaction(Transaction transaction)
    {
        _transactions.Add(transaction);
    }

    // Method to add a new savings goal
    public void AddSavingsGoal(SavingsGoal goal)
    {
        _savingsGoals.Add(goal);
    }

    // Method to add a new monthly budget
    public void AddMonthlyBudget(MonthlyBudget budget)
    {
        _monthlyBudgets[budget.Month] = budget.Amount;
    }

    // Method to generate a financial report
    public Report GenerateReport()
    {
        string content = "Financial Report\n\n";

        content += "Transactions:\n";
        foreach (var transaction in _transactions)
        {
            content += transaction.GetTransactionDetails() + "\n";
        }

        content += "\nSavings Goals:\n";
        foreach (var goal in _savingsGoals)
        {
            content += goal.GetSavingsGoalDetails() + "\n";
        }

        content += "\nMonthly Budgets:\n";
        foreach (var budget in _monthlyBudgets)
        {
            content += $"Month: {budget.Key}, Amount: {budget.Value}\n";
        }

        return new Report(content);
    }

    // Method to add a new user
    public void AddUser(User user)
    {
        _users.Add(user);
    }

    // Method to get a list of all users
    public List<User> GetUsers()
    {
        return _users;
    }

    // Method to save data to a JSON file
    public void SaveData(string username)
    {
        var data = new
        {
            Transactions = _transactions,
            SavingsGoals = _savingsGoals,
            MonthlyBudgets = _monthlyBudgets,
            Users = _users
        };

        string json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText($"{username}_data.json", json);
    }

    // Method to load data from a JSON file
    public void LoadData(string username)
    {
        if (File.Exists($"{username}_data.json"))
        {
            string json = File.ReadAllText($"{username}_data.json");
            var data = JsonSerializer.Deserialize<FinanceData>(json);

            _transactions = data.Transactions;
            _savingsGoals = data.SavingsGoals;
            _monthlyBudgets = data.MonthlyBudgets;
            _users = data.Users;
        }
        else
        {
            Console.WriteLine("Data file not found.");
        }
    }

    // Class to hold serialized data for JSON deserialization
    private class FinanceData
    {
        public List<Transaction> Transactions { get; set; }
        public List<SavingsGoal> SavingsGoals { get; set; }
        public Dictionary<string, decimal> MonthlyBudgets { get; set; }
        public List<User> Users { get; set; }
    }
}
