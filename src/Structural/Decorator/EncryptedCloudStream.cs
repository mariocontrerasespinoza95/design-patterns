namespace Decorator;

public class EncryptedCloudStream(IStream stream) : CloudStream
{
    public override void Write(string data)
    {
        string encryptedData = Encrypt(data);
        stream.Write(encryptedData);
    }

    private static string Encrypt(string data)
    {
        return "12045o1203o120412#!@!@!#!@";
    }
}
