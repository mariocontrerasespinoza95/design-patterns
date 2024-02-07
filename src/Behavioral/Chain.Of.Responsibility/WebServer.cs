namespace Chain.Of.Responsibility;

public class WebServer(Handler handler)
{
    public void Handle(HttpRequest request)
    {
        handler.Handle(request);
    }
}
