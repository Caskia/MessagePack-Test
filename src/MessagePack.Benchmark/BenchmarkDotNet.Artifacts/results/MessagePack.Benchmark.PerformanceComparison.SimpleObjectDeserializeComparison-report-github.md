``` ini

BenchmarkDotNet=v0.11.1, OS=Windows 10.0.17134.228 (1803/April2018Update/Redstone4)
Intel Core i7-4790 CPU 3.60GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=2.1.400
  [Host] : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT
  Core   : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT

Job=Core  Runtime=Core  

```
|                  Method |     N |       Mean |     Error |     StdDev | Rank |
|------------------------ |------ |-----------:|----------:|-----------:|-----:|
|            **JsonToPerson** |  **1000** | **2,637.3 ns** | **48.554 ns** |  **45.417 ns** |    **3** |
| MessagePackByteToPerson |  1000 |   267.7 ns |  2.928 ns |   2.596 ns |    1 |
|            **JsonToPerson** | **10000** | **2,723.7 ns** | **54.306 ns** | **103.323 ns** |    **4** |
| MessagePackByteToPerson | 10000 |   273.9 ns |  2.900 ns |   2.713 ns |    2 |
