namespace CalculationFigure;

public class Circle : IFigure
{
    public double Radius { get; set; }
    
    public Circle(double radius)
    {
        if (radius <= 0) throw new ArgumentOutOfRangeException(nameof(radius));

        Radius = radius;
    }

    public double GetArea()
    {
        return ((Radius * Radius) * Math.PI);
    }
}