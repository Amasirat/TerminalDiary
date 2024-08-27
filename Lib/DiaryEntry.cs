namespace Lib;

public class DiaryEntry
{
    // Master ctor
    public DiaryEntry(string title, string text, DateTime date)
    {
        Title = title;
        Text = text;
        Date = date;
    }

    public DiaryEntry(DateTime date, string text) : this(date.ToString(), text, date)
    {
    }

    public string Text {get; set;}
    public string Title {get; set;}
    public DateTime Date {get; set;}
}
