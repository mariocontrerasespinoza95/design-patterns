namespace Observer;

public class SpreadSheet<T>(DataSource<T> dataSource) : IObserver<T>
{
    public void Update()
    {
        Console.WriteLine("SpreadSheet got notified: " + dataSource.Value);
    }
}
