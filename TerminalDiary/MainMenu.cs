namespace TerminalDiary;

public class MainMenu : Menu
{
    // Primary Ctor
    public MainMenu(Dictionary<int, string>? select)
    {
        PopulateSelection(select);
    }
    // No Argument Ctor
    public MainMenu() : this(null)
    {
    }
    // Used to fill selections field in a polymorphic fashion
    public override void PopulateSelection(Dictionary<int, string>? select)
    {
        if (select == null)
        {
            selections = new Dictionary<int, string>
            {
                {1, "Diaries"},
                {2, "Settings"},
                {3, "Exit"},
            };
        }
        else
        {
            selections = new Dictionary<int, string>(select);
        }
    }
    public override void DisplaySelections()
    {
        Console.WriteLine("Welcome to TerminalDiary!");
        Console.WriteLine("------------------------------------");
        base.DisplaySelections();
    }

    public override void HandleUserInput(int input)
    {
        throw new NotImplementedException();
    }
}