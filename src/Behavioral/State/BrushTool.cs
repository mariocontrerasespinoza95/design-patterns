namespace DesignPatterns.Behavioral.State;

public class BrushTool : ITool
{
    public void MouseDown() => Console.WriteLine("Brush icon");

    public void MouseUp() => Console.WriteLine("Draw a line");
}
