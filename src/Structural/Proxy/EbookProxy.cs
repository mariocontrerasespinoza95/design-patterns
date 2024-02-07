namespace Proxy;

public class EbookProxy(string fileName) : IEbook
{
    private RealEbook? _ebook;
    public string FileName => fileName;

    public void Show()
    {
        _ebook ??= new RealEbook(fileName);

        _ebook.Show();
    }
}
