using BenchmarkDotNet.Running;
using MessagePack.Benchmark.PerformanceComparison;
using System;

namespace MessagePack.Benchmark
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<SimpleObjectDeserializeComparison>();

			// var comparison = new ComplexObjectSerializeSizeComparison();
			// comparison.CompareSize();

			//var serializeTest = new SimpleObjectSerialize();
			//serializeTest.DoSerialize();
            Console.ReadKey();
        }
    }
}