using GeometryApp.Exceptions;
using GeometryApp.Models;
using Xunit;

namespace GeometryApp.Tests
{
    public class RectangleTests
    {
        [Fact]
        public void GetName_ShouldReturnRectangle()
        {
            // Arrange
            var rectangle = new Rectangle(5, 2, 2, "My Rectangle");

            // Act
            var name = rectangle.GetName();

            // Assert
            Assert.Equal("Rectangle", name);
        }

        [Fact]
        public void CalculateArea_ShouldCalculateAndRoundAreaCorrectly()
        {
            // Arrange
            var rectangle = new Rectangle(3, 4, 4, "My Rectangle");

            // Act
            rectangle.Round(rectangle.Area, 4);

            // Assert
            Assert.Equal(12, rectangle.Area);
        }

        [Fact]
        public void Round_WithInvalidPrecision_ShouldThrowException()
        {
            // Arrange
            var rectangle = new Rectangle(3, 4, 3, "My Rectangle");

            // Act & Assert
            Assert.Throws<RectangleInvalidRoundPrecisionException>(() => rectangle.Round(rectangle.Area, 5));
        }
    }
}
