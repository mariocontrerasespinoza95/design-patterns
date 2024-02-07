namespace Proxy;

public class LoggingEbookProxy(string fileName) : IEbook
{
    public string FileName => fileName;
    private RealEbook? _ebook;

    public void Show()
    {
        _ebook ??= new RealEbook(fileName);

        Console.WriteLine("Logging");
        _ebook.Show();
    }
}
