namespace Abstract.Factory.Material;

internal class MaterialWidgetFactory : IWidgetFactory
{
    public IButton CreateButton()
    {
        return new MaterialButton();
    }

    public ITextBox CreateTextBox()
    {
        return new MaterialTextBox();
    }
}
