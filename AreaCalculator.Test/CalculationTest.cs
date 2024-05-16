namespace AreaCalculator.Test;

public class CalculationTest
{
    [Fact]
    public void TestCircleCalculation()
    {
        var circle = new Circle(Math.PI);
        var difference = Math.Abs(Math.Pow(Math.PI, 3) - circle.GetArea());
        Assert.True(difference < 0.00000000000000000000000001, "Error: circle area calculation is not correct");
    }//поскольку double числа не всегда сходятся, а decimal не совсем приемлемо использовать в инженерных рассчётах, то я выбрал просто 
    // просто задать точность разности теоретического и вычисляемого результатов вот таким путём

    [Fact]
    public void TestTriangleCalculation()
    {
        var triangle = new Triangle(3, 4, 5);
        var difference = Math.Abs(6 - triangle.GetArea());
        Assert.True(difference < 0.00000000000000000000000001, "Error: triangle area calculation is not correct");
    }

    [Fact]
    public void RightTriangleTest()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.True(triangle.IsTriangleRight(),"Error: triangle  is not right");
    }
}