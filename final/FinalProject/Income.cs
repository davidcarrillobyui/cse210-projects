using System;

public class Income : Transaction
{
    // Specific property for Income
    public string IncomeSource { get; set; }

    // Constructor to initialize Income properties
    public Income(DateTime date, decimal amount, string category, string description, string incomeSource)
        : base(date, amount, category, description)
    {
        IncomeSource = incomeSource;
    }

    // Overriding the method to get details of an income transaction
    public override string GetTransactionDetails()
    {
        return $"Income: {Amount} from {IncomeSource} on {Date.ToShortDateString()}";
    }
}
