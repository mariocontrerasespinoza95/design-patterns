namespace Prototype;

internal class ContextMenu
{
    public void Duplicate(IComponent component)
    {
        IComponent newComponent = component.Clone();
    }
}
