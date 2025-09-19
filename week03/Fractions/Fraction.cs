using System;

public class Fraction
{

    private int _top;
    private int _bottom;

    // No parameters (defaults to 1/1)
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // One parameter (top only, bottom = 1)
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // Two parameters (top and bottom)
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getters and Setters
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        // Can't be divided by zero
        if (bottom == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        _bottom = bottom;
    }

    //Return fraction as string
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Return decimal value
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}