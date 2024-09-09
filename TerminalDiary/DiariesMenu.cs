using Lib;

namespace TerminalDiary;

public class DiariesMenu : Menu
{
    
    public DiariesMenu(List<Diary> diaries)
    {
            PopulateSelection();
            DiaryList = diaries;
 
    }
    // Used to fill selections field in a polymorphic fashion
    public override void PopulateSelection()
    {
        selections = new Dictionary<int, string>
        {
            { 1, "Show Diaries" },
            { 2, "Create New Diary" },
            { 3, "Back" },
        };
    }
    public override void HandleUserInput(int input)
    {
        switch (input)
        {
            case 1:
            { 
                ShowDiaries();
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
    private void ShowDiaries()
    {
        if (DiaryList.Count == 0)
        {
            Console.WriteLine("No diaries have been found. Create a Diary?[Y/n]");
            if (Console.ReadLine() == "n")
            {
                return;
            }
        }

        int index = 1;
        foreach (var diary in DiaryList)
        {
            Console.WriteLine($"{index}--{diary.Name}");
            index++;
        }
        int diaryNum = int.Parse(Console.ReadLine());
        if(diaryNum <= DiaryList.Count || diaryNum > 0)
            new EntryMenu(DiaryList[diaryNum - 1], this).DisplaySelections();
    }
    private List<Diary>? DiaryList { get; }
}
