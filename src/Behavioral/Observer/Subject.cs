namespace Observer;

public class Subject<T>
{
    private readonly List<IObserver<T>> _observers = [];

    public void AddObserver(IObserver<T> observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver<T> observer)
    {
        _observers.Remove(observer);
    }

    protected void NotifyObservers()
    {
        _observers.ForEach(observer =>
        {
            observer.Update();
        });
    }
}
