namespace TerminalDiary;
// Used for displaying UI on console or Terminal
public abstract class Menu
{
    // Used for dictating what selections a particular child of selection should contain
    public abstract void PopulateSelection(Dictionary<int, string> select);
    // Used to display selections on console
    public virtual void DisplaySelections()
    {
        foreach (KeyValuePair<int, string> selection in selections)
        {
            Console.WriteLine($"{selection.Key}.{selection.Value}");
        }
    }
    // Used to handle user selection and do appropriate action given choice
    public abstract void ChoiceHandler(int choice);

    protected Dictionary<int, string>? selections;
}