```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 10 (10.0.19045.3516/22H2/2022Update)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.402
  [Host]     : .NET 6.0.23 (6.0.2323.48002), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.23 (6.0.2323.48002), X64 RyuJIT AVX2


```
| Method          | N     | Mean         | Error       | StdDev      |
|---------------- |------ |-------------:|------------:|------------:|
| **UsingStructures** | **1000**  |     **4.938 ns** |   **0.2749 ns** |   **0.7975 ns** |
| UsingException  | 1000  | 4,756.565 ns | 111.2751 ns | 322.8292 ns |
| **UsingStructures** | **10000** |     **4.956 ns** |   **0.2444 ns** |   **0.7090 ns** |
| UsingException  | 10000 | 4,684.291 ns | 103.1279 ns | 295.8934 ns |
