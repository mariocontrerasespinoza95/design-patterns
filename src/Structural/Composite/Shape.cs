namespace Composite;

public class Shape : IComponent
{
    public void Move()
    {
        Console.WriteLine("Move Shape");
    }

    public void Render()
    {
        Console.WriteLine("Render Shape");
    }
}
