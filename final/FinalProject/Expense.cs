using System;

public class Expense : Transaction
{
    // Property specific to Expense transactions
    public string PaymentMethod { get; private set; }

    // Constructor to initialize Expense properties
    public Expense(DateTime date, decimal amount, string category, string description, string paymentMethod)
        : base(date, amount, category, description)
    {
        PaymentMethod = paymentMethod;
    }

    // Override method to get expense transaction details
    public override string GetTransactionDetails()
    {
        return $"Expense - Date: {Date}, Amount: {Amount}, Category: {Category}, Description: {Description}, Payment Method: {PaymentMethod}";
    }

    // Override method to get transaction type
    public override string GetTransactionType()
    {
        return "Expense";
    }
}
