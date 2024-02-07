namespace Abstract.Factory.Ant;

internal class AntTextBox : ITextBox
{
    public void Render()
    {
        Console.WriteLine("Ant TextBox");
    }
}
