namespace Calculator.Figures;

public class Triangle : AbstractFigure
{
    public double FirstSide { get; private set; }
    public double SecondSide { get; private set; }
    public double ThirdSide { get; private set; }
    public bool IsRightAngled => _isRightAngled.Value;
    private double[] _sides;
    private double _semiPerimeter;
    private readonly Lazy<bool> _isRightAngled;

    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
            throw new ArgumentOutOfRangeException("Triangle side can't be zero or negative");
        _sides = new[] {firstSide, secondSide, thirdSide};
        _semiPerimeter = _sides.Sum() / 2;
        if (_semiPerimeter < firstSide || _semiPerimeter < secondSide || _semiPerimeter < thirdSide)
            throw new ArgumentOutOfRangeException("SemiPerimetr of triangle can't be < of each side");
        FirstSide = firstSide;
        SecondSide = secondSide;
        ThirdSide = thirdSide;
        _isRightAngled = new Lazy<bool>(CheckAngle);
    }

    private bool CheckAngle()
    {
        var maxSide = _sides.Max();
        return 2 * Math.Pow(maxSide, 2) == Math.Pow(FirstSide, 2) + Math.Pow(SecondSide, 2) +
            Math.Pow(ThirdSide, 2);
    }

    protected override double CalculateSquare()
    {
        return Math.Sqrt(_semiPerimeter * (_semiPerimeter - FirstSide) * (_semiPerimeter - SecondSide) *
                         (_semiPerimeter - ThirdSide));
    }
}