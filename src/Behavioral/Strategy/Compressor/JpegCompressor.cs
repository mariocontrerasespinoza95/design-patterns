namespace Strategy.Compressor;

public class JpegCompressor : ICompressor
{
    public void Compress(string fileName) => Console.WriteLine("Compressing using JPEG");
}
