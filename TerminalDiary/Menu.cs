namespace TerminalDiary;

public abstract class Menu
{
    public abstract void PopulateSelection(Dictionary<int, string> select);
    public abstract void DisplaySelections();

    public abstract void ChoiceHandler(int choice);

    protected Dictionary<int, string>? selections;
}