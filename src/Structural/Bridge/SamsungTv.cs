namespace Bridge;

internal class SamsungTv : IDevice
{
    public void SetChannel(int number)
    {
        Console.WriteLine("Samsung: SetChannel");
    }

    public void TurnOff()
    {
        Console.WriteLine("Samsung: TurnOff");
    }

    public void TurnOn()
    {
        Console.WriteLine("Samsung: TurnOn");
    }
}
