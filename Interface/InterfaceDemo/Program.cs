/* This program demonstrate a simple example of Interface in c#. It defines an interface IShape with a method Area, 
   and two classes Circle and Rectangle that implement this interface. Each class provides its own implementation of the Area method.
    The Program class creates instances of Circle and Rectangle, and calls the Area method on each instance to calculate and print the area of the shapes.
*/

public interface IShape
{
    double Area();
}

public class Circle : IShape
{
    public double Radius { get; set; }
    public Circle(double radius)
    {
        Radius = radius;
    }
    public double Area()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }
    public double Area()
    {
        return Width * Height;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        IShape circle = new Circle(5);
        IShape rectangle = new Rectangle(4, 6);
        Console.WriteLine($"Circle Area: {circle.Area()}");
        Console.WriteLine($"Rectangle Area: {rectangle.Area()}");
    }
}