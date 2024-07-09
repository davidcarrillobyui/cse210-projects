using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Create a PersonalFinanceManager instance
        PersonalFinanceManager manager = new PersonalFinanceManager();

        // Create users
        User user1 = new User(1, "John Doe", "john.doe@example.com");
        manager.AddUser(user1);

        // Create transactions
        Income income1 = new Income(DateTime.Now, 1000, "Salary", "Monthly salary", "Company A");
        Expense expense1 = new Expense(DateTime.Now, 200, "Groceries", "Weekly groceries", "Credit Card");

        manager.AddTransaction(income1);
        manager.AddTransaction(expense1);

        // Create savings goals
        SavingsGoal goal1 = new SavingsGoal("Vacation", 2000);
        manager.AddSavingsGoal(goal1);

        // Calculate tithing
        Tithing tithing = new Tithing(income1.Amount);
        Console.WriteLine(tithing.GetTithingDetails());

        // Generate and display a report
        Report report = manager.GenerateReport();
        Console.WriteLine(report.Content);
    }
}
