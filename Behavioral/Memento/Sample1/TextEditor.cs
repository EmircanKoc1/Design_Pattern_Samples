namespace Behavioral.Memento.Sample1;

public class TextEditor
{
    public string? CurrentText { get; set; }

    public TextState SaveState()
    {
        return new TextState(CurrentText);
    }

    public void RestoreState(TextState textState)
    {
        CurrentText = textState.TextContent;
    }

}





