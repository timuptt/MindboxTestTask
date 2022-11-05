using Shapes.Exceptions;

namespace Shapes.Models;

/// <summary>
/// Represents base geometrical shape
/// </summary>
public abstract class BaseShape
{
    /// <summary>
    /// Area calculation abstract method
    /// <para>Override this method to calculate your shape area</para>
    /// <example>
    /// <code>
    /// protected internal override double GetShapeArea()
    /// {
    ///    return Math.PI * Radius * Radius;
    /// }
    /// </code>
    /// </example>
    /// </summary>
    /// <returns>Calculated area</returns>
    public abstract double GetShapeArea();
    protected void ThrowLessThanZero(double value) => throw new ValueLessThanZeroException(value);
    protected void ThrowWrongShapeProperties() => throw new ShapePropertiesException();
}