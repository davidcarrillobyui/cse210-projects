using System;

public class SavingsGoal
{
    public string GoalName { get; set; }
    public decimal GoalAmount { get; set; }
    public decimal Progress { get; set; }

    public SavingsGoal(string goalName, decimal goalAmount)
    {
        GoalName = goalName;
        GoalAmount = goalAmount;
        Progress = 0;
    }

    public void AddProgress(decimal amount)
    {
        Progress += amount;
    }

    public string GetGoalDetails()
    {
        return $"Savings Goal: {GoalName}, Target: {GoalAmount:C}, Progress: {Progress:C}";
    }
}
