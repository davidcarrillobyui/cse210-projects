public class Tithing
{
    // Property for IncomeAmount
    public decimal IncomeAmount { get; private set; }

    // Constructor to initialize IncomeAmount
    public Tithing(decimal incomeAmount)
    {
        IncomeAmount = incomeAmount;
    }

    // Method to calculate and get tithing details
    public string GetTithingDetails()
    {
        decimal tithingAmount = IncomeAmount * 0.10m;
        return $"Tithing: 10% of {IncomeAmount} is {tithingAmount}";
    }
}
