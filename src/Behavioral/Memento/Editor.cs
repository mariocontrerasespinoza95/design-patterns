namespace Memento;

public class Editor
{
    public string? Content { get; set; }

    public EditorState CreateState() => new(Content);

    public void Restore(EditorState state) => Content = state.Content;
}
