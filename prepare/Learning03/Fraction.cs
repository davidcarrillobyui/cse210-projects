using System;

public class Fraction
{
    // Step 3: Declare private attributes for the numerator and denominator
    private int numerator;
    private int denominator;

    // Step 4: Create the constructors

    // Constructor that initializes the fraction to 1/1
    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }

    // Constructor that initializes the fraction to anyNumber/1
    public Fraction(int anyNumber)
    {
        numerator = anyNumber;
        denominator = 1;
    }

    // Constructor that initializes the fraction to top/bottom
    public Fraction(int top, int bottom)
    {
        numerator = top;
        denominator = bottom;
    }

    /*a method to display the fraction:
    public void DisplayFraction()
    {
        Console.WriteLine($"{numerator}/{denominator}");
    }
    */

    public string GetFraction()
    {
        string text = $"{numerator}/{denominator}";
        return text;
    }

    public double GetDecimal()
    {
        return (double)numerator/denominator;
    }







} //class