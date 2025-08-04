using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        Console.WriteLine();
        // Create a list to store shapes
        List<Shape> shapes = new List<Shape>();

        // Create a square and add to list
        Square s_1 = new Square("Red", 5.0);
        shapes.Add(s_1);

        // Create a rectangle and add to list
        Rectangle r_1 = new Rectangle("Blue", 4.0, 6.0);
        shapes.Add(r_1);

        // Create a circle and add to list
        Circle c_1 = new Circle("Green", 3.0);
        shapes.Add(c_1);

        // Display Information
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Type: {shape.GetType().Name}");
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea():F2}");

            Console.WriteLine(); // Space between shapes
            Console.WriteLine(); // Space between shapes (DOUBLE SPACE)
        }

    }
}