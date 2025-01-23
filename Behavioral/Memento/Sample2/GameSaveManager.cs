namespace Behavioral.Memento.Sample2;

public class GameSaveManager
{
    private Stack<CharacterState> _states;
    private Stack<CharacterState> _redoStates;


    public GameSaveManager()
    {
        _states = new();
        _redoStates = new();
    }

    public void Save(CharacterState characterState)
    {
        _states.Push(characterState);
        _redoStates.Clear();
    }


    public CharacterState? Undo()
    {
        if (_states.Count > 1)
        {
            var undoResult = _states.Pop();
            _redoStates.Push(undoResult);
            return _states.Peek();

        }
        else
            Console.WriteLine("The undo operation cannot be used because states have already been cleared");
        return null;

    }
    public CharacterState? Redo()
    {
        if (_redoStates.Count > 0)
        {
            var redoResult = _redoStates.Pop();
            _states.Push(redoResult);
            return redoResult;
        }
        else
            Console.WriteLine("The redo operation cannot be used because the redo states have been cleared");
        return null;
    }


}
