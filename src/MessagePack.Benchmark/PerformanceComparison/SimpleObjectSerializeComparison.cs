using BenchmarkDotNet.Attributes;
using Newtonsoft.Json;
using System;

namespace MessagePack.Benchmark.PerformanceComparison
{
    [CoreJob]
    [RPlotExporter, RankColumn]
    public class SimpleObjectSerializeComparison
    {
        [Params(1000, 10000)]
        public int N;

        private Person person;

        [Benchmark]
        public string AsJson() => JsonConvert.SerializeObject(person);

        [Benchmark]
        public byte[] AsMessagePack() => MessagePackSerializer.Serialize(person, DefaultResolver.Instance);

        [GlobalSetup]
        public void Setup()
        {
            person = new Person()
            {
                Age = 30,
                Name = "Caskia",
                Sex = Sex.Men,
                CreationTime = DateTime.Now
            };
        }
    }
}