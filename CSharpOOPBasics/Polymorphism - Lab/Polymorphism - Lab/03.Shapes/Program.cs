using System;

public class Program
{
    public static void Main()
    {
        Circle circle = new Circle(5);
        Console.WriteLine(circle.CalculateArea());
        Console.WriteLine(circle.CalculatePerimeter());
    }
}