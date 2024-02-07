namespace Abstract.Factory;

internal interface IWidgetFactory
{
    IButton CreateButton();
    ITextBox CreateTextBox();
}
