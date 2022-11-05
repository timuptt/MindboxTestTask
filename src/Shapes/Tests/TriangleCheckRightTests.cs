using Shapes.Extensions;
using Shapes.Models;

namespace Tests;

public class TriangleCheckRightTests
{
    [Fact]
    public void CheckRightTriangle_Success()
    {
        //Arrange
        var triangle = new Triangle(3, 4, 5);
        
        //Act
        var result = triangle.CheckRight();
        
        //Assert
        Assert.True(result);
    }
    
    [Fact]
    public void CheckRightTriangleWithLargeFloat_Success()
    {
        //Arrange
        var triangle = new Triangle(4.33, 3.1080540536, 5.33);
        
        //Act
        var result = triangle.CheckRight(0.0000001);
        
        //Assert
        Assert.True(result);
    }
}