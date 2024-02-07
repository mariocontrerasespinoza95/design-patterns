namespace Chain.Of.Responsibility;

public class HttpRequest(string userName, string password)
{
    public string UserName { get; } = userName;
    public string Password { get; } = password;
}
