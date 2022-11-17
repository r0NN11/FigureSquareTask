namespace Calculator.Figures;

public class Circle : AbstractFigure
{
    public double Radius { get; }

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentOutOfRangeException("Negative/zero radius");

        Radius = radius;
    }

    protected sealed override double CalculateSquare()
    {
        return Math.PI * Radius * Radius;
    }
}