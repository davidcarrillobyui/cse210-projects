using System;

public abstract class Transaction
{
    // Properties common to all transactions
    public DateTime Date { get; set; }
    public decimal Amount { get; set; }
    public string Category { get; set; }
    public string Description { get; set; }

    // Constructor to initialize common properties
    public Transaction(DateTime date, decimal amount, string category, string description)
    {
        Date = date;
        Amount = amount;
        Category = category;
        Description = description;
    }

    // Abstract method to be overridden by derived classes to get transaction details
    public abstract string GetTransactionDetails();
}
