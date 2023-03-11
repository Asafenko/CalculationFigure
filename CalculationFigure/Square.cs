using System.Runtime.CompilerServices;
using CalculationFigure;

namespace Figure.Tests;

public class Square : IFigure
{
    public double Side { get; }
    public Square(double side)
    {
        if (side <= 0) throw new ArgumentOutOfRangeException(nameof(side));
        
        Side = side;
    }

    public double GetArea()
    {
        throw new NotImplementedException();
    }
}