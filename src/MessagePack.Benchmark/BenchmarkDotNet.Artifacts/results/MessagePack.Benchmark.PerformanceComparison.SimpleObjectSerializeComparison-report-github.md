``` ini

BenchmarkDotNet=v0.11.1, OS=Windows 10.0.17134.228 (1803/April2018Update/Redstone4)
Intel Core i7-4790 CPU 3.60GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=2.1.400
  [Host] : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT
  Core   : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT


```
|        Method |    Job | Runtime |     N |       Mean |     Error |    StdDev | Rank |
|-------------- |------- |-------- |------ |-----------:|----------:|----------:|-----:|
|        **AsJson** |   **Core** |    **Core** |  **1000** | **1,236.7 ns** | **26.856 ns** | **41.012 ns** |    **3** |
| AsMessagePack |   Core |    Core |  1000 |   308.0 ns |  6.158 ns | 14.271 ns |    2 |
|        AsJson | CoreRT |  CoreRT |  1000 |         NA |        NA |        NA |    ? |
| AsMessagePack | CoreRT |  CoreRT |  1000 |         NA |        NA |        NA |    ? |
|        **AsJson** |   **Core** |    **Core** | **10000** | **1,242.2 ns** | **20.243 ns** | **18.935 ns** |    **3** |
| AsMessagePack |   Core |    Core | 10000 |   297.9 ns |  5.613 ns |  5.764 ns |    1 |
|        AsJson | CoreRT |  CoreRT | 10000 |         NA |        NA |        NA |    ? |
| AsMessagePack | CoreRT |  CoreRT | 10000 |         NA |        NA |        NA |    ? |

Benchmarks with issues:
  SimpleObjectSerializeComparison.AsJson: CoreRT(Runtime=CoreRT) [N=1000]
  SimpleObjectSerializeComparison.AsMessagePack: CoreRT(Runtime=CoreRT) [N=1000]
  SimpleObjectSerializeComparison.AsJson: CoreRT(Runtime=CoreRT) [N=10000]
  SimpleObjectSerializeComparison.AsMessagePack: CoreRT(Runtime=CoreRT) [N=10000]
