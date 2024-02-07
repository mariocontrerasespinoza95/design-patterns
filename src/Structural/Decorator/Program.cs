/*
 * Decorator is a structural design pattern
 * that lets you attach new behaviors to objects
 * by placing these objects inside special wrapper objects that contain the behaviors.
 */

using Decorator;

StoreCreditCard(new EncryptedCloudStream(new CompressedCloudStream(new CloudStream())));
return;

static void StoreCreditCard(IStream stream)
{
    stream.Write("1234-1234-1234-1234");
}
