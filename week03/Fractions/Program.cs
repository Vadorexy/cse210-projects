using System;

class Program
{
    static void Main(string[] args)
    {
        // No parameters
        Fraction f1 = new Fraction();
        Console.WriteLine("Fraction 1: " + f1.GetFractionString());
        Console.WriteLine("Decimal: " + f1.GetDecimalValue());

        // One parameter (top only)
        Fraction f2 = new Fraction(5);
        Console.WriteLine("Fraction 2: " + f2.GetFractionString());
        Console.WriteLine("Decimal: " + f2.GetDecimalValue());

        // Two parameters
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine("Fraction 3: " + f3.GetFractionString());
        Console.WriteLine("Decimal: " + f3.GetDecimalValue());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine("Fraction 4: " + f4.GetFractionString());
        Console.WriteLine("Decimal: " + f4.GetDecimalValue());

        // For setters and getters
        f3.SetTop(3);
        f3.SetBottom(4);
        Console.WriteLine("\nAfter using setters:");
        Console.WriteLine("Fraction 3 updated: " + f3.GetFractionString());
        Console.WriteLine("Decimal: " + f3.GetDecimalValue());

    }
}