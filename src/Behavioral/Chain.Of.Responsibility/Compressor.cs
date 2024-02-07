namespace Chain.Of.Responsibility;

public class Compressor(Handler? next) : Handler(next)
{
    protected override bool DoHandle(HttpRequest request)
    {
        Console.WriteLine("Compress");
        return false;
    }
}
