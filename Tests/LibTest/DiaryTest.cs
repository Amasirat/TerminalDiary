namespace LibTest;
using System.Collections.Generic;
using Lib;

[TestClass]
public class DiaryTest
{
    [TestMethod]
    public void TestAddEntry()
    {
        DiaryEntry entry = new DiaryEntry(new DateTime(2012,2,2), "6");

        testDiary.AddEntry(entry);

        Assert.IsTrue(testDiary.Entries.Contains(entry), "Expected to find entry in testDiary");
    }

    [TestMethod]
    public void TestRemoveEntry()
    {
        DiaryEntry entry = new DiaryEntry(new DateTime(2012,2,2), "6");

        testDiary.RemoveEntry(entry);

        Assert.IsFalse(testDiary.Entries.Contains(entry), "Expected to not find entry in testDiary");
    }

    [TestMethod]
    public void TestContainsEntry()
    {
        Assert.IsTrue(testDiary.Entries.Contains(testEntries[2]), "Expected to find entry in testDiary but did not");
    }

    public static List<DiaryEntry> testEntries = new List<DiaryEntry> {
        new DiaryEntry(new DateTime(2012,2,1), "1"),
        new DiaryEntry(new DateTime(2012,1,1), "2"),
        new DiaryEntry(new DateTime(2012,1,1), "3"),
        new DiaryEntry(new DateTime(2012,1,1), "4"),
        new DiaryEntry(new DateTime(2012,1,1), "5")
    };

    public static Diary testDiary = new Diary("test", testEntries);
}