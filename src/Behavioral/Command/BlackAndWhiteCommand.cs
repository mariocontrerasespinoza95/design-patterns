using Command.CommandFramework;

namespace Command;

public class BlackAndWhiteCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Black and white");
    }
}
