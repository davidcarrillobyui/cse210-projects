using System;
using System.Collections.Generic;

public class PersonalFinanceManager
{
    private List<Transaction> transactions = new List<Transaction>();
    private List<SavingsGoal> savingsGoals = new List<SavingsGoal>();
    private List<User> users = new List<User>();
    private List<Report> reports = new List<Report>();

    public void AddTransaction(Transaction transaction)
    {
        transactions.Add(transaction);
    }

    public void RemoveTransaction(Transaction transaction)
    {
        transactions.Remove(transaction);
    }

    public decimal CalculateTithing(decimal income)
    {
        return income * 0.10m;
    }

    public void AddSavingsGoal(SavingsGoal goal)
    {
        savingsGoals.Add(goal);
    }

    public void RemoveSavingsGoal(SavingsGoal goal)
    {
        savingsGoals.Remove(goal);
    }

    public void AddUser(User user)
    {
        users.Add(user);
    }

    public Report GenerateReport()
    {
        string content = Report.GenerateReport(transactions, savingsGoals);
        Report report = new Report("Financial Report", content);
        reports.Add(report);
        return report;
    }

    public List<Transaction> GetTransactions()
    {
        return transactions;
    }

    public List<SavingsGoal> GetSavingsGoals()
    {
        return savingsGoals;
    }

    public List<User> GetUsers()
    {
        return users;
    }
}
