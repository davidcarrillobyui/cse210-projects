public class MonthlyBudget
{
    // Properties for MonthlyBudget
    public string Month { get; private set; }
    public decimal Amount { get; private set; }

    // Constructor to initialize MonthlyBudget properties
    public MonthlyBudget(string month, decimal amount)
    {
        Month = month;
        Amount = amount;
    }

    // Method to get budget details
    public string GetBudgetDetails()
    {
        return $"Month: {Month}, Budget Amount: {Amount}";
    }
}
