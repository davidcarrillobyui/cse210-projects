public class SavingsGoal
{
    // Properties for SavingsGoal
    public string GoalName { get; private set; }
    public decimal GoalAmount { get; private set; }
    public decimal AmountSaved { get; private set; }

    // Constructor to initialize SavingsGoal properties
    public SavingsGoal(string goalName, decimal goalAmount)
    {
        GoalName = goalName;
        GoalAmount = goalAmount;
        AmountSaved = 0;
    }

    // Method to get details of the savings goal
    public string GetSavingsGoalDetails()
    {
        return $"Goal: {GoalName}, Amount: {GoalAmount}, Saved: {AmountSaved}";
    }

    // Method to update saved amount
    public void UpdateSavedAmount(decimal amount)
    {
        AmountSaved += amount;
    }
}
