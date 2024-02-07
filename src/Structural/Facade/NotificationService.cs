namespace Facade;

public class NotificationService
{
    public void Send(string message, string target)
    {
        var server = new NotificationServer();
        Connection connection = server.Connect(ipAddress: "ip");
        AuthToken authToken = server.Authenticate(appId: "appId", key: "key");
        server.Send(authToken, new Message(message), target);
        connection.Disconnect();
    }
}
