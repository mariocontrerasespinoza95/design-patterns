namespace Mediator;

public abstract class UIControl
{
    private readonly List<Action> _eventHandlers = [];

    public void Attach(Action handler) => _eventHandlers.Add(handler);
    protected void NotifyObservers() => _eventHandlers.ForEach(handler => handler());
}
