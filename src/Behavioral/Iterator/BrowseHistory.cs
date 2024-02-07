namespace Iterator;

public class BrowseHistory
{
    private readonly string[] _urls = new string[10];
    private int _count;

    public void Push(string url) => _urls[_count++] = url;
    public string Pop() => _urls[--_count];
    public IIterator<string> CreateIterator() => new ArrayIterator(this);

    private class ArrayIterator(BrowseHistory browseHistory) : IIterator<string>
    {
        private int _index;

        public string Current() => browseHistory._urls[_index];
        public bool HasNext() => _index < browseHistory._urls.Length;
        public void Next() => _index++;
    }
}
