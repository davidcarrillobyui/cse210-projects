public class MonthlyBudget
{
    // Properties for MonthlyBudget
    public string Month { get; set; }
    public decimal BudgetAmount { get; set; }

    // Constructor to initialize MonthlyBudget properties
    public MonthlyBudget(string month, decimal budgetAmount)
    {
        Month = month;
        BudgetAmount = budgetAmount;
    }

    // Method to get details of the monthly budget
    public string GetMonthlyBudgetDetails()
    {
        return $"Month: {Month}, Budget Amount: {BudgetAmount}";
    }
}
