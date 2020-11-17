using BenchmarkDotNet.Attributes;
using System;

namespace Engine.PerformanceBenchmarks.SumCalc
{
    public partial class Calculation
    {
        /// <summary>
        ///  Span of T optimisation using slice abreviation available from C# 8.0.
        /// </summary>
        /// <returns></returns>
        [Benchmark]
        public int PartialArraySumV4()
        {
            var arraySpan = intArray.AsSpan();
            int result = 0;
            var arraySmall = arraySpan[1..intArray.Length];
            for (int x = 0; x < arraySmall.Length; x++)
            {
                result += arraySmall[x];
            }

            return result;
        }
    }
}
