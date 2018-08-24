using BenchmarkDotNet.Attributes;
using Newtonsoft.Json;
using System;

namespace MessagePack.Benchmark.PerformanceComparison
{
    [CoreJob]
    [RPlotExporter, RankColumn]
    public class SimpleObjectDeserializeComparison
    {
        [Params(1000, 10000)]
        public int N;

        private Person person;

        private string personJson;

        private byte[] personMessagePack;

        [Benchmark]
        public Person JsonToPerson() => JsonConvert.DeserializeObject<Person>(personJson);

        [Benchmark]
        public Person MessagePackByteToPerson() => MessagePackSerializer.Deserialize<Person>(personMessagePack, DefaultResolver.Instance);

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

            personJson = JsonConvert.SerializeObject(person);

            personMessagePack = MessagePackSerializer.Serialize(person, DefaultResolver.Instance);
        }
    }
}