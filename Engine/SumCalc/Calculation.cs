using System;

namespace Engine.SumCalc
{
    /// <summary>
    /// This is the fastest chosen method version after compare them using PerformanceBenchmarks project.
    /// </summary>
    public class Calculation
    {
        private readonly int[] intArray = new int[] { 1, 2, 3, 4, 5 };

        public int PartialArraySum()
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
