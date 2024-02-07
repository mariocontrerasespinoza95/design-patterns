namespace DesignPatterns.Behavioral.State;

public class Canvas
{
    public ITool CurrentTool { get; set; }

    public void MouseUp() => CurrentTool.MouseUp();

    public void MouseDown() => CurrentTool.MouseDown();
}
