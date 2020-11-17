using Engine.SumCalc;
using Xunit;

namespace Engine.Tests
{
    public class CalculationTest
    {
        [Fact]
        public void CalculationPartialArraySumTest()
        {
            // Arrange
            var sut = new Calculation();

            // Act
            var result = sut.PartialArraySum();

            // Assert
            Assert.Equal(14, result);
        }
    }
}
