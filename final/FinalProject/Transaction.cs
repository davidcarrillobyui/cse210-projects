using System;

public abstract class Transaction
{
    public DateTime Date { get; set; }
    public decimal Amount { get; set; }
    public string Category { get; set; }
    public string Description { get; set; }

    public Transaction(DateTime date, decimal amount, string category, string description)
    {
        Date = date;
        Amount = amount;
        Category = category;
        Description = description;
    }

    public abstract string GetTransactionDetails();
}
