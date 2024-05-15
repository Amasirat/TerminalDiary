namespace Lib;

public class Menu
{
    public static void DisplayEntries(Diary diary)
    {
        List<DiaryEntry> entries = diary.Entries;
        string usrInputHint;
        string exitHint = "x for Exit";

        int entryCounter = new int(Mathf.Clamp(entryCounter, 0, entries.Count - 1));
        entryCounter = 0;

        string usrInput;
        bool loopOver = false;
        while(!loopOver)
        {
            if(entryCounter == 0) 
                usrInputHint = $"1.Next";
            else if (entryCounter < entries.Count - 1)
            {
                usrInputHint = $"0.Previous/1.Next";
            }
            else
            {
                usrInputHint = $"0.Previous";
            }

            usrInputHint += $"\n{exitHint}";//adding a hint for exit despite what usrInputHint becomes


            Console.WriteLine($"Title: {entries[entryCounter].Title}");
            Console.WriteLine($"Date: {entries[entryCounter].Date.ToString()}");
            Console.WriteLine(entries[entryCounter].Text);
            Console.WriteLine(usrInputHint);

            usrInput = Console.ReadLine();
            switch(usrInput)
            {
                case ("0" && entryCounter != 0):
                    entryCounter--;
                    break;
                case ("1" && entryCounter != entries.Count - 1)
                    entryCounter++;
                    break;
                case ("x"):
                    loopOver = true;
                    break;
                default:
                    Console.WriteLine("Wrong user input");
            }
        }
        // foreach (var entry in entries)
        // {
        //     while(true)
        //     {
        //         Console.WriteLine($"Title: {entry.Title}");
        //         Console.WriteLine($"Date: {entry.Date.ToString()}");
        //         Console.WriteLine($"{entry.Text}");
        //         Console.WriteLine("1.Previous\n2.Next")
        //     }
        // }
    }

    
}