using System;

class Program
{
    static void Main(string[] args)
    {
        // Using the default constructor (1/1)
        Fraction fraction1 = new Fraction();
        //fraction1.DisplayFraction();  // Output: 1/1
        Console.WriteLine(fraction1.GetFraction());
        Console.WriteLine(fraction1.GetDecimal());

        // Using the constructor with one parameter (6/1)
        Fraction fraction2 = new Fraction(6);
        //fraction2.DisplayFraction();  // Output: 6/1
        Console.WriteLine(fraction2.GetFraction());
        Console.WriteLine(fraction2.GetDecimal());

        // Using the constructor with two parameters (6/7)
        Fraction fraction3 = new Fraction(6, 7);
        //fraction3.DisplayFraction();  // Output: 6/7
        Console.WriteLine(fraction3.GetFraction());
        Console.WriteLine(fraction3.GetDecimal());

        
        
    }
}