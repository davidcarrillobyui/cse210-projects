using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class PersonalFinanceManager
{
    // List to store all transactions
    private List<Transaction> transactions = new List<Transaction>();
    
    // List to store all savings goals
    private List<SavingsGoal> savingsGoals = new List<SavingsGoal>();
    
    // List to store all users
    private List<User> users = new List<User>();
    
    // List to store all monthly budgets
    private List<MonthlyBudget> monthlyBudgets = new List<MonthlyBudget>();

    // Method to add a transaction (income or expense)
    public void AddTransaction(Transaction transaction)
    {
        transactions.Add(transaction);
    }

    // Method to add a savings goal
    public void AddSavingsGoal(SavingsGoal goal)
    {
        savingsGoals.Add(goal);
    }

    // Method to add a monthly budget
    public void AddMonthlyBudget(MonthlyBudget budget)
    {
        monthlyBudgets.Add(budget);
    }

    // Method to generate a financial report
    public Report GenerateReport()
    {
        string reportContent = "Financial Report\n";
        reportContent += "=================\n";

        decimal totalIncome = 0;
        decimal totalExpense = 0;

        foreach (var transaction in transactions)
        {
            if (transaction is Income income)
            {
                totalIncome += income.Amount;
                reportContent += income.GetTransactionDetails() + "\n";
            }
            else if (transaction is Expense expense)
            {
                totalExpense += expense.Amount;
                reportContent += expense.GetTransactionDetails() + "\n";
            }
        }

        reportContent += "\nSummary:\n";
        reportContent += $"Total Income: {totalIncome}\n";
        reportContent += $"Total Expense: {totalExpense}\n";
        reportContent += $"Net Savings: {totalIncome - totalExpense}\n";

        return new Report(reportContent);
    }

    // Method to add a user
    public void AddUser(User user)
    {
        users.Add(user);
    }

    // Method to get the list of users
    public List<User> GetUsers()
    {
        return users;
    }

    // Save data to JSON file
    public void SaveData(string username)
    {
        var data = new
        {
            Transactions = transactions,
            SavingsGoals = savingsGoals,
            Users = users,
            MonthlyBudgets = monthlyBudgets
        };

        string jsonData = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText($"{username}.json", jsonData);
    }

    // Load data from JSON file
    public void LoadData(string username)
    {
        if (File.Exists($"{username}.json"))
        {
            string jsonData = File.ReadAllText($"{username}.json");
            var data = JsonSerializer.Deserialize<dynamic>(jsonData);

            transactions = JsonSerializer.Deserialize<List<Transaction>>(data["Transactions"].ToString());
            savingsGoals = JsonSerializer.Deserialize<List<SavingsGoal>>(data["SavingsGoals"].ToString());
            users = JsonSerializer.Deserialize<List<User>>(data["Users"].ToString());
            monthlyBudgets = JsonSerializer.Deserialize<List<MonthlyBudget>>(data["MonthlyBudgets"].ToString());
        }
    }
}
