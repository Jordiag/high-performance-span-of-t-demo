using BenchmarkDotNet.Running;
using Engine.PerformanceBenchmarks.SumCalc;

namespace Engine.PerformanceBenchmarks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Calculation>();
        }
    }
}
