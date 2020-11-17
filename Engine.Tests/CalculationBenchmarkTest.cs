using Xunit;

namespace Engine.Tests
{
    public class CalculationBenchmarkTest
    {
        [Fact]
        public void CalculationPartialArraySumTest()
        {
            // Arrange
            var sut = new Engine.PerformanceBenchmarks.SumCalc.Calculation();

            // Act
            var result1 = sut.PartialArraySumV1();
            var result2 = sut.PartialArraySumV2();
            var result3 = sut.PartialArraySumV3();
            var result4 = sut.PartialArraySumV4();

            // Assert
            Assert.Equal(14, result1);
            Assert.Equal(14, result2);
            Assert.Equal(14, result3);
            Assert.Equal(14, result4);
        }
    }
}
