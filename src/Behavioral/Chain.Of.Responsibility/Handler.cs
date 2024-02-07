namespace Chain.Of.Responsibility;

public abstract class Handler(Handler? next)
{
    public void Handle(HttpRequest request)
    {
        if (DoHandle(request))
        {
            return;
        }

        next?.Handle(request);
    }

    protected abstract bool DoHandle(HttpRequest request);
}
