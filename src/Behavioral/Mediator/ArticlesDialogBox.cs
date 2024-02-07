namespace Mediator;

public class ArticlesDialogBox
{
    private readonly ListBox _articlesListBox = new();
    private readonly TextBox _titleTextBox = new();
    private readonly Button _saveButton = new();

    public ArticlesDialogBox()
    {
        _articlesListBox.Attach(ArticleSelected);
        _titleTextBox.Attach(TitleChanged);
    }

    public void SimulateUserInteraction()
    {
        _articlesListBox.Selection = "Article 1";
        _titleTextBox.Content = string.Empty;
        _titleTextBox.Content = "Article 2";
        Console.WriteLine("TextBox: " + _titleTextBox.Content);
        Console.WriteLine("Button: " + _saveButton.IsEnabled);
    }

    private void ArticleSelected()
    {
        _titleTextBox.Content = _articlesListBox.Selection;
        _saveButton.IsEnabled = true;
    }

    private void TitleChanged()
    {
        string? content = _titleTextBox.Content;
        bool isEmpty = string.IsNullOrEmpty(content);
        _saveButton.IsEnabled = !isEmpty;
    }
}
