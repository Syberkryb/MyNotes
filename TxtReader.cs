
public class txtReader
{
    string path = Directory.GetCurrentDirectory()+"/Pages/";
    

    List<Chapter> chapters = new List<Chapter>();
    public txtReader()
    {
        foreach (string ChapterFolder in Directory.GetDirectories())
        {
            string Loops =  ChapterFolder.Substring(ChapterFolder.LastIndexOf('/')+1);
            Chapter kap6 = new Chapter(Loops);
            chapters.Add(kap6);
        }


        
    }







};