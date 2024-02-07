namespace Chain.Of.Responsibility;

public class Authenticator(Handler next) : Handler(next)
{
    protected override bool DoHandle(HttpRequest request)
    {
        bool isValid = request is { UserName: "admin", Password: "1234" };

        Console.WriteLine("Authentication");

        return !isValid;
    }
}
