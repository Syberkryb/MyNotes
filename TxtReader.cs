
public class txtReader
{
    string path = Directory.GetCurrentDirectory()+"/Pages/Loops/";
    

    List<Chapter> chapters2 = new List<Chapter>();
    public txtReader()
    {
        foreach (string ChapterFolder in Directory.GetDirectories(path))
        {
            string chapterName =  ChapterFolder.Substring(ChapterFolder.LastIndexOf('/')+1);
            Chapter chapter = new Chapter(chapterName);
            chapters2.Add(chapter);
        }

foreach (string pageFile in Directory.GetFiles(path))
        {
            string pageContent = File.ReadAllText(pageFile);
            Page page = new Page(pageContent);
            chapters2[0].Pages.Add(page);}
    }
        
    }