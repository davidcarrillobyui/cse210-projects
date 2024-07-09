using System;
using System.Collections.Generic;

public class Report
{
    public string ReportType { get; set; }
    public string Content { get; set; }

    public Report(string reportType, string content)
    {
        ReportType = reportType;
        Content = content;
    }

    public static string GenerateReport(List<Transaction> transactions, List<SavingsGoal> savingsGoals)
    {
        string reportContent = "Financial Report:\n\nTransactions:\n";
        
        foreach (var transaction in transactions)
        {
            reportContent += transaction.GetTransactionDetails() + "\n";
        }

        reportContent += "\nSavings Goals:\n";
        foreach (var goal in savingsGoals)
        {
            reportContent += goal.GetGoalDetails() + "\n";
        }

        return reportContent;
    }
}
