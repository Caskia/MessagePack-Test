using System.Collections.Generic;

namespace MessagePack.Benchmark.PerformanceComparison
{
    public class Room
    {
        public string Name { get; set; }

        public List<Person> Persons { get; set; } = new List<Person>();
    }
}