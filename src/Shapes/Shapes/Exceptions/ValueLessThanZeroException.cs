namespace Shapes.Exceptions;

/// <summary>
/// Represents error when passed value is less than 0
/// </summary>
public class ValueLessThanZeroException : Exception
{
    public ValueLessThanZeroException(double value) 
        : base($"Side value [{value}] must be more than 0]") { }
}