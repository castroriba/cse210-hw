using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of Fraction using different constructors
        Fraction frac1 = new Fraction();
        Fraction frac2 = new Fraction(6);
        Fraction frac3 = new Fraction(3, 4);

        // Display fraction and decimal values for frac1
        Console.WriteLine($"Fraction: {frac1.GetFractionString()}");
        Console.WriteLine($"Decimal: {frac1.GetDecimalValue()}");

        // Display fraction and decimal values for frac2
        Console.WriteLine($"Fraction: {frac2.GetFractionString()}");
        Console.WriteLine($"Decimal: {frac2.GetDecimalValue()}");

        // Display fraction and decimal values for frac3
        Console.WriteLine($"Fraction: {frac3.GetFractionString()}");
        Console.WriteLine($"Decimal: {frac3.GetDecimalValue()}");

        // Set new values for frac1 and display them
        frac1.SetNumerator(1);
        frac1.SetDenominator(3);
        Console.WriteLine($"Fraction: {frac1.GetFractionString()}");
        Console.WriteLine($"Decimal: {frac1.GetDecimalValue()}");

        // Set new values for frac2 and display them
        frac2.SetNumerator(5);
        frac2.SetDenominator(8);
        Console.WriteLine($"Fraction: {frac2.GetFractionString()}");
        Console.WriteLine($"Decimal: {frac2.GetDecimalValue()}");
    }
}
