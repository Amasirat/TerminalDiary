namespace TerminalDiary;
using Lib;

public class EntryMenu : Menu
{
    public EntryMenu(Diary diary, Menu src)
    {
        this.diary = diary;
        srcMenu = src;
    }
    // Used to fill selections field in a polymorphic fashion
    public override void PopulateSelection()
    {
        selections = new Dictionary<int, string>
        {
            { 1, "Show Entries" },
            { 2, "Create New Entry" },
            { 3, "Back" },
        };
    }
    public override void HandleUserInput(int input)
    {
        switch (input)
        {
            case 1:
            {
                ShowEntries();
                break;
            }
            case 2:
            {
                break;
            }
            case 3:
            {
                srcMenu.DisplaySelections();
                break;
            }
            default:
                Console.WriteLine("Invalid Input. Try Again.");
                break;
        }
    }

    private void ShowEntries()
    {
        foreach (var entry in diary.Entries)
        {
            Console.WriteLine($"-{entry.Title}\n{entry.Date}\n{entry.Text}\n------------------");
        }
    }

    private Diary diary;
    private Menu srcMenu;
}