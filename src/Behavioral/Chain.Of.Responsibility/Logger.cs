namespace Chain.Of.Responsibility;

public class Logger(Handler? next) : Handler(next)
{
    protected override bool DoHandle(HttpRequest request)
    {
        Console.WriteLine("Log");

        return false;
    }
}
