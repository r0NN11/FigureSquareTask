using Calculator.Figures;

namespace CalculatorTests;

public class CalculatorTests
{
    [Test]
    public void NegativeZeroRadiusTest()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-1));
        Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(0));
    }

    [Test]
    public void CircleSquareCalculationTest()
    {
        //Arrange
        var circle = new Circle(1);

        //Act
        var circleSquare = circle.Square;

        //Assert
        Assert.That(circleSquare, Is.EqualTo(Math.PI));
    }

    [Test]
    public void NegativeSidesTest()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, 0, 0));
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, -1, 0));
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 0, -1));
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, -1, -1));
    }

    [Test]
    public void RightAngleTest()
    {
        //Arrange
        var triangle = new Triangle(3, 4, 5);

        //Act
        var isTriangleRightAngled = triangle.IsRightAngled;

        //Assert
        Assert.That(isTriangleRightAngled, Is.EqualTo(true));
    }

    [Test]
    public void NotRightAngleTest()
    {
        //Arrange
        var triangle = new Triangle(2, 4, 5);

        //Act
        var isTriangleRightAngled = triangle.IsRightAngled;

        //Assert
        Assert.That(isTriangleRightAngled, Is.EqualTo(false));
    }

    [Test]
    public void TriangleSquareCalculationTest()
    {
        //Arrange
        var triangle = new Triangle(3, 4, 5);

        //Act
        var triangleSquare = triangle.Square;

        //Assert
        Assert.That(triangleSquare, Is.EqualTo(6));
    }
}