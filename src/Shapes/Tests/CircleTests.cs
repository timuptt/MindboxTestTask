using Shapes;
using Shapes.Exceptions;
using Shapes.Models;

namespace Tests;

public class CircleTests
{
    [Fact]
    public void TestCreateCircleWithCorrectValues_Success()
    {
        //Arrange
        var radius = 3d;
        
        //Act
        var circle = new Circle(radius);
        
        //Assert
        Assert.Equal(circle.Radius, radius);
    }

    [Fact]
    public void TestCreateCircleWithIncorrectValue_ThrowsException()
    {
        //Arrange
        var radius = -1d;
        Exception exception = new Exception();
        
        //Act
        try
        {
            var circle = new Circle(radius);
        }
        catch (Exception ex)
        {
            exception = ex;
        }
        
        //Assert
        Assert.IsType<ValueLessThanZeroException>(exception);
    }

    [Fact]
    public void TestGetCircleAreaByLibraryApi_Success()
    {
        //Arrange
        var radius = 3;
        var circle = new Circle(3);
        
        //Act
        var area = circle.GetArea();
        
        //Assert
        Assert.Equal(radius*radius*Math.PI, area);
    }
    
    [Fact]
    public void TestGetCircleAreaByOwnMethod_Success()
    {
        //Arrange
        var radius = 3;
        var circle = new Circle(3);
        
        //Act
        var area = circle.GetShapeArea();
        
        //Assert
        Assert.Equal(radius*radius*Math.PI, area);
    }
}