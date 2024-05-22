using System;

public class Fraction
{
    /*Step 3: 
    Create a class to hold fraction.
    The class should be in its own file.
    The class should have two attributes for the top and bottom numbers.
    Make sure the attributes are private.
    */
    private int numerator;
    private int denominator;

    //Step 4: Create the Constructors

    public Fraction()
    {
        numerator= 1;
        denominator=1;
    }

    public Fraction(int aNumber)
    {
        numerator=aNumber;
        denominator= 1;

    }

    public Fraction(int top, int bottom)
    {
        numerator=top;
        denominator=bottom;

    }












} //class