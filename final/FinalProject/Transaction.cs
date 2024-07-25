using System;

public abstract class Transaction
{
    // Properties common to all transactions
    public DateTime Date { get; protected set; }
    public decimal Amount { get; protected set; }
    public string Category { get; protected set; }
    public string Description { get; protected set; }

    // Constructor to initialize common properties
    protected Transaction(DateTime date, decimal amount, string category, string description)
    {
        Date = date;
        Amount = amount;
        Category = category;
        Description = description;
    }

    // Abstract method to be overridden by derived classes to get transaction details
    public abstract string GetTransactionDetails();

    // Abstract method to be overridden by derived classes to get transaction type
    public abstract string GetTransactionType();
}
