namespace TerminalDiary;

public class MainMenu : Menu
{
    public MainMenu()
    {
        PopulateSelection();
    }
    // Used to fill selections field in a polymorphic fashion
    public override void PopulateSelection()
    {
        selections = new Dictionary<int, string>
        {
            { 1, "Diaries" },
            { 2, "Settings" },
            { 3, "Exit" },
        };
    }
    public override void DisplaySelections()
    {
        Console.WriteLine("Welcome to TerminalDiary!");
        Console.WriteLine("------------------------------------");
        base.DisplaySelections();
    }

    public override void HandleUserInput(int input)
    {
        switch (input)
        {
            case 1:
            {
                break;
            }
            case 2:
            {
                break;
            }
            case 3:
            {
                break;
            }
            default:
                Console.WriteLine("Invalid Input. Try Again.");
                break;
        }
    }
}