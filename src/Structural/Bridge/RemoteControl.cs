namespace Bridge;

public class RemoteControl(IDevice device)
{
    protected readonly IDevice Device = device;

    public void TurnOn()
    {
        Device.TurnOn();
    }

    public void TurnOff()
    {
        Device.TurnOff();
    }
}
