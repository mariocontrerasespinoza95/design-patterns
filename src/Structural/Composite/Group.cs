namespace Composite;

public class Group : IComponent
{
    private readonly List<IComponent> _components = [];

    public void Add(IComponent component) { _components.Add(component); }

    public void Move()
    {
        _components.ForEach(component => component.Move());
    }

    public void Render()
    {
        _components.ForEach(component => component.Render());
    }
}
