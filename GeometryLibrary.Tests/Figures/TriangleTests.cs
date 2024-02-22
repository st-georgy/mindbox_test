using GeometryLibrary.Figures;

namespace GeometryLibrary.Tests.Figures
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(3, 4, 5, true)] // Valid
        [InlineData(0, 0, 0, false)] // Invalid
        [InlineData(-1, 2, 3, false)] // Invalid
        [InlineData(1, 2, 10, false)] // Invalid
        public void Constructor_ValidateTriangle(double sideA, double sideB, double sideC, bool expected)
        {
            // Arrange & Act
            Triangle triangle = null;
            Action createTriangle = () => triangle = new Triangle(sideA, sideB, sideC);

            // Assert
            if (expected)
            {
                createTriangle();
                Assert.NotNull(triangle);
                Assert.Equal(sideA, triangle.SideA);
                Assert.Equal(sideB, triangle.SideB);
                Assert.Equal(sideC, triangle.SideC);
            }
            else
            {
                Assert.Throws<ArgumentException>(createTriangle);
                Assert.Null(triangle);
            }
        }

        [Theory]
        [InlineData(3, 4, 5, true)] // Valid
        [InlineData(0, 0, 0, false)] // Invalid
        [InlineData(-1, 2, 3, false)] // Invalid
        [InlineData(1, 1, 2, false)] // Invalid
        public void IsValid_ValidatesTriangle(double sideA, double sideB, double sideC, bool expected)
        {
            // Arrange & Act
            Triangle triangle = null;
            
            Action createTriangle = () => triangle = new Triangle(sideA, sideB, sideC);

            // Assert
            if (expected)
            {
                createTriangle();
                Assert.True(triangle!.IsValid());
            }
            else
                Assert.Throws<ArgumentException>(createTriangle);
        }

        [Theory]
        [InlineData(3, 4, 5, 6)] // Valid
        [InlineData(5, 12, 13, 30)] // Valid
        [InlineData(2, 3, 8, 0)] // Invalid
        [InlineData(0, 0, 0, 0)] // Invalid
        public void CalculateArea_ReturnsCorrectArea(double sideA, double sideB, double sideC, double expectedArea)
        {
            // Arrange
            Triangle triangle = null;
            if (expectedArea > 0)
                triangle = new Triangle(sideA, sideB, sideC);

            // Act
            var calculatedArea = triangle?.CalculateArea() ?? 0;

            // Assert
            Assert.Equal(expectedArea, calculatedArea);
        }

        [Theory]
        [InlineData(3, 4, 5, true)] // Valid right-angled triangle
        [InlineData(5, 12, 13, true)] // Valid right-angled triangle
        [InlineData(1, 1, 1, false)] // Not right-angled triangle
        [InlineData(3, 4, 6, false)] // Not right-angled triangle
        public void IsRightAngled_ReturnsCorrectResult(double sideA, double sideB, double sideC, bool expectedResult)
        {
            // Arrange
            var triangle = new Triangle(sideA, sideB, sideC);

            // Act
            var result = triangle.IsRightAngled();

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
