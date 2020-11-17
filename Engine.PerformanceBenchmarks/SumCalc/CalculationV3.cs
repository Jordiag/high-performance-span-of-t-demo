using BenchmarkDotNet.Attributes;
using System;

namespace Engine.PerformanceBenchmarks.SumCalc
{
    public partial class Calculation
    {
        /// <summary>
        /// Base Span of T optimisation.
        /// </summary>
        /// <returns></returns>
        [Benchmark]
        public int PartialArraySumV3()
        {
            Span<int> arraySpan = intArray;
            int result = 0;
            var arraySmall = arraySpan.Slice(1, intArray.Length - 1);
            for (int x = 0; x < arraySmall.Length; x++)
            {
                result += arraySmall[x];
            }

            return result;
        }
    }
}
