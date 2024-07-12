using System;

public class Expense : Transaction
{
    // Specific property for Expense
    public string PaymentMethod { get; set; }

    // Constructor to initialize Expense properties
    public Expense(DateTime date, decimal amount, string category, string description, string paymentMethod)
        : base(date, amount, category, description)
    {
        PaymentMethod = paymentMethod;
    }

    // Overriding the method to get details of an expense transaction
    public override string GetTransactionDetails()
    {
        return $"Expense: {Amount} for {Category} paid with {PaymentMethod} on {Date.ToShortDateString()}";
    }
}
