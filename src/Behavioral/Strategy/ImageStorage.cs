using Strategy.Compressor;
using Strategy.Filter;

namespace Strategy;

public class ImageStorage(ICompressor compressor, IFilter filter)
{
    public void Store(string fileName)
    {
        compressor.Compress(fileName);
        filter.Apply(fileName);
    }
}
