using MessagePack.Formatters;
using System.Collections.Generic;

namespace MessagePack.Benchmark.PerformanceComparison
{
    public class DefaultResolver : IFormatterResolver
    {
        public static readonly IFormatterResolver Instance = new DefaultResolver();

        public static readonly IList<IFormatterResolver> Resolvers = new[]
        {
                MessagePack.Resolvers.DynamicEnumAsStringResolver.Instance,
                MessagePack.Resolvers.ContractlessStandardResolver.Instance
        };

        public IMessagePackFormatter<T> GetFormatter<T>()
        {
            return Cache<T>.Formatter;
        }

        private static class Cache<T>
        {
            public static readonly IMessagePackFormatter<T> Formatter;

            static Cache()
            {
                var t = typeof(T);

                foreach (var resolver in Resolvers)
                {
                    var f = resolver.GetFormatter<T>();
                    if (f != null)
                    {
                        Formatter = f;
                        return;
                    }
                }
            }
        }
    }
}