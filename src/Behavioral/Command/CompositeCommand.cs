using Command.CommandFramework;

namespace Command;

internal class CompositeCommand : ICommand
{
    private readonly List<ICommand> _commands = [];

    public void Add(ICommand command) => _commands.Add(command);
    public void Execute() => _commands.ForEach(c => c.Execute());
}
