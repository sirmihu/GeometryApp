using GeometryApp.Exceptions;
using GeometryApp.Models;
using GeometryApp.Utiles;
using Xunit;

namespace GeometryApp.Tests
{
    public class CircleTests
    {
        private readonly string _circleName;
        public CircleTests()
        {
            _circleName = "My Circle";
        }

        [Fact]
        public void GetName_ShouldReturnCircle()
        {
            // Arrange
            var circle = new Circle(5, 2, _circleName);

            // Act
            var name = circle.GetName();

            // Assert
            Assert.Equal("Circle", name);
        }

        [Fact]
        public void CalculateArea_ShouldCalculateAndRoundAreaCorrectly()
        {
            // Arrange
            var circle = new Circle(4, 2, _circleName);

            // Act
            circle.Round(circle.Area, 2);

            // Assert
            Assert.Equal(Math.Round(Convert.ToDouble(MathConstans.Pi) * Math.Pow(4, 2), 2), circle.Area);
        }

        [Fact]
        public void Round_Should_Throw_CircleInvalidRoundPrecisionException_When_InvalidPrecision()
        {
            // Arrange
            var circle = new Circle(5, 2, _circleName);

            // Act & Assert
            Assert.Throws<CircleInvalidRoundPrecisionException>(() => circle.Round(circle.Area, 4));
        }

    }
}
