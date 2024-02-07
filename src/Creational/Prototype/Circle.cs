namespace Prototype;

internal class Circle : IComponent
{
    private int Radius { get; init; }

    public IComponent Clone() =>
        new Circle
        {
            Radius = Radius
        };

    public void Render() => Console.WriteLine("Rendering a circle");
}
