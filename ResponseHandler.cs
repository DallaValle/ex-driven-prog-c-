namespace ex_driven_prog;
using BenchmarkDotNet.Attributes;

public class ResponseHandler
{
    private int input;

    [Params(1000, 10000)]
    public int N;

    [GlobalSetup]
    public void Setup()
    {
        input = (int)new Random(4).NextInt64();
    }

    [Benchmark]
    public Response UsingStructures() =>
        input switch
        {
            0 => new Response("bad request"),
            1 => new Response("not found"),
            _ => new Response("internal server error"),
        };

    [Benchmark]
    public Response UsingException()
    {
        try
        {
            Exception result = input switch
            {
                0 => throw new Exception(),
                1 => throw new BadRequestException(),
                _ => throw new ArgumentNullException(),
            };
            return new Response("not possible");
        }
        catch (BadRequestException e)
        {
            return new Response("bad request");
        }
        catch (ArgumentNullException e)
        {
            return new Response("bad request");
        }
        catch (Exception e)
        {
            return new Response("bad request");
        }
    }
}
