namespace Flyweight;

public class Point(int x, int y, PointIcon icon)
{
    public int X { get; init; } = x;
    public int Y { get; init; } = y;

    public void Draw()
    {
        Console.WriteLine("{0} at ({1}, {2})", icon.Type, X, Y);
    } 
}
