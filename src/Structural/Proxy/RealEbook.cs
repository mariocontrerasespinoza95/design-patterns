namespace Proxy;

public class RealEbook : IEbook
{
    public string FileName { get; }

    public RealEbook(string fileName)
    {
        FileName = fileName;
        Load();
    }

    private void Load()
    {
        Console.WriteLine("Loading the ebook " + FileName);
    }

    public void Show()
    {
        Console.WriteLine("Showing the ebook " + FileName);
    }
}
