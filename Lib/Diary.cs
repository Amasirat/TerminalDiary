using System.Collections.Generic;
namespace Lib;

public class Diary
{
// Master ctor
    public Diary(string name, List<DiaryEntry> usrEntries)
    {
        Name = name;
        Entries = usrEntries;
    }

    public Diary(string name = "NoName") : this(name, null)
    {}

    public void AddEntry(DiaryEntry entry)
    {
        if(Entries == null)
        {
            Entries = new List<DiaryEntry>();
        }

        Entries.Add(entry);
    }

    public void RemoveEntry(DiaryEntry entry)
    {
        if(Entries == null)
            return;
        Entries.Remove(entry);
    }

    public bool ContainsEntry(DiaryEntry entry)
    {
        return Entries.Contains(entry);
    }

    public List<DiaryEntry> GetEntries()
    {
        return 
    }

    public string Name {get; set;}
    // events to communicate with outside classes
    public event UploadEventHandler ReadyToUpload;
    public event DisplayEventHandler ReadyToDisplay;

    public List<DiaryEntry> Entries 
    {
        get { return Entries; }
    }
    private delegate void UploadEventHandler(Diary diary);//Used to hook up a database uploader of some kind
    private delegate void DisplayEventHandler(Diary diary);//Used to hook up to the console
}