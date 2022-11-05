namespace Shapes.Models;

/// <summary>
/// Represents the circle
/// </summary>
public sealed class Circle : BaseShape
{
    /// <summary>
    /// Radius of the Circle
    /// </summary>
    public double Radius { get; }

    /// <summary>
    /// Creates new instance of <see cref="Circle"/> by radius
    /// </summary>
    /// <param name="radius">Radius of the circle</param>
    public Circle(double radius)
    {
        if (radius < 0)
            ThrowLessThanZero(radius);
        Radius = radius;
    }

    public override double GetShapeArea() => Math.PI * Radius * Radius;
}