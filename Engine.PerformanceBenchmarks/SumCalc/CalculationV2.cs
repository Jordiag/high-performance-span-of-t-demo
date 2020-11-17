using BenchmarkDotNet.Attributes;

namespace Engine.PerformanceBenchmarks.SumCalc
{
    public partial class Calculation
    {
        /// <summary>
        /// Optimising without using linq.
        /// </summary>
        /// <returns></returns>
        [Benchmark]
        public int PartialArraySumV2()
        {
            int result = 0;
            var arraySmall = intArray[1..intArray.Length];
            for (int x = 0; x < arraySmall.Length; x++)
            {
                result += arraySmall[x];
            }

            return result;
        }
    }
}
