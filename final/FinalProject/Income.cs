using System;

public class Income : Transaction
{
    public string IncomeSource { get; set; }

    public Income(DateTime date, decimal amount, string category, string description, string incomeSource)
        : base(date, amount, category, description)
    {
        IncomeSource = incomeSource;
    }

    public override string GetTransactionDetails()
    {
        return $"Income: {Amount:C} from {IncomeSource} on {Date.ToShortDateString()} - {Description}";
    }
}
