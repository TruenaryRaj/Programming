/* This program demonstrate an example of polymorphism where the base abstract class Shape has both abstract and concrete method. But the concrete
 * method available calls the abstract method CalculateArea() which is overridden in the derived class Circle and Rectangle. 
 * Abstract class i.e base class have abstract and concrete method but the derived classes have their own defination of the abstract method and 
 * their respective fields so that the CalculateArea() method can be called on the base class reference. 
*/
public abstract class Shape
{
    public abstract double CalculateArea();

    public void DisplayInfo()
    {
        Console.WriteLine($"Calculated Area:{CalculateArea():f2}");
    }
}

public class Circle : Shape
{
    private double _radius { get; set; }

    public Circle(double radious)
    {
        _radius = radious;
    }
    public override double CalculateArea()
    {
        return Math.PI * _radius * _radius;
    }
    
}

public class Rectangle : Shape
{
    private double _length { get; set; }
    private double _breadth { get; set; }

    public Rectangle( double length , double breadth)
    {
        _length = length;
        _breadth = breadth;
    }
    public override double CalculateArea() 
    {
        return _length * _breadth ;
    }
}

public class Program
{
    static void Main()
    {
        Shape circle = new Circle(10);
        circle.DisplayInfo();

        Shape rectangle = new Rectangle(10, 10);
        rectangle.DisplayInfo();

    }
}