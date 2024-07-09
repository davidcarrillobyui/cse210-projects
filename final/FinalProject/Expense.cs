using System;

public class Expense : Transaction
{
    public string PaymentMethod { get; set; }

    public Expense(DateTime date, decimal amount, string category, string description, string paymentMethod)
        : base(date, amount, category, description)
    {
        PaymentMethod = paymentMethod;
    }

    public override string GetTransactionDetails()
    {
        return $"Expense: {Amount:C} paid by {PaymentMethod} on {Date.ToShortDateString()} - {Description}";
    }
}
