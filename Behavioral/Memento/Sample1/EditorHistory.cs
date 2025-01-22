namespace Behavioral.Memento.Sample1;

public class EditorHistory
{
    public Stack<TextState> History { get; set; }

    public EditorHistory() => History = new Stack<TextState>();

    public void SaveHistory(TextState state) => History.Push(state);
    public TextState Undo() => History.Pop();
}





