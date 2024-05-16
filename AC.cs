namespace AreaCalculator;

public abstract class Shape
{
    public abstract double GetArea();
}//Нужен для реализации критерия: "Вычисление площади фигуры без знания типа фигуры в compile-time"

public class Circle(double radius) : Shape
{
    private double Raduis { get; set; } = radius;

    public override double GetArea()
    {
        return Math.PI * Math.Pow(Raduis, 2);
    }
}

public class Triangle(double a, double b, double c) : Shape
{
    private double A { get; set; } = a;
    private double B { get; set; } = b;
    private double C { get; set; } = c;

    public override double GetArea()
    {
        var p = (A + B + C) / 2;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }

    public bool IsTriangleRight()
    {
        double[] side = [A, B, C];
        Array.Sort(side);
        Array.Reverse(side);
        return Math.Abs(Math.Pow(side[0], 2) - (Math.Pow(side[1], 2) + Math.Pow(side[2], 2))) < 0.000000000000000000000001;
    }//Проверка треугольника на "прямоугольность" (один из критериев). К этому методу тоже есть юнит тест
}