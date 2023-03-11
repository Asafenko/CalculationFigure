using CalculationFigure;

namespace Figure.Tests;

public class FigureCreatingTest
{
    [Fact]
    public void All_figure_is_inherited_IFigure()
    {
        // Arrange
        var triangle = new Triangle(3, 4, 5);
        var circle = new Circle(5);
        var square = new Square(4);
        // Act and Arrange
        triangle.Should().BeAssignableTo<IFigure>();
        circle.Should().BeAssignableTo<IFigure>();
        square.Should().BeAssignableTo<IFigure>();
    }

    [Fact]
    public void Circle_created()
    {
        // Arreange
        const int radius = 5;
        //ACT
        var circle = new Circle(5);
        // Assert
        circle.Radius.Should().Be(radius);
    }
    
    
    [Fact]
    public void Circle_with_negative_size_creating_is_impossible()
    {
        var func = () => new Circle(-5);
        func.Should().Throw<ArgumentOutOfRangeException>();
    }
    
    [Fact]
    public void Triangle_created()
    {
        // Arrange
        const int a = 3;
        const int b = 4;
        const int c = 6;
        
        // ACT
        var triangle = new Triangle(a, b, c);
        
        // Assert
        triangle.A.Should().Be(a);
        triangle.B.Should().Be(b);
        triangle.C.Should().Be(c);
    }
    
    [Fact]
    
    public void Incorrect_triangle_creating_is_impossible()
    {
        // ACT
       var func =() => new Triangle(10, 4, 3);
       func.Should().Throw<Exception>();
    }
    
    [Fact]
    
    public void Triangle_with_negative_size_creating_is_impossible()
    {
        // ACT
        var func =() => new Triangle(-1, 2, 2);
        func.Should().Throw<ArgumentOutOfRangeException>();
    }

    [Fact]
    public void Triangle_with_NaN_size_is_impossible()
    {
        // ACT
        var func = () => new Triangle(double.NaN, 2,4);
        func.Should().Throw<ArithmeticException>();
    }
    
    [Theory]
    [InlineData(3,4,5,true)]
    [InlineData(2,2,3,true)]
    [InlineData(3,4,1,false)]
    [InlineData(-3,-4,-5,false)]
    [InlineData(double.NaN,3,4,false)]
    public void Triangle_checking(double a,double b, double c,bool excepted)
    {
        Triangle.IsTriangle(a, b, c).Should().Be(excepted);
    }

    [Fact]
    public void Square_Created()
    {
        // Arrenge
        const int side = 5;
        
        //ACT
        var square = new Square(side);
        
        // Assert
        square.Side.Should().Be(side);
    }
    [Fact]
    public void Square_with_negative_size_creating_is_impossible()
    {
        var func = () => new Square(0);
        func.Should().Throw<ArgumentOutOfRangeException>();
    }
}