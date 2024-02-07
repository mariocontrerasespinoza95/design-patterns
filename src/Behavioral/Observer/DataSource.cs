namespace Observer;

public class DataSource<T> : Subject<T>
{
    private T _value;

    public T Value
    {
        get => _value;
        set
        {
            _value = value;
            NotifyObservers();
        }
    }
}
