using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating instances using different constructors
        Fraction fraction1 = new Fraction( );
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3, 4);
        Fraction fraction4 = new Fraction(1,3);

        // Output using getters
        Console.WriteLine(fraction1.GetTop() + "/" + fraction1.GetBottom());
        Console.WriteLine(fraction2.GetTop() + "/" + fraction2.GetBottom());
        Console.WriteLine(fraction3.GetTop() + "/" + fraction3.GetBottom());

        // Output using GetFractionString and GetDecimalValue methods
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());
    }
}
    

    
