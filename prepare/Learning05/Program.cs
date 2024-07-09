// Program.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of each shape
        Square square = new Square("Red", 4);
        Rectangle rectangle = new Rectangle("Blue", 5, 7);
        Circle circle = new Circle("Green", 3);

        // Create a list to hold shapes
        List<Shape> shapes = new List<Shape> { square, rectangle, circle };

        // Iterate through the list and display the color and area of each shape
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}
