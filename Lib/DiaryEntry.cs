using System.DateTime;
namespace Lib;

public class DiaryEntry
{
    public DiaryEntry(string title, string text, DateTime date, UploadNotifier UploaderMethod)
    {
        Title = title;
        Text = text;
        Date = date;
        ReadyToUpload = UploaderMethod;
    }

    public deligate void UploadNotifier(string text);

    public string Text {get; set;}

    public string Title {get; set;}

    public DateTime Date {get; set;}

    public event UploadNotifier ReadyToUpload;
}
