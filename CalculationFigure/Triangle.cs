namespace CalculationFigure;

public class Triangle : IFigure
{
    public double A { get; }
    public double B { get; }
    public double C { get; }
    public Triangle(double a, double b, double c)
    {
        // if (a <= 0 || b <= 0 || c <= 0)
        // {
        //     throw new ArgumentOutOfRangeException("Sides of triangle cant be equal to: 0");
        // }
        if (double.IsNaN(a)) throw new ArithmeticException(nameof(a));
        if (double.IsNaN(b))  throw new ArithmeticException(nameof(b));
        if (double.IsNaN(c)) throw new ArithmeticException(nameof(c));
        
        if (a <= 0) throw new ArgumentOutOfRangeException(nameof(a));
        if (b <= 0) throw new ArgumentOutOfRangeException(nameof(b));
        if (c <= 0) throw new ArgumentOutOfRangeException(nameof(c));
        
        if (!IsTriangle(a, b, c))
        {
            throw new Exception("it is not triangle !");
        }
        
        A = a;
        B = b;
        C = c;
    }

    public static bool IsTriangle(double a, double b, double c)
    {
        return (a + c > b && a + b > c && b + c > a);

    }

    public double GetArea()
    {
        var p = (A + B + C) / 2;
        var s = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        return s;
        
    }
}