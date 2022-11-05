using Shapes;
using Shapes.Exceptions;
using Shapes.Models;

namespace Tests;

public class TriangleTests
{
    [Fact]
    public void TestCreateTriangleWithCorrectValues_Success()
    {
        //Arrange
        var a = 3d;
        var b = 4d;
        var c = 5d;
        
        //Act
        var triangle = new Triangle(a, b, c);
        
        //Assert
        Assert.Equal(a, triangle.A);
        Assert.Equal(b, triangle.B);
        Assert.Equal(c, triangle.C);
    }
    [Fact]
    public void TestCreateEquilateralTriangle_Success()
    {
        //Arrange
        var a = 3d;
        var b = 3d;
        var c = 3d;
        
        //Act
        var triangle = new Triangle(a, b, c);
        
        //Assert
        Assert.Equal(a, triangle.A);
        Assert.Equal(b, triangle.B);
        Assert.Equal(c, triangle.C);
    }

    [Fact]
    public void TestCreateTriangleWithNegativeValue_ThrowsException()
    {
        //Arrange
        var a = 3d;
        var b = 4d;
        var c = -1d;

        var exception = new Exception();
        
        //Act
        try
        {
            var triangle = new Triangle(a, b, c);
        }
        catch (Exception e)
        {
            exception = e;
        }
        
        //Assert
        Assert.IsType<ValueLessThanZeroException>(exception);
    }

    [Fact]
    public void TestCreateTriangleWithValuesDoesNotSatisfyProperties_ThrowException()
    {
        //Arrange
        var a = 1d;
        var b = 1d;
        var c = 3d;

        var exception = new Exception();
        
        //Act
        try
        {
            var triangle = new Triangle(a, b, c);
        }
        catch (Exception e)
        {
            exception = e;
        }
        
        //Assert
        Assert.IsType<ShapePropertiesException>(exception);
    }
    
    [Fact]
    public void TestGetAreaByApiCall_Success()
    {
        //Arrange
        var a = 3d;
        var b = 4d;
        var c = 5d;

        var area = 6;
        
        //Act
        var triangle = new Triangle(a, b, c);
        var testedArea = triangle.GetArea();
        
        //Assert
        Assert.Equal(area, testedArea);
    }
    
    [Fact]
    public void TestGetAreaByMethodCall_Success()
    {
        //Arrange
        var a = 3d;
        var b = 4d;
        var c = 5d;

        var area = 6;
        
        //Act
        var triangle = new Triangle(a, b, c);
        var testedArea = triangle.GetShapeArea();
        
        //Assert
        Assert.Equal(area, testedArea);
    }
}