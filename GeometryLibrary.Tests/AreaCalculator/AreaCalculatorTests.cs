using GeometryLibrary.Figures;

namespace GeometryLibrary.Tests.AreaCalculator
{
    public class AreaCalculatorTests
    {
        [Fact]
        public void CalculateArea_CalculatesCorrectAreaForCircle()
        {
            // Arrange
            var radius = 5d;
            var circle = new Circle(radius);
            var expectedArea = Math.Round(Math.PI * radius * radius, 2);

            // Act
            double calculatedArea = GeometryLibrary.AreaCalculator.CalculateArea(circle);

            // Assert
            Assert.Equal(expectedArea, calculatedArea);
        }

        [Fact]
        public void CalculateArea_CalculatesCorrectAreaForTriangle()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;

            Triangle triangle = new Triangle(sideA, sideB, sideC);
            double semiPerimeter = (sideA + sideB + sideC) / 2;
            double expectedArea = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));

            // Act
            double calculatedArea = GeometryLibrary.AreaCalculator.CalculateArea(triangle);

            // Assert
            Assert.Equal(expectedArea, calculatedArea);
        }
    }
}