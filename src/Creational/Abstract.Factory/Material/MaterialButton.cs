namespace Abstract.Factory.Material;

internal class MaterialButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Material Button");
    }
}
