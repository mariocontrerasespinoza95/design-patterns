namespace Bridge;

public class AdvancedRemoteControl(IDevice device) : RemoteControl(device)
{
    public void SetChannel(int number)
    {
        Device.SetChannel(number);
    }
}
