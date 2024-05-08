using System;

public class Fraction
{
    private int top;
    private int bottom;

    // Constructors
    public Fraction()
    {
        top = 1;
        bottom = 1;
    }

    public Fraction(int top)
    {
        this.top = top;
        bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        this.top = top;
        this.bottom = bottom;
    }

    // Getters and setters
    public int GetTop()
    {
        return top;
    }

    public void SetTop(int top)
    {
        this.top = top;
    }

    public int GetBottom()
    {
        return bottom;
    }

    public void SetBottom(int bottom)
    {
        if (bottom != 0)
            this.bottom = bottom;
        else
            Console.WriteLine("Denominator cannot be zero.");
    }

    // Method to return the fraction as a string
    public string GetFractionString()
    {
        return $"{top}/{bottom}";
    }

    // Method to return the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)top / bottom;
    }
}
