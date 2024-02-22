using GeometryLibrary.Figures;

namespace GeometryLibrary.Tests.Figures
{
    public class CircleTests
    {
        [Theory]
        [InlineData(5, true)] // Valid
        [InlineData(0, false)] // Invalid
        [InlineData(-1, false)] // Invalid
        public void Constructor_ValidatesCircle(double radius, bool expected)
        {
            // Arrange & Act
            Circle circle = null;
            Action createCircle = () => circle = new Circle(radius);

            // Assert
            if (expected)
            {
                createCircle();
                Assert.NotNull(circle);
                Assert.Equal(radius, circle.Radius);
            }
            else
            {
                Assert.Throws<ArgumentException>(createCircle);
                Assert.Null(circle);
            }
        }

        [Theory]
        [InlineData(5, true)] // Valid
        [InlineData(0, false)] // Invalid
        [InlineData(-1, false)] // Invalid
        public void IsValid_ValidatesCircle(double radius, bool expected)
        {
            // Arrange & Act
            Circle circle = null;

            Action createCircle = () => circle = new Circle(radius);

            // Assert
            if (expected)
            {
                createCircle();
                Assert.True(circle!.IsValid());
            }
            else
                Assert.Throws<ArgumentException>(createCircle);
        }

        [Theory]
        [InlineData(5, 78.54)] // Valid
        [InlineData(0, 0)] // Invalid
        [InlineData(-1, 0)] // Invalid
        public void CalculateArea_ReturnsCorrectArea(double radius, double expectedArea)
        {
            // Arrange
            Circle circle = null;
            if (expectedArea > 0)
                circle = new Circle(radius);

            // Act
            var calculatedArea = circle?.CalculateArea() ?? 0;

            // Assert
            Assert.Equal(expectedArea, calculatedArea);
        }
    }
}
