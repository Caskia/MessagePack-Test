using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MessagePack.Benchmark.PerformanceComparison
{
    public class ComplexObjectSerializeSizeComparison
    {
        private readonly Room room;

        public ComplexObjectSerializeSizeComparison()
        {
            room = new Room()
            {
                Name = "Test"
            };

            for (int i = 0; i < 1000; i++)
            {
                room.Persons.Add(new Person()
                {
                    Age = 30,
                    Name = "Caskia",
                    Sex = Sex.Men,
                    CreationTime = DateTime.Now
                });
            }
        }

        public void CompareSize()
        {
            var json = JsonConvert.SerializeObject(room);

            var messagePack = MessagePackSerializer.Serialize(room, DefaultResolver.Instance);

            Console.WriteLine($"json: [{Encoding.Default.GetBytes(json).Length}]");
            Console.WriteLine($"messagepack: [{messagePack.Length}]");
        }
    }
}