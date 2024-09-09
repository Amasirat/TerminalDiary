namespace TerminalDiary;
// Used for displaying UI on console or Terminal
public abstract class Menu
{
    // Used for dictating what selections a particular child of Menu should contain in a polymorphic fashion
    public abstract void PopulateSelection();
    // Used to display selections on console
    public virtual void DisplaySelections()
    {
        if (selections == null)
        {
            Console.WriteLine("No options");
        }
        foreach (KeyValuePair<int, string> selection in selections)
        {
            Console.WriteLine($"{selection.Key}.{selection.Value}");
        }

        HandleUserInput(int.Parse(Console.ReadLine()));
    }
    // Used to handle user selection and do appropriate action given input
    public abstract void HandleUserInput(int input);
    // Scalable way of holding possible selections in the console UI
    protected Dictionary<int, string>? selections;
}