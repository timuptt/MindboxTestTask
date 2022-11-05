using Shapes.Models;

namespace Shapes;

public static class Shapes
{   
    /// <summary>
    /// Calculate area of the shape
    /// </summary>
    /// <param name="shape">Shape</param>
    /// <returns>Calculated area</returns>
    public static double GetArea(this BaseShape shape) => shape.GetShapeArea();
}