using Command.CommandFramework;

namespace Command;

public class ResizeCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Resize");
    }
}
