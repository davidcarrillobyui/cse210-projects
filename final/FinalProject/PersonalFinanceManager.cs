using System;
using System.Collections.Generic;

public class PersonalFinanceManager
{
    // List to store all transactions
    private List<Transaction> transactions = new List<Transaction>();
    
    // List to store all savings goals
    private List<SavingsGoal> savingsGoals = new List<SavingsGoal>();
    
    // List to store all users
    private List<User> users = new List<User>();

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

    // Method to generate a financial report (placeholder)
    public Report GenerateReport()
    {
        // Placeholder for report generation logic
        return new Report("Sample Report Content");
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
}
