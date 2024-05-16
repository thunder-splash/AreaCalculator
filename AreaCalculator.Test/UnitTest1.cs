namespace AreaCalculator.Test;

public class UnitTest1
{
    [Fact]
    public void TestCircleCalculation()
    {
        var circle = new Circle(Math.PI);
        Assert.Equal(Math.Pow(Math.PI, 3), circle.GetArea(), 1);
    }
}