using System;

public class Tithing
{
    public decimal TithingAmount { get; set; }

    public Tithing(decimal income)
    {
        TithingAmount = CalculateTithing(income);
    }

    private decimal CalculateTithing(decimal income)
    {
        return income * 0.10m;
    }

    public string GetTithingDetails()
    {
        return $"Tithing Amount: {TithingAmount:C}";
    }
}
