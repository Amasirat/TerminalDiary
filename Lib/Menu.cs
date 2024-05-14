namespace Lib;

public class Menu
{
//needs better implementation, currently it cannot go to previous entries
    public static void DisplayEntries(Diary diary)
    {
        List<DiaryEntry> entries = diary.Entries;

        foreach (var entry in entries)
        {
            while(true)
            {
                Console.WriteLine($"Title: {entry.Title}");
                Console.WriteLine($"Date: {entry.Date.ToString()}");
                Console.WriteLine($"{entry.Text}");
                Console.WriteLine("1.Previous\n2.Next")
            }
        }
    }

    
}