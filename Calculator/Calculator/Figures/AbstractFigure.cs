namespace Calculator.Figures;

public abstract class AbstractFigure
{
    private readonly Lazy<double> _square;
    public double Square => _square.Value;

    protected AbstractFigure()
    {
        _square = new Lazy<double>(CalculateSquare);
    }

    protected abstract double CalculateSquare();

}