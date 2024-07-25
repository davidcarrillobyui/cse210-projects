using System;

public class Income : Transaction
{
    // Property specific to Income transactions
    public string IncomeSource { get; private set; }

    // Constructor to initialize Income properties
    public Income(DateTime date, decimal amount, string category, string description, string incomeSource)
        : base(date, amount, category, description)
    {
        IncomeSource = incomeSource;
    }

    // Override method to get income transaction details
    public override string GetTransactionDetails()
    {
        return $"Income - Date: {Date}, Amount: {Amount}, Category: {Category}, Description: {Description}, Source: {IncomeSource}";
    }

    // Override method to get transaction type
    public override string GetTransactionType()
    {
        return "Income";
    }
}
