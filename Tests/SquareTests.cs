using GeometryApp.Models;
using GeometryApp.Exceptions;
using Xunit;

namespace GeometryApp.Tests
{
    public class SquareTests
    {
        [Fact]
        public void GetName_ShouldReturnSquare()
        {
            // Arrange
            var square = new Square(2, 2, "My Square");

            // Act
            var name = square.GetName();

            // Assert
            Assert.Equal("Square", name);
        }

        /*[Fact]
        public void CalculateArea_ShouldSetArea()
        {
            // Arrange
            var square = new Square(2, 2, "My Square");

            // Act
            square.CalculateArea();

            // Assert
            Assert.Equal(4, square.Area);
        }*/

        [Fact]
        public void CalculateArea_ShouldCalculateAndRoundAreaCorrectly()
        {
            // Arrange
            var square = new Square(2, 2, "My Square");

            // Act
            square.Round(square.Area, 2);

            // Assert
            Assert.Equal(4, square.Area);
        }

        [Fact]
        public void Round_WithInvalidPrecision_ShouldThrowException()
        {
            // Arrange
            var square = new Square(2, 2, "My Square");

            // Act & Assert
            Assert.Throws<SquareInvalidRoundPrecisionException>(() => square.Round(square.Area, 5));
        }

    }
}
