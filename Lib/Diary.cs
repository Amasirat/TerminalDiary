using System.Collections.Generic;
namespace Lib;

public class Diary
{
// Master ctor
    public Diary(string name, List<DiaryEntry> usrEntries)
    {
        Name = name;
        entries = usrEntries;
    }

    public Diary(string name) : this(name, null)
    {}

    public void AddEntry(DiaryEntry entry)
    {
        if(entries == null)
        {
            entries = new List<DiaryEntry>();
        }

        entries.Add(entry);
    }

    public void RemoveEntry(DiaryEntry entry)
    {
        if(entries == null)
            return;
        entries.Remove(entry);
    }

    public bool ContainsEntry(DiaryEntry entry)
    {
        return entries.Contains(entry);
    }

    public string Name {get; set;}
    public event UploadEventHandler ReadyToUpload;
    public event DisplayEventHandler ReadyToDisplay;
    private List<DiaryEntry> entries;
    private delegate void UploadEventHandler(DiaryEntry entry);
    private delegate void DisplayEventHandler(DiaryEntry entry);
}