using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using System.Linq;

namespace Engine.PerformanceBenchmarks.SumCalc
{
    /// <summary>
    /// Base implementation using linq.
    /// </summary>
    [MemoryDiagnoser]
    public partial class Calculation
    {
        private readonly int[] intArray = new int[] { 1, 2, 3, 4, 5 };
        private static readonly Consumer Consumer = new Consumer();

        [Benchmark]
        public int PartialArraySumV1()
        {
            intArray.Consume(Consumer);
            var arraySum = intArray.Skip(1).Take(4).Sum(x => x);

            return arraySum;
        }
    }
}
