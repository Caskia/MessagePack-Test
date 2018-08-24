using System;

namespace MessagePack.Benchmark.PerformanceComparison
{
    public enum Sex
    {
        Men = 1,
        Women
    }

    public class Person
    {
        public int Age { get; set; }

        public DateTime CreationTime { get; set; }

        public string Name { get; set; }

        public Sex Sex { get; set; }
    }
}