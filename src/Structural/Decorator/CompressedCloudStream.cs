namespace Decorator;

public class CompressedCloudStream(IStream stream) : IStream
{
    public void Write(string data)
    {
        string compressed = Compress(data);
        stream.Write(compressed);
    }

    private static string Compress(string data)
    {
        return data[..^5];
    }
}
