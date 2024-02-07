namespace Proxy;

public class Library
{
    private readonly IDictionary<string, IEbook> _ebooks = new Dictionary<string, IEbook>();

    public void Add(IEbook ebook)
    {
        _ebooks[ebook.FileName] = ebook;
    }

    public void OpenEbook(string fileName)
    {
        IEbook ebook = _ebooks[fileName];
        ebook.Show();
    }
}
