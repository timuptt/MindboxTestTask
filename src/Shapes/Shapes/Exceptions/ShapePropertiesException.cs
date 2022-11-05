namespace Shapes.Exceptions;

/// <summary>
/// Represents error when passed values do not satisfy shape properties
/// </summary>
public class ShapePropertiesException : Exception
{
    public ShapePropertiesException(double value, int index) 
        : base($"Passed value {value} at index [{index}] does not satisfy shape properties") { }
    
    public ShapePropertiesException() 
        : base($"Passed values does not satisfy shape properties") { }
}