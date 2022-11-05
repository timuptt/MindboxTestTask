using Shapes.Models;

namespace Shapes.Extensions;

public static class CheckRightTriangleExtension
{
    /// <summary>
    /// Tests a <see cref="Triangle"/> for a right triangle
    /// </summary>
    /// <param name="triangle">Triangle to test</param>
    /// <param name="accuracy">Accuracy to test triangle is right in percents (default value is 1 * 10^-24%)</param>
    /// <returns>True if triangle is right</returns>
    /// <exception cref="ArgumentOutOfRangeException">Throws when accuracy is less than 0 or more than 1</exception>
    /// <remarks>You can use accuracy when you check triangle with floating point sides value</remarks>
    public static bool CheckRight(this Triangle triangle, double accuracy = 0.0000000000000000000000001)
    {
        if (accuracy is < 0 or > 1) throw new ArgumentOutOfRangeException(nameof(accuracy));
        
        var tolerance = accuracy / 100;

        var isRight = Math.Abs(triangle.A * triangle.A + triangle.B * triangle.B - triangle.C * triangle.C) < tolerance ||
                      Math.Abs(triangle.A * triangle.A + triangle.C * triangle.C - triangle.B * triangle.B) < tolerance ||
                      Math.Abs(triangle.B * triangle.B + triangle.C * triangle.C - triangle.A * triangle.A) < tolerance;

        return isRight;
    }
}