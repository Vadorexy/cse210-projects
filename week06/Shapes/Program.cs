using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Test a single square
        Square square = new Square("Blue", 5);
        Console.WriteLine($"Square Color: {square.GetColor()}");
        Console.WriteLine($"Square Area: {square.GetArea()}");

        Console.WriteLine();

        // List of shapes
        List<Shape> shapes = new List<Shape>();

        // Add one of each
        shapes.Add(new Square("Red", 4));
        shapes.Add(new Rectangle("Green", 3, 6));
        shapes.Add(new Circle("Yellow", 2.5));

        // Iterate all shapes and display info
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}");
            Console.WriteLine($"Shape Area: {Math.Round(shape.GetArea(), 2)}");
            Console.WriteLine("----------------------");
        }
    }
}