namespace AreaCalculator;

public abstract class Shape
{
    public abstract double GetArea();
}

public class Circle(double radius) : Shape
{
    public double Raduis { get; set; } = radius;

    public override double GetArea()
    {
        return Math.PI * Math.Pow(Raduis, 2);
    }
}