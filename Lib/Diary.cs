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
        if(Entries != null) 
            Entries.Remove(entry);
    }
    public string Name {get; set;}
    public List<DiaryEntry> Entries { get; set; }
}