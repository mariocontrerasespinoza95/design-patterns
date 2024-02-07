namespace Memento;

public class History
{
    private readonly List<EditorState> _states = [];

    public void Push(EditorState state)
    {
        _states.Add(state);
    }

    public EditorState Pop()
    {
        int lastIndex = _states.Count - 1;
        EditorState lastState = _states[lastIndex];
        _states.RemoveAt(lastIndex);

        return lastState;
    }
}
