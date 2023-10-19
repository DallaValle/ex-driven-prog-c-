namespace ex_driven_prog;
using BenchmarkDotNet.Running;

public class Program
{
    public static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<ResponseHandlerToBenchmark>();
    }
}