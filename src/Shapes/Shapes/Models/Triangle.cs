namespace Shapes.Models;

/// <summary>
/// Represents the triangle
/// </summary>
public sealed class Triangle : BaseShape
{
    public double A { get; }
    public double B { get; }
    public double C { get; }

    /// <summary>
    /// Creates new instance of Triangle by three side
    /// </summary>
    /// <param name="a">Side 1</param>
    /// <param name="b">Side 2</param>
    /// <param name="c">Side 3</param>
    public Triangle(double a, double b, double c)
    {
        ValidateValues(a, b, c);
        A = a;
        B = b;
        C = c;
    }
    
    /// <summary>
    /// Calculates area of this <see cref="Triangle"></see>
    /// </summary>
    /// <returns>Area</returns>
    public override double GetShapeArea()
    {
        var halfPerimeter = GetPerimeter() / 2;
        return Math.Sqrt(halfPerimeter * (halfPerimeter - A) * (halfPerimeter - B) * (halfPerimeter - C));
    }

    private double GetPerimeter() => A + B + C;

    private void ValidateValues(double a, double b, double c)
    {
        if (a < 0)
            ThrowLessThanZero(a);
        if (b < 0)
            ThrowLessThanZero(b);
        if (c < 0)
            ThrowLessThanZero(c);

        if (!(a + b >= c && a + c >= b && c + b >= a))
            ThrowWrongShapeProperties();
    }
}