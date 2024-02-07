namespace Observer;

public class Chart<T>(DataSource<T> dataSource) : IObserver<T>
{
    public void Update()
    {
        Console.WriteLine("Chart got updated: " + dataSource.Value);
    }
}
