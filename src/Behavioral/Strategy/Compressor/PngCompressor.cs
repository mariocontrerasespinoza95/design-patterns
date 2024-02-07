namespace Strategy.Compressor;

public class PngCompressor : ICompressor
{
    public void Compress(string fileName) => Console.WriteLine("Compressing using PNG");
}
