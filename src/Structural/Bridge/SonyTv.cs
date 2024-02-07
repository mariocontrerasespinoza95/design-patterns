namespace Bridge;

public class SonyTv : IDevice
{
    public void SetChannel(int number)
    {
        Console.WriteLine("Sony: SetChannel");
    }

    public void TurnOff()
    {
        Console.WriteLine("Sony: TurnOff");
    }

    public void TurnOn()
    {
        Console.WriteLine("Sony: TurnOn");
    }
}
