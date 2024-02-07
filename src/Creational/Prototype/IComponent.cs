namespace Prototype;

public interface IComponent
{
    void Render();
    IComponent Clone();
}
