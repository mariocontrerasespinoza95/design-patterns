namespace Facade;

public class NotificationServer
{

    public AuthToken Authenticate(string appId, string key)
    {
        return new AuthToken();
    }

    public Connection Connect(string ipAddress)
    {
        return new Connection();
    }

    public void Send(AuthToken authToken, Message message, string target)
    {
        Console.WriteLine("Sending a message");
    }
}
