```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 10 (10.0.19045.3516/22H2/2022Update)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.402
  [Host]     : .NET 6.0.23 (6.0.2323.48002), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.23 (6.0.2323.48002), X64 RyuJIT AVX2


```
| Method          | N     | Mean         | Error      | StdDev      |
|---------------- |------ |-------------:|-----------:|------------:|
| **UsingStructures** | **1000**  |     **4.661 ns** |  **0.1568 ns** |   **0.3058 ns** |
| UsingException  | 1000  | 4,640.252 ns | 92.7562 ns | 152.4011 ns |
| **UsingStructures** | **10000** |     **4.595 ns** |  **0.1433 ns** |   **0.1340 ns** |
| UsingException  | 10000 | 4,662.179 ns | 92.8599 ns | 147.2857 ns |
