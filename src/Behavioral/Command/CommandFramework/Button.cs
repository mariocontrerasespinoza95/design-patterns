namespace Command.CommandFramework;

public class Button(ICommand command)
{
    public string Label { get; set; }

    public void Click()
    {
        command.Execute();
    }
}
